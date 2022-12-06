import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { TheoryExamResultsColumns, TheoryExamResultsRow, TheoryExamResultsService } from '../../ServerTypes/Workspace';
import { TheoryExamResultsDialog } from './TheoryExamResultsDialog';

@Decorators.registerClass()
export class TheoryExamResultsGrid extends EntityGrid<TheoryExamResultsRow, any> {
    protected getColumnsKey() { return TheoryExamResultsColumns.columnsKey; }
    protected getDialogType() { return TheoryExamResultsDialog; }
    protected getIdProperty() { return TheoryExamResultsRow.idProperty; }
    protected getInsertPermission() { return TheoryExamResultsRow.insertPermission; }
    protected getLocalTextPrefix() { return TheoryExamResultsRow.localTextPrefix; }
    protected getService() { return TheoryExamResultsService.baseUrl; }

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
            service: TheoryExamResultsService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        return buttons;
    }
}