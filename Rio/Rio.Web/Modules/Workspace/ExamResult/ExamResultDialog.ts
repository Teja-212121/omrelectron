import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamResultForm, ExamResultRow, ExamResultService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamResultDialog extends EntityDialog<ExamResultRow, any> {
    protected getFormKey() { return ExamResultForm.formKey; }
    protected getIdProperty() { return ExamResultRow.idProperty; }
    protected getLocalTextPrefix() { return ExamResultRow.localTextPrefix; }
    protected getNameProperty() { return ExamResultRow.nameProperty; }
    protected getService() { return ExamResultService.baseUrl; }
    protected getDeletePermission() { return ExamResultRow.deletePermission; }
    protected getInsertPermission() { return ExamResultRow.insertPermission; }
    protected getUpdatePermission() { return ExamResultRow.updatePermission; }

    protected form = new ExamResultForm(this.idPrefix);

}