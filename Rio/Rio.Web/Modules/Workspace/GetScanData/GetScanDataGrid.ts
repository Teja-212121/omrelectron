import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { GetScanDataColumns, GetScanDataRow, GetScanDataService } from '../../ServerTypes/Workspace';
import { GetScanDataDialog } from './GetScanDataDialog';

@Decorators.registerClass()
export class GetScanDataGrid extends EntityGrid<GetScanDataRow, any> {
    protected getColumnsKey() { return GetScanDataColumns.columnsKey; }
    protected getDialogType() { return GetScanDataDialog; }
    protected getIdProperty() { return GetScanDataRow.idProperty; }
    protected getInsertPermission() { return GetScanDataRow.insertPermission; }
    protected getLocalTextPrefix() { return GetScanDataRow.localTextPrefix; }
    protected getService() { return GetScanDataService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}