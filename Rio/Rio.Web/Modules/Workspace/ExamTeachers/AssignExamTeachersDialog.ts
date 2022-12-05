import { Decorators, EntityDialog, ToolButton } from '@serenity-is/corelib';
import { AssignExamTeachersForm, ExamTeachersForm, ExamTeachersRow, ExamTeachersService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class AssignExamTeachersDialog extends EntityDialog<ExamTeachersRow, any> {
    protected getFormKey() { return AssignExamTeachersForm.formKey; }
    protected getIdProperty() { return ExamTeachersRow.idProperty; }
    protected getLocalTextPrefix() { return ExamTeachersRow.localTextPrefix; }
    protected getService() { return ExamTeachersService.baseUrl; }
    protected getDeletePermission() { return ExamTeachersRow.deletePermission; }
    protected getInsertPermission() { return ExamTeachersRow.insertPermission; }
    protected getUpdatePermission() { return ExamTeachersRow.updatePermission; }

    protected form = new AssignExamTeachersForm(this.idPrefix);
    private IsEditMode: boolean;
    private rowids: string;

    constructor(gridToRefresh, FormMode, selectedids) {
        super();
        /*this.Studentgrid = gridToRefresh;*/
        this.IsEditMode = FormMode;
        this.rowids = selectedids;
        this.dialogTitle = "Assign Exams to Teacher";
    }
    protected getToolbarButtons(): ToolButton[] {
        let buttons = super.getToolbarButtons();


        

        // We could also remove delete button here, but for demonstration 
        // purposes we'll hide it in another method (updateInterface)
        

        return buttons;
    }

    loadEntity(entity: ExamTeachersRow) {
        //debugger;
        super.loadEntity(entity);
        //debugger;
        this.form.RowIds.value = this.rowids;
      

    }
}