import { Decorators, EntityGrid } from '@serenity-is/corelib';
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

    constructor(container: JQuery) {
        super(container);
    }
}