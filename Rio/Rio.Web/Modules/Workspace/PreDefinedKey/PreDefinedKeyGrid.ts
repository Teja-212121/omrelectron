import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { postToService, resolveUrl } from '@serenity-is/corelib/q';
import { PreDefinedKeyColumns, PreDefinedKeyRow, PreDefinedKeyService } from '../../ServerTypes/Workspace';
import { PreDefinedKeyDialog } from './PreDefinedKeyDialog';
import { PredfinedSerialKeyExcelImportDialog } from './PredfinedSerialKeyExcelImportDialog';

@Decorators.registerClass()
export class PreDefinedKeyGrid extends EntityGrid<PreDefinedKeyRow, any> {
    protected getColumnsKey() { return PreDefinedKeyColumns.columnsKey; }
    protected getDialogType() { return PreDefinedKeyDialog; }
    protected getIdProperty() { return PreDefinedKeyRow.idProperty; }
    protected getInsertPermission() { return PreDefinedKeyRow.insertPermission; }
    protected getLocalTextPrefix() { return PreDefinedKeyRow.localTextPrefix; }
    protected getService() { return PreDefinedKeyService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(1, 3);

        buttons.push({
            title: 'Import From Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                // open import dialog, let it handle rest
                var dialog = new PredfinedSerialKeyExcelImportDialog();
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
                var url = "~/Workspace/PreDefinedKey/PreDefinedKeySample";

                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            },
            separator: true
        });
        return buttons;
    }
}