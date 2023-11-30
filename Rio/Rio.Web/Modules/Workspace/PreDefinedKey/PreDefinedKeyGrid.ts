import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PreDefinedKeyColumns, PreDefinedKeyRow, PreDefinedKeyService } from '../../ServerTypes/Workspace';
import { PreDefinedKeyDialog } from './PreDefinedKeyDialog';

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
}