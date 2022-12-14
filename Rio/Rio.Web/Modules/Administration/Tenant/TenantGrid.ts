import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { Authorization, serviceRequest } from '@serenity-is/corelib/q';
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
    private rowSelection: GridRowSelectionMixin;
    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns() {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        return columns;
    }
    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }

    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(0, 3);

      
        if (Authorization.hasPermission("Administration:Security")) {
            buttons.push({
                title: 'Approve Tenant',
                cssClass: 'send-button',
                onClick: () => {
                    var rowKeys = this.rowSelection.getSelectedKeys();
                    if (rowKeys.length == 0) {
                        alert("Please select record(s)");
                        return;
                    }
                    else {
                        serviceRequest('/Services/Administration/Tenant/ApproveTenants', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
                    }
                }
            });
        }
        return buttons;
    }


}