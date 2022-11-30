import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { ScannedBatchColumns, ScannedBatchRow, ScannedBatchService } from '../../ServerTypes/Workspace';
import { ScannedBatchDialog } from './ScannedBatchDialog';

@Decorators.registerClass()
export class ScannedBatchGrid extends EntityGrid<ScannedBatchRow, any> {
    protected getColumnsKey() { return ScannedBatchColumns.columnsKey; }
    protected getDialogType() { return ScannedBatchDialog; }
    protected getIdProperty() { return ScannedBatchRow.idProperty; }
    protected getInsertPermission() { return ScannedBatchRow.insertPermission; }
    protected getLocalTextPrefix() { return ScannedBatchRow.localTextPrefix; }
    protected getService() { return ScannedBatchService.baseUrl; }

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
            service: ScannedBatchService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        return buttons;
    }
}