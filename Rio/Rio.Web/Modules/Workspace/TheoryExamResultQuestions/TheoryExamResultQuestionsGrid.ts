import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TheoryExamResultQuestionsColumns, TheoryExamResultQuestionsRow, TheoryExamResultQuestionsService } from '../../ServerTypes/Workspace';
import { TheoryExamResultQuestionsDialog } from './TheoryExamResultQuestionsDialog';

@Decorators.registerClass()
export class TheoryExamResultQuestionsGrid extends EntityGrid<TheoryExamResultQuestionsRow, any> {
    protected getColumnsKey() { return TheoryExamResultQuestionsColumns.columnsKey; }
    protected getDialogType() { return TheoryExamResultQuestionsDialog; }
    protected getIdProperty() { return TheoryExamResultQuestionsRow.idProperty; }
    protected getInsertPermission() { return TheoryExamResultQuestionsRow.insertPermission; }
    protected getLocalTextPrefix() { return TheoryExamResultQuestionsRow.localTextPrefix; }
    protected getService() { return TheoryExamResultQuestionsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}