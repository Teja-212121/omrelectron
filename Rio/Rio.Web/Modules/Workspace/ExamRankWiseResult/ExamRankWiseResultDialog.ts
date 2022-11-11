import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamRankWiseResultForm, ExamRankWiseResultRow, ExamRankWiseResultService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamRankWiseResultDialog extends EntityDialog<ExamRankWiseResultRow, any> {
    protected getFormKey() { return ExamRankWiseResultForm.formKey; }
    protected getIdProperty() { return ExamRankWiseResultRow.idProperty; }
    protected getLocalTextPrefix() { return ExamRankWiseResultRow.localTextPrefix; }
    protected getNameProperty() { return ExamRankWiseResultRow.nameProperty; }
    protected getService() { return ExamRankWiseResultService.baseUrl; }
    protected getDeletePermission() { return ExamRankWiseResultRow.deletePermission; }
    protected getInsertPermission() { return ExamRankWiseResultRow.insertPermission; }
    protected getUpdatePermission() { return ExamRankWiseResultRow.updatePermission; }

    protected form = new ExamRankWiseResultForm(this.idPrefix);

}