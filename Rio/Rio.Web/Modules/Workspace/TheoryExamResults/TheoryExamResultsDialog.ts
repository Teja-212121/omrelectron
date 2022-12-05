import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TheoryExamResultsForm, TheoryExamResultsRow, TheoryExamResultsService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class TheoryExamResultsDialog extends EntityDialog<TheoryExamResultsRow, any> {
    protected getFormKey() { return TheoryExamResultsForm.formKey; }
    protected getIdProperty() { return TheoryExamResultsRow.idProperty; }
    protected getLocalTextPrefix() { return TheoryExamResultsRow.localTextPrefix; }
    protected getNameProperty() { return TheoryExamResultsRow.nameProperty; }
    protected getService() { return TheoryExamResultsService.baseUrl; }
    protected getDeletePermission() { return TheoryExamResultsRow.deletePermission; }
    protected getInsertPermission() { return TheoryExamResultsRow.insertPermission; }
    protected getUpdatePermission() { return TheoryExamResultsRow.updatePermission; }

    protected form = new TheoryExamResultsForm(this.idPrefix);

}