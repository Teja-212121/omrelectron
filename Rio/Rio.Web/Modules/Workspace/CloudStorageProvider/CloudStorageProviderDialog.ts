import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CloudStorageProviderForm, CloudStorageProviderRow, CloudStorageProviderService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class CloudStorageProviderDialog extends EntityDialog<CloudStorageProviderRow, any> {
    protected getFormKey() { return CloudStorageProviderForm.formKey; }
    protected getIdProperty() { return CloudStorageProviderRow.idProperty; }
    protected getLocalTextPrefix() { return CloudStorageProviderRow.localTextPrefix; }
    protected getNameProperty() { return CloudStorageProviderRow.nameProperty; }
    protected getService() { return CloudStorageProviderService.baseUrl; }
    protected getDeletePermission() { return CloudStorageProviderRow.deletePermission; }
    protected getInsertPermission() { return CloudStorageProviderRow.insertPermission; }
    protected getUpdatePermission() { return CloudStorageProviderRow.updatePermission; }

    protected form = new CloudStorageProviderForm(this.idPrefix);

}