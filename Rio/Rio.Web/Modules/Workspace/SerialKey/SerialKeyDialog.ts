import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { SerialKeyForm, SerialKeyRow, SerialKeyService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class SerialKeyDialog extends EntityDialog<SerialKeyRow, any> {
    protected getFormKey() { return SerialKeyForm.formKey; }
    protected getIdProperty() { return SerialKeyRow.idProperty; }
    protected getLocalTextPrefix() { return SerialKeyRow.localTextPrefix; }
    protected getNameProperty() { return SerialKeyRow.nameProperty; }
    protected getService() { return SerialKeyService.baseUrl; }
    protected getDeletePermission() { return SerialKeyRow.deletePermission; }
    protected getInsertPermission() { return SerialKeyRow.insertPermission; }
    protected getUpdatePermission() { return SerialKeyRow.updatePermission; }

    protected form = new SerialKeyForm(this.idPrefix);

}