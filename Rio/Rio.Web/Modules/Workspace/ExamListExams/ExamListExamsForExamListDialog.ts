import { Decorators, EntityDialog, ToolButton } from '@serenity-is/corelib';
import { notifyError, notifySuccess } from '@serenity-is/corelib/q';
import { ExamListExamsForExamListForm, ExamListExamsRow, ExamListExamsService, ExamQuestionService, ExamRow, ExamService } from '../../ServerTypes/Workspace';


@Decorators.registerClass()
export class ExamListExamsForExamListDialog extends EntityDialog<ExamListExamsRow, any> {
    protected getFormKey() { return ExamListExamsForExamListForm.formKey; }
    protected getService() { return ExamListExamsService.baseUrl; }

    protected form = new ExamListExamsForExamListForm(this.idPrefix);
    private IsEditMode: boolean;
    private rowids: string;

    constructor(gridToRefresh, FormMode, selectedids) {
        super();
        /*this.Studentgrid = gridToRefresh;*/
        this.IsEditMode = FormMode;
        this.rowids = selectedids;
        this.dialogTitle = "Assign List Exams";
    }
    protected getToolbarButtons(): ToolButton[] {
        let buttons = super.getToolbarButtons();
        //debugger;
        buttons.splice(0, 6);
        buttons.push({
            title: "Assign",
            cssClass: 'edit-permissions-button ',
            icon: 'fa-plus',
            onClick: () => {

                if (!this.validateBeforeSave())
                    return;
             
                this.entity.RowIds = this.rowids.toString();
                this.entity.ExamListId = Number(this.form.ExamListId.value);
                this.entity.StartDate = this.form.StartDate.value;
                this.entity.EndDate = this.form.EndDate.value;
                this.entity.ModelAnswerPaperStartDate = this.form.ModelAnswerPaperStartDate.value;

                ExamListExamsService.AssignExamList({
                    EntityId: 1,
                    Entity: this.entity

                }, response => {
                    
                });
                notifySuccess("Assign Succesfully");
                this.dialogClose();
            }
        });
        buttons.push({
            title: "Cancel",
            icon: 'fa-minus',
            onClick: () => { this.dialogClose() }
        });

        return buttons;

    }
}