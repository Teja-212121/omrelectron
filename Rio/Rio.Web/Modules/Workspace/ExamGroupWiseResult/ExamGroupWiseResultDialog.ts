import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamGroupWiseResultForm, ExamGroupWiseResultRow, ExamGroupWiseResultService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamGroupWiseResultDialog extends EntityDialog<ExamGroupWiseResultRow, any> {
    protected getFormKey() { return ExamGroupWiseResultForm.formKey; }
    protected getIdProperty() { return ExamGroupWiseResultRow.idProperty; }
    protected getLocalTextPrefix() { return ExamGroupWiseResultRow.localTextPrefix; }
    protected getNameProperty() { return ExamGroupWiseResultRow.nameProperty; }
    protected getService() { return ExamGroupWiseResultService.baseUrl; }
    protected getDeletePermission() { return ExamGroupWiseResultRow.deletePermission; }
    protected getInsertPermission() { return ExamGroupWiseResultRow.insertPermission; }
    protected getUpdatePermission() { return ExamGroupWiseResultRow.updatePermission; }

    protected form = new ExamGroupWiseResultForm(this.idPrefix);

}