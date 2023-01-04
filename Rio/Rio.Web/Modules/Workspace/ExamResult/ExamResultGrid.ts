import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExamResultColumns, ExamResultRow, ExamResultService } from '../../ServerTypes/Workspace';
import { Column } from "@serenity-is/sleekgrid";
import { ReportHelper } from "@serenity-is/extensions";
import { ExamResultDialog } from './ExamResultDialog';
import { postToService, resolveUrl } from '@serenity-is/corelib/q';

@Decorators.registerClass()
export class ExamResultGrid extends EntityGrid<ExamResultRow, any> {
    protected getColumnsKey() { return ExamResultColumns.columnsKey; }
    protected getDialogType() { return ExamResultDialog; }
    protected getIdProperty() { return ExamResultRow.idProperty; }
    protected getInsertPermission() { return ExamResultRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamResultRow.localTextPrefix; }
    protected getService() { return ExamResultService.baseUrl; }

    private rowSelection: GridRowSelectionMixin;

    private ScannedBatchInsertDate;
    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }

    protected getColumns(): Column[] {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));

        columns.splice(2, 0, {
            field: 'Print Result',
            name: '',
            format: ctx => '<a class="inline-action print-result" title="Result">' +
                '<i class="fa fa-file-pdf-o text-red"></i></a>',
            width: 36,
            minWidth: 36,
            maxWidth: 36
        });

        return columns;
    }

    protected onClick(e: JQueryEventObject, row: number, cell: number) {
        super.onClick(e, row, cell);

        if (e.isDefaultPrevented())
            return;

        var item = this.itemAt(row);
        var target = $(e.target);

        // if user clicks "i" element, e.g. icon
        if (target.parent().hasClass('inline-action'))
            target = target.parent();

        if (target.hasClass('inline-action')) {
            e.preventDefault();

            if (target.hasClass('print-result')) {
                var param = {
                    'ExamResultId': item.Id,
                    'ExamId': item.ExamId
                };
                var url = "/ExamResult/ExamResultReport";
                postToService({ url: resolveUrl('~/ExamResult/ExamResultReport?ExamResultId=' + item.Id), request: '', target: '_blank' });
            }
/*
            if (target.hasClass('print-result')) {
                ReportHelper.execute({
                    reportKey: 'Workspace.ExamResult',
                    extension: 'html',
                    params: {
                        ExamId: item.ExamId
                    },
                    target: '_blank'
                });
            }*/
        }
    }
}