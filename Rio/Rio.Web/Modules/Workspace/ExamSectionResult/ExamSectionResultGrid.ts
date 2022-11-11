import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamSectionResultColumns, ExamSectionResultRow, ExamSectionResultService } from '../../ServerTypes/Workspace';
import { ExamSectionResultDialog } from './ExamSectionResultDialog';

@Decorators.registerClass()
export class ExamSectionResultGrid extends EntityGrid<ExamSectionResultRow, any> {
    protected getColumnsKey() { return ExamSectionResultColumns.columnsKey; }
    protected getDialogType() { return ExamSectionResultDialog; }
    protected getIdProperty() { return ExamSectionResultRow.idProperty; }
    protected getInsertPermission() { return ExamSectionResultRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamSectionResultRow.localTextPrefix; }
    protected getService() { return ExamSectionResultService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}