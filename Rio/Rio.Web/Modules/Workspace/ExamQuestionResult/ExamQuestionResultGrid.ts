import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamQuestionResultColumns, ExamQuestionResultRow, ExamQuestionResultService } from '../../ServerTypes/Workspace';
import { ExamQuestionResultDialog } from './ExamQuestionResultDialog';

@Decorators.registerClass()
export class ExamQuestionResultGrid extends EntityGrid<ExamQuestionResultRow, any> {
    protected getColumnsKey() { return ExamQuestionResultColumns.columnsKey; }
    protected getDialogType() { return ExamQuestionResultDialog; }
    protected getIdProperty() { return ExamQuestionResultRow.idProperty; }
    protected getInsertPermission() { return ExamQuestionResultRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamQuestionResultRow.localTextPrefix; }
    protected getService() { return ExamQuestionResultService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}