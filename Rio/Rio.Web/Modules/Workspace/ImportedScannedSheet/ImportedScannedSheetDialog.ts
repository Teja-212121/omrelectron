import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ImportedScannedSheetForm, ImportedScannedSheetRow, ImportedScannedSheetService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ImportedScannedSheetDialog extends EntityDialog<ImportedScannedSheetRow, any> {
    protected getFormKey() { return ImportedScannedSheetForm.formKey; }
    protected getIdProperty() { return ImportedScannedSheetRow.idProperty; }
    protected getLocalTextPrefix() { return ImportedScannedSheetRow.localTextPrefix; }
    protected getNameProperty() { return ImportedScannedSheetRow.nameProperty; }
    protected getService() { return ImportedScannedSheetService.baseUrl; }
    protected getDeletePermission() { return ImportedScannedSheetRow.deletePermission; }
    protected getInsertPermission() { return ImportedScannedSheetRow.insertPermission; }
    protected getUpdatePermission() { return ImportedScannedSheetRow.updatePermission; }

    protected form = new ImportedScannedSheetForm(this.idPrefix);

}