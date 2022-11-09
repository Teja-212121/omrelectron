import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamResultColumns, ExamResultRow, ExamResultService } from '../../ServerTypes/Workspace';
import { ExamResultDialog } from './ExamResultDialog';

@Decorators.registerClass()
export class ExamResultGrid extends EntityGrid<ExamResultRow, any> {
    protected getColumnsKey() { return ExamResultColumns.columnsKey; }
    protected getDialogType() { return ExamResultDialog; }
    protected getIdProperty() { return ExamResultRow.idProperty; }
    protected getInsertPermission() { return ExamResultRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamResultRow.localTextPrefix; }
    protected getService() { return ExamResultService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}