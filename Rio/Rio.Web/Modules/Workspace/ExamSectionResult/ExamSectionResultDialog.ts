import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamSectionResultForm, ExamSectionResultRow, ExamSectionResultService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamSectionResultDialog extends EntityDialog<ExamSectionResultRow, any> {
    protected getFormKey() { return ExamSectionResultForm.formKey; }
    protected getIdProperty() { return ExamSectionResultRow.idProperty; }
    protected getLocalTextPrefix() { return ExamSectionResultRow.localTextPrefix; }
    protected getNameProperty() { return ExamSectionResultRow.nameProperty; }
    protected getService() { return ExamSectionResultService.baseUrl; }
    protected getDeletePermission() { return ExamSectionResultRow.deletePermission; }
    protected getInsertPermission() { return ExamSectionResultRow.insertPermission; }
    protected getUpdatePermission() { return ExamSectionResultRow.updatePermission; }

    protected form = new ExamSectionResultForm(this.idPrefix);

}