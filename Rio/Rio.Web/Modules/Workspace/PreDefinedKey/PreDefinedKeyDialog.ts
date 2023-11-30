import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PreDefinedKeyForm, PreDefinedKeyRow, PreDefinedKeyService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class PreDefinedKeyDialog extends EntityDialog<PreDefinedKeyRow, any> {
    protected getFormKey() { return PreDefinedKeyForm.formKey; }
    protected getIdProperty() { return PreDefinedKeyRow.idProperty; }
    protected getLocalTextPrefix() { return PreDefinedKeyRow.localTextPrefix; }
    protected getNameProperty() { return PreDefinedKeyRow.nameProperty; }
    protected getService() { return PreDefinedKeyService.baseUrl; }
    protected getDeletePermission() { return PreDefinedKeyRow.deletePermission; }
    protected getInsertPermission() { return PreDefinedKeyRow.insertPermission; }
    protected getUpdatePermission() { return PreDefinedKeyRow.updatePermission; }

    protected form = new PreDefinedKeyForm(this.idPrefix);

}