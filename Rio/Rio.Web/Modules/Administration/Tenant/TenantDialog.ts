﻿import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TenantForm, TenantRow, TenantService } from '../../ServerTypes/Administration';

@Decorators.registerClass()
export class TenantDialog extends EntityDialog<TenantRow, any> {
    protected getFormKey() { return TenantForm.formKey; }
    protected getIdProperty() { return TenantRow.idProperty; }
    protected getLocalTextPrefix() { return TenantRow.localTextPrefix; }
    protected getNameProperty() { return TenantRow.nameProperty; }
    protected getService() { return TenantService.baseUrl; }
    protected getDeletePermission() { return TenantRow.deletePermission; }
    protected getInsertPermission() { return TenantRow.insertPermission; }
    protected getUpdatePermission() { return TenantRow.updatePermission; }

    protected form = new TenantForm(this.idPrefix);

}