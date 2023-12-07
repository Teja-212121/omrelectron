import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { KeyGenAsColumns, KeyGenAsRow, KeyGenAsService } from '../../ServerTypes/Workspace';
import { KeyGenAsDialog } from './KeyGenAsDialog';

@Decorators.registerClass()
export class KeyGenAsGrid extends EntityGrid<KeyGenAsRow, any> {
    protected getColumnsKey() { return KeyGenAsColumns.columnsKey; }
    protected getDialogType() { return KeyGenAsDialog; }
    protected getIdProperty() { return KeyGenAsRow.idProperty; }
    protected getInsertPermission() { return KeyGenAsRow.insertPermission; }
    protected getLocalTextPrefix() { return KeyGenAsRow.localTextPrefix; }
    protected getService() { return KeyGenAsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}