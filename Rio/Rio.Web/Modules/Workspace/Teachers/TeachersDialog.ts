import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TeachersForm, TeachersRow, TeachersService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class TeachersDialog extends EntityDialog<TeachersRow, any> {
    protected getFormKey() { return TeachersForm.formKey; }
    protected getIdProperty() { return TeachersRow.idProperty; }
    protected getLocalTextPrefix() { return TeachersRow.localTextPrefix; }
    protected getNameProperty() { return TeachersRow.nameProperty; }
    protected getService() { return TeachersService.baseUrl; }
    protected getDeletePermission() { return TeachersRow.deletePermission; }
    protected getInsertPermission() { return TeachersRow.insertPermission; }
    protected getUpdatePermission() { return TeachersRow.updatePermission; }

    protected form = new TeachersForm(this.idPrefix);

}