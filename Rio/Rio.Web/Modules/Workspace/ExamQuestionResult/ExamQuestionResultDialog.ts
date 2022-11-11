import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamQuestionResultForm, ExamQuestionResultRow, ExamQuestionResultService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamQuestionResultDialog extends EntityDialog<ExamQuestionResultRow, any> {
    protected getFormKey() { return ExamQuestionResultForm.formKey; }
    protected getIdProperty() { return ExamQuestionResultRow.idProperty; }
    protected getLocalTextPrefix() { return ExamQuestionResultRow.localTextPrefix; }
    protected getNameProperty() { return ExamQuestionResultRow.nameProperty; }
    protected getService() { return ExamQuestionResultService.baseUrl; }
    protected getDeletePermission() { return ExamQuestionResultRow.deletePermission; }
    protected getInsertPermission() { return ExamQuestionResultRow.insertPermission; }
    protected getUpdatePermission() { return ExamQuestionResultRow.updatePermission; }

    protected form = new ExamQuestionResultForm(this.idPrefix);

}