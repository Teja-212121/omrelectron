import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SheetTypeColumns, SheetTypeRow, SheetTypeService } from '../../ServerTypes/Workspace';
import { SheetTypeDialog } from './SheetTypeDialog';

@Decorators.registerClass()
export class SheetTypeGrid extends EntityGrid<SheetTypeRow, any> {
    protected getColumnsKey() { return SheetTypeColumns.columnsKey; }
    protected getDialogType() { return SheetTypeDialog; }
    protected getIdProperty() { return SheetTypeRow.idProperty; }
    protected getInsertPermission() { return SheetTypeRow.insertPermission; }
    protected getLocalTextPrefix() { return SheetTypeRow.localTextPrefix; }
    protected getService() { return SheetTypeService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}