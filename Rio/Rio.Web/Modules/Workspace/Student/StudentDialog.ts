import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { StudentForm, StudentRow, StudentService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class StudentDialog extends EntityDialog<StudentRow, any> {
    protected getFormKey() { return StudentForm.formKey; }
    protected getIdProperty() { return StudentRow.idProperty; }
    protected getLocalTextPrefix() { return StudentRow.localTextPrefix; }
    protected getNameProperty() { return StudentRow.nameProperty; }
    protected getService() { return StudentService.baseUrl; }
    protected getDeletePermission() { return StudentRow.deletePermission; }
    protected getInsertPermission() { return StudentRow.insertPermission; }
    protected getUpdatePermission() { return StudentRow.updatePermission; }

    protected form = new StudentForm(this.idPrefix);

}