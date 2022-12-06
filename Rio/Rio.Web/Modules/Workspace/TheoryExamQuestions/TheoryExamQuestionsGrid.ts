import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { TheoryExamQuestionsColumns, TheoryExamQuestionsRow, TheoryExamQuestionsService } from '../../ServerTypes/Workspace';
import { TheoryExamQuestionsDialog } from './TheoryExamQuestionsDialog';

@Decorators.registerClass()
export class TheoryExamQuestionsGrid extends EntityGrid<TheoryExamQuestionsRow, any> {
    protected getColumnsKey() { return TheoryExamQuestionsColumns.columnsKey; }
    protected getDialogType() { return TheoryExamQuestionsDialog; }
    protected getIdProperty() { return TheoryExamQuestionsRow.idProperty; }
    protected getInsertPermission() { return TheoryExamQuestionsRow.insertPermission; }
    protected getLocalTextPrefix() { return TheoryExamQuestionsRow.localTextPrefix; }
    protected getService() { return TheoryExamQuestionsService.baseUrl; }

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
            service: TheoryExamQuestionsService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        return buttons;
    }
}