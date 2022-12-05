import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TheoryExamQuestionsForm, TheoryExamQuestionsRow, TheoryExamQuestionsService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class TheoryExamQuestionsDialog extends EntityDialog<TheoryExamQuestionsRow, any> {
    protected getFormKey() { return TheoryExamQuestionsForm.formKey; }
    protected getIdProperty() { return TheoryExamQuestionsRow.idProperty; }
    protected getLocalTextPrefix() { return TheoryExamQuestionsRow.localTextPrefix; }
    protected getNameProperty() { return TheoryExamQuestionsRow.nameProperty; }
    protected getService() { return TheoryExamQuestionsService.baseUrl; }
    protected getDeletePermission() { return TheoryExamQuestionsRow.deletePermission; }
    protected getInsertPermission() { return TheoryExamQuestionsRow.insertPermission; }
    protected getUpdatePermission() { return TheoryExamQuestionsRow.updatePermission; }

    protected form = new TheoryExamQuestionsForm(this.idPrefix);

}