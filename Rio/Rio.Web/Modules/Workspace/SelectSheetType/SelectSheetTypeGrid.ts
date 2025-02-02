import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { Authorization, serviceRequest } from '@serenity-is/corelib/q';
import { AssignSheetTypesForm, SelectSheetTypeColumns, SelectSheetTypeRow, SelectSheetTypeService } from '../../ServerTypes/Workspace';
import { AssignSheetTypesDialog } from '../SheetTypeTenant/AssignSheetTypesDialog';
import { SelectSheetTypeDialog } from './SelectSheetTypeDialog';

@Decorators.registerClass()
export class SelectSheetTypeGrid extends EntityGrid<SelectSheetTypeRow, any> {
    protected getColumnsKey() { return SelectSheetTypeColumns.columnsKey; }
    protected getDialogType() { return SelectSheetTypeDialog; }
    protected getIdProperty() { return SelectSheetTypeRow.idProperty; }
    protected getInsertPermission() { return SelectSheetTypeRow.insertPermission; }
    protected getLocalTextPrefix() { return SelectSheetTypeRow.localTextPrefix; }
    protected getService() { return SelectSheetTypeService.baseUrl; }

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

        buttons.push(
            {
                title: 'Assign Sheets for Use',
                cssClass: 'send-button',
                onClick: () => {
                    //debugger;
                    var SelectedKeys = this.rowSelection.getSelectedKeys();
                    if (SelectedKeys.length > 4) {
                        alert("Maximum 4 SheetTypes are allowed!!!");
                        return;
                    }

                    if (!this.onViewSubmit()) {
                        return;
                    }

                    serviceRequest('/Services/Workspace/SelectSheetType/UpdateSheetTypeTenants', this.rowSelection.getSelectedKeys(), (response) => { this.refresh(), this.rowSelection.resetCheckedAndRefresh() });
                }
            });
        if (Authorization.hasPermission("Administration:Security")) {
            buttons.push({
                title: 'Assign to Tenant',
                cssClass: 'send-button',
                onClick: () => {
                    var rowKeys = this.rowSelection.getSelectedKeys();
                    if (rowKeys.length == 0) {
                        alert("Select Sheet To Assign");
                        return;
                    }
                    if (rowKeys.length > 4) {
                        alert("Maximum 4 SheetTypes are allowed!!!");
                        return;
                    }
                    else {
                        new AssignSheetTypesDialog(this, true, rowKeys).loadNewAndOpenDialog();
                    }
                }
            });
        }
        return buttons;
    }
}