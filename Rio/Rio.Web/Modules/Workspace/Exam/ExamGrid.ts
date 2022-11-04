import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamColumns, ExamRow, ExamService } from '../../ServerTypes/Workspace';
import { ExamDialog } from './ExamDialog';

@Decorators.registerClass()
export class ExamGrid extends EntityGrid<ExamRow, any> {
    protected getColumnsKey() { return ExamColumns.columnsKey; }
    protected getDialogType() { return ExamDialog; }
    protected getIdProperty() { return ExamRow.idProperty; }
    protected getInsertPermission() { return ExamRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamRow.localTextPrefix; }
    protected getService() { return ExamService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}