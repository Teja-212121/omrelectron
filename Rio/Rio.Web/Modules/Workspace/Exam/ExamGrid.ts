import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { Authorization, serviceRequest } from '@serenity-is/corelib/q';
import { ExamColumns, ExamRow, ExamService } from '../../ServerTypes/Workspace';
import { ExamDialog } from './ExamDialog';

@Decorators.registerClass()
export class ExamGrid extends EntityGrid<ExamRow, any> {
    protected getColumnsKey() { return ExamColumns.columnsKey; }
    protected getDialogType() { return ExamDialog; }
    protected getIdProperty() { return ExamRow.idProperty; }
    protected getInsertPermission() { return ExamRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamRow.localTextPrefix; }
    protected getService() { return ExamService.baseUrl; }

    private rowSelection: GridRowSelectionMixin;

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

     protected getColumns() {
         var columns = super.getColumns();

         columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
         if (!Authorization.hasPermission("Administration:Security")) {
             columns = columns.filter(f => f.field != ExamRow.Fields.TenantId);
         }
         return columns;

    }
    protected createToolbarExtensions() {
        super.createToolbarExtensions();
        this.rowSelection = new GridRowSelectionMixin(this);
    }
    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(1, 3);

        buttons.push({
            title: 'Delete Exam', cssClass: 'delete-button',
            onClick: () => {

                var rowKeys = this.rowSelection.getSelectedKeys();
                if (rowKeys.length == 0) {
                    alert("Please select record(s)");
                    return;
                }
                else {
                    Q.confirm('Are you sure you want to Delete?', () => {

                        serviceRequest('/Services/Workspace/Exam/DeleteExam', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
                    });

                }
            }
        });

        return buttons;
    }
}

