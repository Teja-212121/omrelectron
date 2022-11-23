import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ImportedScannedBatchColumns, ImportedScannedBatchRow } from '../../ServerTypes/Workspace';
import { ImportedScannedBatchService } from '../../ServerTypes/Workspace/ImportedScannedBatchService';
import { ImportedScannedBatchDialog } from './ImportedScannedBatchDialog';
import { ScannedDataExcelImportDialog } from './ScannedDataExcelImportDialog';

@Decorators.registerClass()
export class ImportedScannedBatchGrid extends EntityGrid<ImportedScannedBatchRow, any> {
    protected getColumnsKey() { return ImportedScannedBatchColumns.columnsKey; }
    protected getDialogType() { return ImportedScannedBatchDialog; }
    protected getIdProperty() { return ImportedScannedBatchRow.idProperty; }
    protected getInsertPermission() { return ImportedScannedBatchRow.insertPermission; }
    protected getLocalTextPrefix() { return ImportedScannedBatchRow.localTextPrefix; }
    protected getService() { return ImportedScannedBatchService.baseUrl; }

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
        buttons.splice(0, 1);

        buttons.push({
            title: 'Import From Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                // open import dialog, let it handle rest
                var dialog = new ScannedDataExcelImportDialog();
                    dialog.element.on('dialogclose', () => {
                        this.refresh();
                        dialog = null;
                    });
                dialog.dialogOpen();
            },
            separator: true
        });

        buttons.push({
            title: 'Download  Sample',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                var url = "~/Workspace/ImportedScannedBatch/ImportedScannedBatchSample";

                Q.postToService({ url: Q.resolveUrl(url), request: '', target: '_blank' });
            },
            separator: true
        });

        return buttons;
    }
}