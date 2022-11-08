import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ScannedSheetColumns, ScannedSheetRow, ScannedSheetService } from '../../ServerTypes/Workspace';
import { ScannedSheetDialog } from './ScannedSheetDialog';

@Decorators.registerClass()
export class ScannedSheetGrid extends EntityGrid<ScannedSheetRow, any> {
    protected getColumnsKey() { return ScannedSheetColumns.columnsKey; }
    protected getDialogType() { return ScannedSheetDialog; }
    protected getIdProperty() { return ScannedSheetRow.idProperty; }
    protected getInsertPermission() { return ScannedSheetRow.insertPermission; }
    protected getLocalTextPrefix() { return ScannedSheetRow.localTextPrefix; }
    protected getService() { return ScannedSheetService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}