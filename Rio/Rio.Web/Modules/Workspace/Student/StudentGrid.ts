import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { StudentColumns, StudentRow, StudentService } from '../../ServerTypes/Workspace';
import { StudentDialog } from './StudentDialog';

@Decorators.registerClass()
export class StudentGrid extends EntityGrid<StudentRow, any> {
    protected getColumnsKey() { return StudentColumns.columnsKey; }
    protected getDialogType() { return StudentDialog; }
    protected getIdProperty() { return StudentRow.idProperty; }
    protected getInsertPermission() { return StudentRow.insertPermission; }
    protected getLocalTextPrefix() { return StudentRow.localTextPrefix; }
    protected getService() { return StudentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}