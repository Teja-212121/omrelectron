import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { ExamQuestionResultColumns, ExamQuestionResultRow, ExamQuestionResultService } from '../../ServerTypes/Workspace';
import { ExamQuestionResultDialog } from './ExamQuestionResultDialog';

@Decorators.registerClass()
export class ExamQuestionResultGrid extends EntityGrid<ExamQuestionResultRow, any> {
    protected getColumnsKey() { return ExamQuestionResultColumns.columnsKey; }
    protected getDialogType() { return ExamQuestionResultDialog; }
    protected getIdProperty() { return ExamQuestionResultRow.idProperty; }
    protected getInsertPermission() { return ExamQuestionResultRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamQuestionResultRow.localTextPrefix; }
    protected getService() { return ExamQuestionResultService.baseUrl; }

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
            service: ExamQuestionResultService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        return buttons;
    }
}