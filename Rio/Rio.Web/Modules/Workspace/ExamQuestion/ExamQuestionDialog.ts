import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamQuestionForm, ExamQuestionRow, ExamQuestionService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamQuestionDialog extends EntityDialog<ExamQuestionRow, any> {
    protected getFormKey() { return ExamQuestionForm.formKey; }
    protected getIdProperty() { return ExamQuestionRow.idProperty; }
    protected getLocalTextPrefix() { return ExamQuestionRow.localTextPrefix; }
    protected getNameProperty() { return ExamQuestionRow.nameProperty; }
    protected getService() { return ExamQuestionService.baseUrl; }
    protected getDeletePermission() { return ExamQuestionRow.deletePermission; }
    protected getInsertPermission() { return ExamQuestionRow.insertPermission; }
    protected getUpdatePermission() { return ExamQuestionRow.updatePermission; }

    protected form = new ExamQuestionForm(this.idPrefix);

}