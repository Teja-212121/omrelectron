import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamListExamsColumns, ExamListExamsRow, ExamListExamsService } from '../../ServerTypes/Workspace';
import { ExamListExamsDialog } from './ExamListExamsDialog';

@Decorators.registerClass()
export class ExamListExamsGrid extends EntityGrid<ExamListExamsRow, any> {
    protected getColumnsKey() { return ExamListExamsColumns.columnsKey; }
    protected getDialogType() { return ExamListExamsDialog; }
    protected getIdProperty() { return ExamListExamsRow.idProperty; }
    protected getInsertPermission() { return ExamListExamsRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamListExamsRow.localTextPrefix; }
    protected getService() { return ExamListExamsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}