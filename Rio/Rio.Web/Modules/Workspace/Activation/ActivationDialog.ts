import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ActivationForm, ActivationRow, ActivationService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ActivationDialog extends EntityDialog<ActivationRow, any> {
    protected getFormKey() { return ActivationForm.formKey; }
    protected getIdProperty() { return ActivationRow.idProperty; }
    protected getLocalTextPrefix() { return ActivationRow.localTextPrefix; }
    protected getNameProperty() { return ActivationRow.nameProperty; }
    protected getService() { return ActivationService.baseUrl; }
    protected getDeletePermission() { return ActivationRow.deletePermission; }
    protected getInsertPermission() { return ActivationRow.insertPermission; }
    protected getUpdatePermission() { return ActivationRow.updatePermission; }

    protected form = new ActivationForm(this.idPrefix);

}