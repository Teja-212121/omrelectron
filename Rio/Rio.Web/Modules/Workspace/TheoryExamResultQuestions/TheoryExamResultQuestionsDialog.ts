import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TheoryExamResultQuestionsForm, TheoryExamResultQuestionsRow, TheoryExamResultQuestionsService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class TheoryExamResultQuestionsDialog extends EntityDialog<TheoryExamResultQuestionsRow, any> {
    protected getFormKey() { return TheoryExamResultQuestionsForm.formKey; }
    protected getIdProperty() { return TheoryExamResultQuestionsRow.idProperty; }
    protected getLocalTextPrefix() { return TheoryExamResultQuestionsRow.localTextPrefix; }
    protected getService() { return TheoryExamResultQuestionsService.baseUrl; }
    protected getDeletePermission() { return TheoryExamResultQuestionsRow.deletePermission; }
    protected getInsertPermission() { return TheoryExamResultQuestionsRow.insertPermission; }
    protected getUpdatePermission() { return TheoryExamResultQuestionsRow.updatePermission; }

    protected form = new TheoryExamResultQuestionsForm(this.idPrefix);

}