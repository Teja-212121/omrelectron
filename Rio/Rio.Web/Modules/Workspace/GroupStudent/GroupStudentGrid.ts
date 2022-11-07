import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { GroupStudentColumns, GroupStudentRow, GroupStudentService } from '../../ServerTypes/Workspace';
import { GroupStudentDialog } from './GroupStudentDialog';

@Decorators.registerClass()
export class GroupStudentGrid extends EntityGrid<GroupStudentRow, any> {
    protected getColumnsKey() { return GroupStudentColumns.columnsKey; }
    protected getDialogType() { return GroupStudentDialog; }
    protected getIdProperty() { return GroupStudentRow.idProperty; }
    protected getInsertPermission() { return GroupStudentRow.insertPermission; }
    protected getLocalTextPrefix() { return GroupStudentRow.localTextPrefix; }
    protected getService() { return GroupStudentService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}