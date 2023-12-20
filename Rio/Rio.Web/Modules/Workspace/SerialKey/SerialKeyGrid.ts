import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SerialKeyColumns, SerialKeyRow, SerialKeyService } from '../../ServerTypes/Workspace';
import { SerialKeyDialog } from './SerialKeyDialog';
import { GenerateSerialKeyDialog } from './GenerateSerialKeyDialog';
import { KeyGenAsDialog } from '../KeyGenAs/KeyGenAsDialog';
import { trimToNull } from '@serenity-is/corelib/q';
import { KeyStatus } from '../../ServerTypes/Web';

@Decorators.registerClass()
export class SerialKeyGrid extends EntityGrid<SerialKeyRow, any> {
    protected getColumnsKey() { return SerialKeyColumns.columnsKey; }
    protected getDialogType() { return SerialKeyDialog; }
    protected getIdProperty() { return SerialKeyRow.idProperty; }
    protected getInsertPermission() { return SerialKeyRow.insertPermission; }
    protected getLocalTextPrefix() { return SerialKeyRow.localTextPrefix; }
    protected getService() { return SerialKeyService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons() {
        const buttons = super.getButtons();
        buttons.splice(0, 3);

        buttons.push({
            title: 'Generate SerialKey',
            separator: true,
            cssClass: 'edit-button',
            onClick: () => {
                var dialog = new KeyGenAsDialog(this);
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.dialogOpen();
            }
        });
        return buttons;
    }

    protected getItemCssClass(item: SerialKeyRow ,index: number): string {
        let klass: string = "";

        if (item.EStatus == KeyStatus.Created)
            klass += " created";
        else if (item.EStatus == KeyStatus.Open)
            klass += " open";
        else if (item.EStatus == KeyStatus.Activated)
            klass += " activated";
        else if (item.EStatus == KeyStatus.Disabled)
            klass += " disabled";
        else if (item.EStatus == KeyStatus.Expired)
            klass += " expired";
        else if (item.EStatus == KeyStatus.OfflineActivated)
            klass += " offlineactivated";
        return trimToNull(klass);
    }

}