import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { SheetTypeTenantForm, SheetTypeTenantRow, SheetTypeTenantService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class SheetTypeTenantDialog extends EntityDialog<SheetTypeTenantRow, any> {
    protected getFormKey() { return SheetTypeTenantForm.formKey; }
    protected getIdProperty() { return SheetTypeTenantRow.idProperty; }
    protected getLocalTextPrefix() { return SheetTypeTenantRow.localTextPrefix; }
    protected getNameProperty() { return SheetTypeTenantRow.nameProperty; }
    protected getService() { return SheetTypeTenantService.baseUrl; }
    protected getDeletePermission() { return SheetTypeTenantRow.deletePermission; }
    protected getInsertPermission() { return SheetTypeTenantRow.insertPermission; }
    protected getUpdatePermission() { return SheetTypeTenantRow.updatePermission; }

    protected form = new SheetTypeTenantForm(this.idPrefix);

}