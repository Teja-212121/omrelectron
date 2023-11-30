import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamListColumns, ExamListRow, ExamListService } from '../../ServerTypes/Workspace';
import { ExamListDialog } from './ExamListDialog';

@Decorators.registerClass()
export class ExamListGrid extends EntityGrid<ExamListRow, any> {
    protected getColumnsKey() { return ExamListColumns.columnsKey; }
    protected getDialogType() { return ExamListDialog; }
    protected getIdProperty() { return ExamListRow.idProperty; }
    protected getInsertPermission() { return ExamListRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamListRow.localTextPrefix; }
    protected getService() { return ExamListService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}