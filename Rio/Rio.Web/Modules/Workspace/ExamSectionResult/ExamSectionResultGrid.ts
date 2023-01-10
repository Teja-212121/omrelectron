import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { ExamSectionResultColumns, ExamSectionResultRow, ExamSectionResultService } from '../../ServerTypes/Workspace';
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
}