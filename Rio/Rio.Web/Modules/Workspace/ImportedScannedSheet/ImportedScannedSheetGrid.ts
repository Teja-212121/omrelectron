import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ImportedScannedSheetColumns, ImportedScannedSheetRow, ImportedScannedSheetService } from '../../ServerTypes/Workspace';
import { ImportedScannedSheetDialog } from './ImportedScannedSheetDialog';

@Decorators.registerClass()
export class ImportedScannedSheetGrid extends EntityGrid<ImportedScannedSheetRow, any> {
    protected getColumnsKey() { return ImportedScannedSheetColumns.columnsKey; }
    protected getDialogType() { return ImportedScannedSheetDialog; }
    protected getIdProperty() { return ImportedScannedSheetRow.idProperty; }
    protected getInsertPermission() { return ImportedScannedSheetRow.insertPermission; }
    protected getLocalTextPrefix() { return ImportedScannedSheetRow.localTextPrefix; }
    protected getService() { return ImportedScannedSheetService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}