import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ImportedScannedBatchColumns, ImportedScannedBatchRow, ImportedScannedBatchService } from '../../ServerTypes/Workspace';
import { ImportedScannedBatchDialog } from './ImportedScannedBatchDialog';

@Decorators.registerClass()
export class ImportedScannedBatchGrid extends EntityGrid<ImportedScannedBatchRow, any> {
    protected getColumnsKey() { return ImportedScannedBatchColumns.columnsKey; }
    protected getDialogType() { return ImportedScannedBatchDialog; }
    protected getIdProperty() { return ImportedScannedBatchRow.idProperty; }
    protected getInsertPermission() { return ImportedScannedBatchRow.insertPermission; }
    protected getLocalTextPrefix() { return ImportedScannedBatchRow.localTextPrefix; }
    protected getService() { return ImportedScannedBatchService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}