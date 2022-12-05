import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamTeachersColumns, ExamTeachersRow, ExamTeachersService } from '../../ServerTypes/Workspace';
import { ExamTeachersDialog } from './ExamTeachersDialog';

@Decorators.registerClass()
export class ExamTeachersGrid extends EntityGrid<ExamTeachersRow, any> {
    protected getColumnsKey() { return ExamTeachersColumns.columnsKey; }
    protected getDialogType() { return ExamTeachersDialog; }
    protected getIdProperty() { return ExamTeachersRow.idProperty; }
    protected getInsertPermission() { return ExamTeachersRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamTeachersRow.localTextPrefix; }
    protected getService() { return ExamTeachersService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}