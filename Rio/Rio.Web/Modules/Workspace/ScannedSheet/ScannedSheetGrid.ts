import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { ScannedSheetColumns, ScannedSheetRow, ScannedSheetService } from '../../ServerTypes/Workspace';
import { ScannedSheetDialog } from './ScannedSheetDialog';

@Decorators.registerClass()
export class ScannedSheetGrid extends EntityGrid<ScannedSheetRow, any> {
    protected getColumnsKey() { return ScannedSheetColumns.columnsKey; }
    protected getDialogType() { return ScannedSheetDialog; }
    protected getIdProperty() { return ScannedSheetRow.idProperty; }
    protected getInsertPermission() { return ScannedSheetRow.insertPermission; }
    protected getLocalTextPrefix() { return ScannedSheetRow.localTextPrefix; }
    protected getService() { return ScannedSheetService.baseUrl; }

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
        buttons.splice(1, 1);

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            title: 'Export',
            service: ScannedSheetService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        return buttons;
    }
}