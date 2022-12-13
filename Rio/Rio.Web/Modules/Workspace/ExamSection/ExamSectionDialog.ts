import { Decorators, EntityDialog, EditorUtils } from '@serenity-is/corelib';
import { ExamSectionForm, ExamSectionRow, ExamSectionService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamSectionDialog extends EntityDialog<ExamSectionRow, any> {
    protected getFormKey() { return ExamSectionForm.formKey; }
    protected getIdProperty() { return ExamSectionRow.idProperty; }
    protected getLocalTextPrefix() { return ExamSectionRow.localTextPrefix; }
    protected getNameProperty() { return ExamSectionRow.nameProperty; }
    protected getService() { return ExamSectionService.baseUrl; }
    protected getDeletePermission() { return ExamSectionRow.deletePermission; }
    protected getInsertPermission() { return ExamSectionRow.insertPermission; }
    protected getUpdatePermission() { return ExamSectionRow.updatePermission; }

    protected form = new ExamSectionForm(this.idPrefix);

    updateInterface() {
        super.updateInterface();

        EditorUtils.setReadOnly(this.form.ExamId, true);
    }

}