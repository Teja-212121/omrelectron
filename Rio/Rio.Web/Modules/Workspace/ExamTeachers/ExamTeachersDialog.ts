import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamTeachersForm, ExamTeachersRow, ExamTeachersService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamTeachersDialog extends EntityDialog<ExamTeachersRow, any> {
    protected getFormKey() { return ExamTeachersForm.formKey; }
    protected getIdProperty() { return ExamTeachersRow.idProperty; }
    protected getLocalTextPrefix() { return ExamTeachersRow.localTextPrefix; }
    protected getService() { return ExamTeachersService.baseUrl; }
    protected getDeletePermission() { return ExamTeachersRow.deletePermission; }
    protected getInsertPermission() { return ExamTeachersRow.insertPermission; }
    protected getUpdatePermission() { return ExamTeachersRow.updatePermission; }

    protected form = new ExamTeachersForm(this.idPrefix);

}