import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { Authorization } from '@serenity-is/corelib/q';
import { SheetTypeColumns, SheetTypeRow, SheetTypeService } from '../../ServerTypes/Workspace';
import { AssignSheetTypesDialog } from '../SheetTypeTenant/AssignSheetTypesDialog';
import { SheetTypeDialog } from './SheetTypeDialog';

@Decorators.registerClass()
export class SheetTypeGrid extends EntityGrid<SheetTypeRow, any> {
    protected getColumnsKey() { return SheetTypeColumns.columnsKey; }
    protected getDialogType() { return SheetTypeDialog; }
    protected getIdProperty() { return SheetTypeRow.idProperty; }
    protected getInsertPermission() { return SheetTypeRow.insertPermission; }
    protected getLocalTextPrefix() { return SheetTypeRow.localTextPrefix; }
    protected getService() { return SheetTypeService.baseUrl; }

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
        buttons.splice(0, 2);

        /*if (Authorization.hasPermission("Administration:Tenant")) {
            buttons.push(
                {
                    title: 'Assign Sheets for Use',
                    cssClass: 'send-button',
                    onClick: () => {
                        //debugger;
                        var SelectedKeys = this.rowSelection.getSelectedKeys();
                        if (SelectedKeys.length > 4) {
                            Q.alert("Maximum 4 SheetTypes are allowed!!!");
                            return;
                        }

                        if (!this.onViewSubmit()) {
                            return;
                        }

                        Q.serviceRequest('/Services/Workspace/SelectSheetType/UpdateSheetTypeTenants', this.rowSelection.getSelectedKeys(), (response) => { this.refresh(), this.rowSelection.resetCheckedAndRefresh() });
                    }
                });
        }*/
        if (Authorization.hasPermission("Administration:Security")) {
            buttons.push({
                title: 'Assign to Tenant',
                cssClass: 'send-button',
                onClick: () => {
                    var rowKeys = this.rowSelection.getSelectedKeys();
                    if (rowKeys.length == 0) {
                        Q.alert("Select Sheet To Assign");
                        return;
                    }
                    if (rowKeys.length > 4) {
                        Q.alert("Maximum 4 SheetTypes are allowed!!!");
                        return;
                    }
                    else {
                        new AssignSheetTypesDialog(this, true, rowKeys).loadNewAndOpenDialog();
                    }
                }
            });
        }
        else {
            buttons.push(
                {
                    title: 'Assign Sheets for Use',
                    cssClass: 'send-button',
                    onClick: () => {
                        //debugger;
                        var SelectedKeys = this.rowSelection.getSelectedKeys();
                        if (SelectedKeys.length > 4) {
                            Q.alert("Maximum 4 SheetTypes are allowed!!!");
                            return;
                        }

                        if (!this.onViewSubmit()) {
                            return;
                        }

                        Q.serviceRequest('/Services/Workspace/SelectSheetType/UpdateSheetTypeTenants', this.rowSelection.getSelectedKeys(), (response) => { this.refresh(), this.rowSelection.resetCheckedAndRefresh() });
                    }
                });
        }
        return buttons;
    }
}