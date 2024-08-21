import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CloudStorageSettingColumns, CloudStorageSettingRow, CloudStorageSettingService } from '../../ServerTypes/Workspace';
import { CloudStorageSettingDialog } from './CloudStorageSettingDialog';

@Decorators.registerClass()
export class CloudStorageSettingGrid extends EntityGrid<CloudStorageSettingRow, any> {
    protected getColumnsKey() { return CloudStorageSettingColumns.columnsKey; }
    protected getDialogType() { return CloudStorageSettingDialog; }
    protected getIdProperty() { return CloudStorageSettingRow.idProperty; }
    protected getInsertPermission() { return CloudStorageSettingRow.insertPermission; }
    protected getLocalTextPrefix() { return CloudStorageSettingRow.localTextPrefix; }
    protected getService() { return CloudStorageSettingService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}