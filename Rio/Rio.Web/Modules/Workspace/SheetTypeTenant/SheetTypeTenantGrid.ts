import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { Authorization } from '@serenity-is/corelib/q';
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

    private rowSelection: GridRowSelectionMixin;

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns() {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));

        if (!Authorization.hasPermission("Administration:Security")) {
            columns = columns.filter(f => f.field != SheetTypeTenantRow.Fields.TenantId);
        }

        return columns;
    }
    protected createToolbarExtensions() {
        super.createToolbarExtensions();
        this.rowSelection = new GridRowSelectionMixin(this);
    }
    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(1, 3);

        buttons.push({
            title: 'Delete Sheets', cssClass: 'delete-button',
            onClick: () => {

                var rowKeys = this.rowSelection.getSelectedKeys();
                if (rowKeys.length == 0) {
                    Q.alert("Please select record(s)");
                    return;
                }
                else {
                    Q.confirm('Are you sure you want to Delete?', () => {

                        Q.serviceRequest('/Services/Workspace/SheetTypeTenant/DeleteSheetTypeTenant', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
                    });

                }
            }
        });

        return buttons;
    }
}
