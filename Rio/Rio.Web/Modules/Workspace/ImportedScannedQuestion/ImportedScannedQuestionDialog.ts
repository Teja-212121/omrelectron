import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ImportedScannedQuestionForm, ImportedScannedQuestionRow, ImportedScannedQuestionService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ImportedScannedQuestionDialog extends EntityDialog<ImportedScannedQuestionRow, any> {
    protected getFormKey() { return ImportedScannedQuestionForm.formKey; }
    protected getIdProperty() { return ImportedScannedQuestionRow.idProperty; }
    protected getLocalTextPrefix() { return ImportedScannedQuestionRow.localTextPrefix; }
    protected getService() { return ImportedScannedQuestionService.baseUrl; }
    protected getDeletePermission() { return ImportedScannedQuestionRow.deletePermission; }
    protected getInsertPermission() { return ImportedScannedQuestionRow.insertPermission; }
    protected getUpdatePermission() { return ImportedScannedQuestionRow.updatePermission; }

    protected form = new ImportedScannedQuestionForm(this.idPrefix);

}