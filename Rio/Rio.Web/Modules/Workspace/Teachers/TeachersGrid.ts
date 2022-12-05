import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TeachersColumns, TeachersRow, TeachersService } from '../../ServerTypes/Workspace';
import { TeachersDialog } from './TeachersDialog';

@Decorators.registerClass()
export class TeachersGrid extends EntityGrid<TeachersRow, any> {
    protected getColumnsKey() { return TeachersColumns.columnsKey; }
    protected getDialogType() { return TeachersDialog; }
    protected getIdProperty() { return TeachersRow.idProperty; }
    protected getInsertPermission() { return TeachersRow.insertPermission; }
    protected getLocalTextPrefix() { return TeachersRow.localTextPrefix; }
    protected getService() { return TeachersService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}