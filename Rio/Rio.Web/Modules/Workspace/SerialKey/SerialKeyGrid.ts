import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SerialKeyColumns, SerialKeyRow, SerialKeyService } from '../../ServerTypes/Workspace';
import { SerialKeyDialog } from './SerialKeyDialog';

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
}