import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { ScannedQuestionColumns, ScannedQuestionRow, ScannedQuestionService } from '../../ServerTypes/Workspace';
import { ScannedQuestionDialog } from './ScannedQuestionDialog';

@Decorators.registerClass()
export class ScannedQuestionGrid extends EntityGrid<ScannedQuestionRow, any> {
    protected getColumnsKey() { return ScannedQuestionColumns.columnsKey; }
    protected getDialogType() { return ScannedQuestionDialog; }
    protected getIdProperty() { return ScannedQuestionRow.idProperty; }
    protected getInsertPermission() { return ScannedQuestionRow.insertPermission; }
    protected getLocalTextPrefix() { return ScannedQuestionRow.localTextPrefix; }
    protected getService() { return ScannedQuestionService.baseUrl; }

    private rowSelection: GridRowSelectionMixin;

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }
    protected getColumns() {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));

        return columns;
    }
    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }

    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(1, 1);

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            title: 'Export',
            service: ScannedQuestionService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        return buttons;
    }
}