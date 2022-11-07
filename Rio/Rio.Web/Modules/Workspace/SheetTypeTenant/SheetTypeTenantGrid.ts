import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SheetTypeTenantColumns, SheetTypeTenantRow, SheetTypeTenantService } from '../../ServerTypes/Workspace';
import { SheetTypeTenantDialog } from './SheetTypeTenantDialog';

@Decorators.registerClass()
export class SheetTypeTenantGrid extends EntityGrid<SheetTypeTenantRow, any> {
    protected getColumnsKey() { return SheetTypeTenantColumns.columnsKey; }
    protected getDialogType() { return SheetTypeTenantDialog; }
    protected getIdProperty() { return SheetTypeTenantRow.idProperty; }
    protected getInsertPermission() { return SheetTypeTenantRow.insertPermission; }
    protected getLocalTextPrefix() { return SheetTypeTenantRow.localTextPrefix; }
    protected getService() { return SheetTypeTenantService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}