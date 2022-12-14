import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { first, trimToNull } from '@serenity-is/corelib/q';
import { Column } from '@serenity-is/sleekgrid';
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

    protected getColumns(): Column[] {
        var columns = super.getColumns();


        // adding a specific css class to UnitPrice column, 
        // to be able to format cell with a different background
        first(columns, x => x.field == ImportedScannedSheetRow.Fields.ScannedStatus).cssClass += " col-scanned-status";

        return columns;
    }


    /**
     * This method is called for all rows
     * @param item Data item for current row
     * @param index Index of the row in grid
     */
    protected getItemCssClass(item: ImportedScannedSheetRow, index: number): string {
        let klass: string = "";

        if (item.ScannedStatus == 1)
            klass += " failed-sheet";
        else if (item.ScannedStatus == 2)
            klass += " warning-sheet";
        else
            klass += " success-sheet";

        return trimToNull(klass);
    }
}