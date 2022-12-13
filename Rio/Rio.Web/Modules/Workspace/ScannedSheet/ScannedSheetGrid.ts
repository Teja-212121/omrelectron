import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { Column } from '@serenity-is/sleekgrid';
import { ScannedSheetColumns, ScannedSheetRow, ScannedSheetService } from '../../ServerTypes/Workspace';
import { ScannedQuestionGrid } from '../ScannedQuestion/ScannedQuestionGrid';
import { ScannedSheetDialog } from './ScannedSheetDialog';

@Decorators.registerClass()
export class ScannedSheetGrid extends EntityGrid<ScannedSheetRow, any> {
    protected getColumnsKey() { return ScannedSheetColumns.columnsKey; }
    protected getDialogType() { return ScannedSheetDialog; }
    protected getIdProperty() { return ScannedSheetRow.idProperty; }
    protected getInsertPermission() { return ScannedSheetRow.insertPermission; }
    protected getLocalTextPrefix() { return ScannedSheetRow.localTextPrefix; }
    protected getService() { return ScannedSheetService.baseUrl; }

    private rowSelection: GridRowSelectionMixin;

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }
    protected getColumns(): Column[]  {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        Q.first(columns, x => x.field == ScannedSheetRow.Fields.ScannedStatus).cssClass += " col-scanned-status";

        /*columns.splice(1, 0, {
            id: 'View Sheet',
            field: null,
            name: '',
            cssClass: 'align-center',
            format: ctx => 
                `<a class="inline-image view-sheet" title="sheet" target="_blank" href="/upload/">` +
                `<img src="/upload/" class="fa fa-file-text-o text-blue" style="max-height: 145px; max-width: 100%;" /></a>`,
            width: 36,
            minWidth: 36,
            maxWidth: 36
        });*/

        columns.splice(2, 0, {
            field: 'View Sheet Question',
            name: '',
            format: ctx => `<a class="inline-action view-sheet-question" title="view sheet question">
                    <i class="fa fa-pencil-square-o"></i></a>`,
            width: 24,
            minWidth: 24,
            maxWidth: 24
        });
        return columns;
    }
    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }

    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(0, 1);

        

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            title: 'Export',
            service: ScannedSheetService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        buttons.push({
            title: 'Generate Result',
            cssClass: 'send-button',
            onClick: () => {
                var rowKeys = this.rowSelection.getSelectedKeys();
                if (rowKeys.length == 0) {
                    Q.alert("Select Sheet To Process Result");
                    return;
                }
                
                    Q.confirm('Are you sure you want to Process Result?', () => {

                        Q.serviceRequest('/Services/Workspace/ScannedSheet/UpdateResult', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
                    });
                
            },
            separator: true
        });

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

            /*if (target.hasClass('view-sheet')) {
                ReportHelper.execute({
                    reportKey: 'Workspace.ScannedSheet',
                    params: {
                        Id: item.Id
                    }
                });
            }
            else*/ if (target.hasClass('view-sheet-question')) {
                var dlg = new ScannedQuestionGrid($('#GridDiv'));
                this.initDialog(dlg);
                dlg.getGridField();
            }
        }
    }

    protected getItemCssClass(item: ScannedSheetRow, index: number): string {
        let klass: string = "";

        if (item.ScannedStatus == 1)
            klass += " failed-sheet";
        else if (item.ScannedStatus == 2)
            klass += " warning-sheet";
        else
            klass += " success-sheet";

        return Q.trimToNull(klass);
    }
}