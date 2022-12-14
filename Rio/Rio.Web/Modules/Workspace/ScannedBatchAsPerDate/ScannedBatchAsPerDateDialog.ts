import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ScannedBatchAsPerDateForm, ScannedBatchAsPerDateRow, ScannedBatchAsPerDateService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ScannedBatchAsPerDateDialog extends EntityDialog<ScannedBatchAsPerDateRow, any> {
    protected getFormKey() { return ScannedBatchAsPerDateForm.formKey; }
    protected getIdProperty() { return ScannedBatchAsPerDateRow.idProperty; }
    protected getLocalTextPrefix() { return ScannedBatchAsPerDateRow.localTextPrefix; }
    protected getNameProperty() { return ScannedBatchAsPerDateRow.nameProperty; }
    protected getService() { return ScannedBatchAsPerDateService.baseUrl; }
    protected getDeletePermission() { return ScannedBatchAsPerDateRow.deletePermission; }
    protected getInsertPermission() { return ScannedBatchAsPerDateRow.insertPermission; }
    protected getUpdatePermission() { return ScannedBatchAsPerDateRow.updatePermission; }

    protected form = new ScannedBatchAsPerDateForm(this.idPrefix);

}