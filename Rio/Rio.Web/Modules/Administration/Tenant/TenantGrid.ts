import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TenantColumns, TenantRow, TenantService } from '../../ServerTypes/Administration';
import { TenantDialog } from './TenantDialog';

@Decorators.registerClass()
export class TenantGrid extends EntityGrid<TenantRow, any> {
    protected getColumnsKey() { return TenantColumns.columnsKey; }
    protected getDialogType() { return TenantDialog; }
    protected getIdProperty() { return TenantRow.idProperty; }
    protected getInsertPermission() { return TenantRow.insertPermission; }
    protected getLocalTextPrefix() { return TenantRow.localTextPrefix; }
    protected getService() { return TenantService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}