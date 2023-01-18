import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExamSectionResultColumns, ExamSectionResultRow, ExamSectionResultService } from '../../ServerTypes/Workspace';
import { ExcelExportHelper, ReportHelper } from '@serenity-is/extensions';
import { ExamSectionResultDialog } from './ExamSectionResultDialog';

@Decorators.registerClass()
export class ExamSectionResultGrid extends EntityGrid<ExamSectionResultRow, any> {
    protected getColumnsKey() { return ExamSectionResultColumns.columnsKey; }
    protected getDialogType() { return ExamSectionResultDialog; }
    protected getIdProperty() { return ExamSectionResultRow.idProperty; }
    protected getInsertPermission() { return ExamSectionResultRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamSectionResultRow.localTextPrefix; }
    protected getService() { return ExamSectionResultService.baseUrl; }

    private rowSelection: GridRowSelectionMixin;

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns() {
        var columns = super.getColumns();

        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        columns.splice(1, 0, {
            field: 'Pivot Report',
            name: '',
            format: ctx => '<a class="inline-action pivot-report" title="Pivot Report">' +
                '<i class="fa fa-file-pdf-o text-red"></i></a>',
            width: 36,
            minWidth: 36,
            maxWidth: 36
        });
        return columns;

    }
    protected createToolbarExtensions() {
        super.createToolbarExtensions();
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(0, 2);

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            title: 'Export',
            service: ExamSectionResultService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        return buttons;
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

            if (target.hasClass('pivot-report')) {
               
                Q.postToService({ url: Q.resolveUrl('~/SectionReport/Pivotreport?ScannedSheetId=' + item.SheetGuid), request: '', target: '_blank' });
            }

            

           
        }
    }
}