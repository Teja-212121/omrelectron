import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { SettingsForm, SettingsRow, SettingsService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class SettingsDialog extends EntityDialog<SettingsRow, any> {
    protected getFormKey() { return SettingsForm.formKey; }
    protected getIdProperty() { return SettingsRow.idProperty; }
    protected getLocalTextPrefix() { return SettingsRow.localTextPrefix; }
    protected getNameProperty() { return SettingsRow.nameProperty; }
    protected getService() { return SettingsService.baseUrl; }
    protected getDeletePermission() { return SettingsRow.deletePermission; }
    protected getInsertPermission() { return SettingsRow.insertPermission; }
    protected getUpdatePermission() { return SettingsRow.updatePermission; }

    protected form = new SettingsForm(this.idPrefix);

}