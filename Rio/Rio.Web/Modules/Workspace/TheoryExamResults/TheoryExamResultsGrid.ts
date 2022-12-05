import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TheoryExamResultsColumns, TheoryExamResultsRow, TheoryExamResultsService } from '../../ServerTypes/Workspace';
import { TheoryExamResultsDialog } from './TheoryExamResultsDialog';

@Decorators.registerClass()
export class TheoryExamResultsGrid extends EntityGrid<TheoryExamResultsRow, any> {
    protected getColumnsKey() { return TheoryExamResultsColumns.columnsKey; }
    protected getDialogType() { return TheoryExamResultsDialog; }
    protected getIdProperty() { return TheoryExamResultsRow.idProperty; }
    protected getInsertPermission() { return TheoryExamResultsRow.insertPermission; }
    protected getLocalTextPrefix() { return TheoryExamResultsRow.localTextPrefix; }
    protected getService() { return TheoryExamResultsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}