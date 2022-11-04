import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GroupForm, GroupRow, GroupService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class GroupDialog extends EntityDialog<GroupRow, any> {
    protected getFormKey() { return GroupForm.formKey; }
    protected getIdProperty() { return GroupRow.idProperty; }
    protected getLocalTextPrefix() { return GroupRow.localTextPrefix; }
    protected getNameProperty() { return GroupRow.nameProperty; }
    protected getService() { return GroupService.baseUrl; }
    protected getDeletePermission() { return GroupRow.deletePermission; }
    protected getInsertPermission() { return GroupRow.insertPermission; }
    protected getUpdatePermission() { return GroupRow.updatePermission; }

    protected form = new GroupForm(this.idPrefix);

}