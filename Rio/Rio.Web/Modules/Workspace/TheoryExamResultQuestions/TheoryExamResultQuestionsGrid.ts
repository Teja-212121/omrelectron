import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { TheoryExamResultQuestionsColumns, TheoryExamResultQuestionsRow, TheoryExamResultQuestionsService } from '../../ServerTypes/Workspace';
import { TheoryExamResultQuestionsDialog } from './TheoryExamResultQuestionsDialog';

@Decorators.registerClass()
export class TheoryExamResultQuestionsGrid extends EntityGrid<TheoryExamResultQuestionsRow, any> {
    protected getColumnsKey() { return TheoryExamResultQuestionsColumns.columnsKey; }
    protected getDialogType() { return TheoryExamResultQuestionsDialog; }
    protected getIdProperty() { return TheoryExamResultQuestionsRow.idProperty; }
    protected getInsertPermission() { return TheoryExamResultQuestionsRow.insertPermission; }
    protected getLocalTextPrefix() { return TheoryExamResultQuestionsRow.localTextPrefix; }
    protected getService() { return TheoryExamResultQuestionsService.baseUrl; }

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
            service: TheoryExamResultQuestionsService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        return buttons;
    }
}