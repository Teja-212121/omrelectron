import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CloudStorageProviderColumns, CloudStorageProviderRow, CloudStorageProviderService } from '../../ServerTypes/Workspace';
import { CloudStorageProviderDialog } from './CloudStorageProviderDialog';

@Decorators.registerClass()
export class CloudStorageProviderGrid extends EntityGrid<CloudStorageProviderRow, any> {
    protected getColumnsKey() { return CloudStorageProviderColumns.columnsKey; }
    protected getDialogType() { return CloudStorageProviderDialog; }
    protected getIdProperty() { return CloudStorageProviderRow.idProperty; }
    protected getInsertPermission() { return CloudStorageProviderRow.insertPermission; }
    protected getLocalTextPrefix() { return CloudStorageProviderRow.localTextPrefix; }
    protected getService() { return CloudStorageProviderService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}