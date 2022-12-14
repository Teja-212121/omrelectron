import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { serviceRequest } from '@serenity-is/corelib/q';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { GroupColumns, GroupRow, GroupService } from '../../ServerTypes/Workspace';
import { GroupDialog } from './GroupDialog';

@Decorators.registerClass()
export class GroupGrid extends EntityGrid<GroupRow, any> {
    protected getColumnsKey() { return GroupColumns.columnsKey; }
    protected getDialogType() { return GroupDialog; }
    protected getIdProperty() { return GroupRow.idProperty; }
    protected getInsertPermission() { return GroupRow.insertPermission; }
    protected getLocalTextPrefix() { return GroupRow.localTextPrefix; }
    protected getService() { return GroupService.baseUrl; }

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
        buttons.splice(1, 3);

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            title: 'Export',
            service: GroupService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        buttons.push({
            title: 'Delete Groups', cssClass: 'delete-button',
            onClick: () => {

                var rowKeys = this.rowSelection.getSelectedKeys();
                if (rowKeys.length == 0) {
                    alert("Please select record(s)");
                    return;
                }
                else {
                    Q.confirm('Are you sure you want to Delete?', () => {

                        serviceRequest('/Services/Workspace/Group/DeleteGroup', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
                    });

                }
            },
            separator: true
        });

        return buttons;
    }
}