import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TheoryExamQuestionsColumns, TheoryExamQuestionsRow, TheoryExamQuestionsService } from '../../ServerTypes/Workspace';
import { TheoryExamQuestionsDialog } from './TheoryExamQuestionsDialog';

@Decorators.registerClass()
export class TheoryExamQuestionsGrid extends EntityGrid<TheoryExamQuestionsRow, any> {
    protected getColumnsKey() { return TheoryExamQuestionsColumns.columnsKey; }
    protected getDialogType() { return TheoryExamQuestionsDialog; }
    protected getIdProperty() { return TheoryExamQuestionsRow.idProperty; }
    protected getInsertPermission() { return TheoryExamQuestionsRow.insertPermission; }
    protected getLocalTextPrefix() { return TheoryExamQuestionsRow.localTextPrefix; }
    protected getService() { return TheoryExamQuestionsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}