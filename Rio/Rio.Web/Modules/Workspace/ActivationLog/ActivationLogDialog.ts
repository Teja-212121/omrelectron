import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ActivationLogForm, ActivationLogRow, ActivationLogService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ActivationLogDialog extends EntityDialog<ActivationLogRow, any> {
    protected getFormKey() { return ActivationLogForm.formKey; }
    protected getIdProperty() { return ActivationLogRow.idProperty; }
    protected getLocalTextPrefix() { return ActivationLogRow.localTextPrefix; }
    protected getNameProperty() { return ActivationLogRow.nameProperty; }
    protected getService() { return ActivationLogService.baseUrl; }
    protected getDeletePermission() { return ActivationLogRow.deletePermission; }
    protected getInsertPermission() { return ActivationLogRow.insertPermission; }
    protected getUpdatePermission() { return ActivationLogRow.updatePermission; }

    protected form = new ActivationLogForm(this.idPrefix);

}