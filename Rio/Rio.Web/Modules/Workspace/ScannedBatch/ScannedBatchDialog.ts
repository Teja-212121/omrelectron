import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ScannedBatchForm, ScannedBatchRow, ScannedBatchService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ScannedBatchDialog extends EntityDialog<ScannedBatchRow, any> {
    protected getFormKey() { return ScannedBatchForm.formKey; }
    protected getIdProperty() { return ScannedBatchRow.idProperty; }
    protected getLocalTextPrefix() { return ScannedBatchRow.localTextPrefix; }
    protected getNameProperty() { return ScannedBatchRow.nameProperty; }
    protected getService() { return ScannedBatchService.baseUrl; }
    protected getDeletePermission() { return ScannedBatchRow.deletePermission; }
    protected getInsertPermission() { return ScannedBatchRow.insertPermission; }
    protected getUpdatePermission() { return ScannedBatchRow.updatePermission; }

    protected form = new ScannedBatchForm(this.idPrefix);

}