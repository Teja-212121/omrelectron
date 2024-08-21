import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CloudStorageSettingForm, CloudStorageSettingRow, CloudStorageSettingService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class CloudStorageSettingDialog extends EntityDialog<CloudStorageSettingRow, any> {
    protected getFormKey() { return CloudStorageSettingForm.formKey; }
    protected getIdProperty() { return CloudStorageSettingRow.idProperty; }
    protected getLocalTextPrefix() { return CloudStorageSettingRow.localTextPrefix; }
    protected getNameProperty() { return CloudStorageSettingRow.nameProperty; }
    protected getService() { return CloudStorageSettingService.baseUrl; }
    protected getDeletePermission() { return CloudStorageSettingRow.deletePermission; }
    protected getInsertPermission() { return CloudStorageSettingRow.insertPermission; }
    protected getUpdatePermission() { return CloudStorageSettingRow.updatePermission; }

    protected form = new CloudStorageSettingForm(this.idPrefix);

}