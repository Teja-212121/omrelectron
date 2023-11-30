import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamListForm, ExamListRow, ExamListService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamListDialog extends EntityDialog<ExamListRow, any> {
    protected getFormKey() { return ExamListForm.formKey; }
    protected getIdProperty() { return ExamListRow.idProperty; }
    protected getLocalTextPrefix() { return ExamListRow.localTextPrefix; }
    protected getNameProperty() { return ExamListRow.nameProperty; }
    protected getService() { return ExamListService.baseUrl; }
    protected getDeletePermission() { return ExamListRow.deletePermission; }
    protected getInsertPermission() { return ExamListRow.insertPermission; }
    protected getUpdatePermission() { return ExamListRow.updatePermission; }

    protected form = new ExamListForm(this.idPrefix);

}