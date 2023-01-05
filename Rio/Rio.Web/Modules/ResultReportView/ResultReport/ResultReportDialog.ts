import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ResultReportForm, ResultReportRow, ResultReportService } from '../../ServerTypes/ResultReportView';

@Decorators.registerClass()
export class ResultReportDialog extends EntityDialog<ResultReportRow, any> {
    protected getFormKey() { return ResultReportForm.formKey; }
    protected getIdProperty() { return ResultReportRow.idProperty; }
    protected getLocalTextPrefix() { return ResultReportRow.localTextPrefix; }
    protected getNameProperty() { return ResultReportRow.nameProperty; }
    protected getService() { return ResultReportService.baseUrl; }
    protected getDeletePermission() { return ResultReportRow.deletePermission; }
    protected getInsertPermission() { return ResultReportRow.insertPermission; }
    protected getUpdatePermission() { return ResultReportRow.updatePermission; }

    protected form = new ResultReportForm(this.idPrefix);

}