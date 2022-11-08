import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ImportedScannedBatchForm, ImportedScannedBatchRow, ImportedScannedBatchService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ImportedScannedBatchDialog extends EntityDialog<ImportedScannedBatchRow, any> {
    protected getFormKey() { return ImportedScannedBatchForm.formKey; }
    protected getIdProperty() { return ImportedScannedBatchRow.idProperty; }
    protected getLocalTextPrefix() { return ImportedScannedBatchRow.localTextPrefix; }
    protected getNameProperty() { return ImportedScannedBatchRow.nameProperty; }
    protected getService() { return ImportedScannedBatchService.baseUrl; }
    protected getDeletePermission() { return ImportedScannedBatchRow.deletePermission; }
    protected getInsertPermission() { return ImportedScannedBatchRow.insertPermission; }
    protected getUpdatePermission() { return ImportedScannedBatchRow.updatePermission; }

    protected form = new ImportedScannedBatchForm(this.idPrefix);

}