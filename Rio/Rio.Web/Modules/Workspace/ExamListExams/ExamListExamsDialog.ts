import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';
import { ExamListExamsForm, ExamListExamsRow, ExamListExamsService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamListExamsDialog extends EntityDialog<ExamListExamsRow, any> {
    protected getFormKey() { return ExamListExamsForm.formKey; }
    protected getIdProperty() { return ExamListExamsRow.idProperty; }
    protected getLocalTextPrefix() { return ExamListExamsRow.localTextPrefix; }
    protected getService() { return ExamListExamsService.baseUrl; }
    protected getDeletePermission() { return ExamListExamsRow.deletePermission; }
    protected getInsertPermission() { return ExamListExamsRow.insertPermission; }
    protected getUpdatePermission() { return ExamListExamsRow.updatePermission; }

    protected form = new ExamListExamsForm(this.idPrefix);

    updateInterface() {
        super.updateInterface();

        EditorUtils.setReadOnly(this.form.ExamListId, true);
    }
}