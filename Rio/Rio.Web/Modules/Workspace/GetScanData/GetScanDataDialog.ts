import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GetScanDataForm, GetScanDataRow, GetScanDataService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class GetScanDataDialog extends EntityDialog<GetScanDataRow, any> {
    protected getFormKey() { return GetScanDataForm.formKey; }
    protected getIdProperty() { return GetScanDataRow.idProperty; }
    protected getLocalTextPrefix() { return GetScanDataRow.localTextPrefix; }
    protected getNameProperty() { return GetScanDataRow.nameProperty; }
    protected getService() { return GetScanDataService.baseUrl; }
    protected getDeletePermission() { return GetScanDataRow.deletePermission; }
    protected getInsertPermission() { return GetScanDataRow.insertPermission; }
    protected getUpdatePermission() { return GetScanDataRow.updatePermission; }

    protected form = new GetScanDataForm(this.idPrefix);

}