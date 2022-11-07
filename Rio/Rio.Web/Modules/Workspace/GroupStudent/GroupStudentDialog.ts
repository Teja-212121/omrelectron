import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GroupStudentForm, GroupStudentRow, GroupStudentService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class GroupStudentDialog extends EntityDialog<GroupStudentRow, any> {
    protected getFormKey() { return GroupStudentForm.formKey; }
    protected getIdProperty() { return GroupStudentRow.idProperty; }
    protected getLocalTextPrefix() { return GroupStudentRow.localTextPrefix; }
    protected getService() { return GroupStudentService.baseUrl; }
    protected getDeletePermission() { return GroupStudentRow.deletePermission; }
    protected getInsertPermission() { return GroupStudentRow.insertPermission; }
    protected getUpdatePermission() { return GroupStudentRow.updatePermission; }

    protected form = new GroupStudentForm(this.idPrefix);

}