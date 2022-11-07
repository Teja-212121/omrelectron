import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamQuestionColumns, ExamQuestionRow, ExamQuestionService } from '../../ServerTypes/Workspace';
import { ExamQuestionDialog } from './ExamQuestionDialog';

@Decorators.registerClass()
export class ExamQuestionGrid extends EntityGrid<ExamQuestionRow, any> {
    protected getColumnsKey() { return ExamQuestionColumns.columnsKey; }
    protected getDialogType() { return ExamQuestionDialog; }
    protected getIdProperty() { return ExamQuestionRow.idProperty; }
    protected getInsertPermission() { return ExamQuestionRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamQuestionRow.localTextPrefix; }
    protected getService() { return ExamQuestionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}