import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { MailForm, MailRow, MailService } from '../../ServerTypes/Common';

@Decorators.registerClass()
export class MailDialog extends EntityDialog<MailRow, any> {
    protected getFormKey() { return MailForm.formKey; }
    protected getIdProperty() { return MailRow.idProperty; }
    protected getLocalTextPrefix() { return MailRow.localTextPrefix; }
    protected getNameProperty() { return MailRow.nameProperty; }
    protected getService() { return MailService.baseUrl; }
    protected getDeletePermission() { return MailRow.deletePermission; }
    protected getInsertPermission() { return MailRow.insertPermission; }
    protected getUpdatePermission() { return MailRow.updatePermission; }

    protected form = new MailForm(this.idPrefix);

}