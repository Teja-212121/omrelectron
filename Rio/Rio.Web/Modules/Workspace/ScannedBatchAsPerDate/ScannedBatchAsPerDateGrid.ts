import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ScannedBatchAsPerDateColumns, ScannedBatchAsPerDateRow, ScannedBatchAsPerDateService } from '../../ServerTypes/Workspace';
import { ScannedBatchAsPerDateDialog } from './ScannedBatchAsPerDateDialog';

@Decorators.registerClass()
export class ScannedBatchAsPerDateGrid extends EntityGrid<ScannedBatchAsPerDateRow, any> {
    protected getColumnsKey() { return ScannedBatchAsPerDateColumns.columnsKey; }
    protected getDialogType() { return ScannedBatchAsPerDateDialog; }
    protected getIdProperty() { return ScannedBatchAsPerDateRow.idProperty; }
    protected getInsertPermission() { return ScannedBatchAsPerDateRow.insertPermission; }
    protected getLocalTextPrefix() { return ScannedBatchAsPerDateRow.localTextPrefix; }
    protected getService() { return ScannedBatchAsPerDateService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}