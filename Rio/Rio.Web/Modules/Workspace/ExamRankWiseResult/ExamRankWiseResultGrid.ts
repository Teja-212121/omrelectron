import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamRankWiseResultColumns, ExamRankWiseResultRow, ExamRankWiseResultService } from '../../ServerTypes/Workspace';
import { ExamRankWiseResultDialog } from './ExamRankWiseResultDialog';

@Decorators.registerClass()
export class ExamRankWiseResultGrid extends EntityGrid<ExamRankWiseResultRow, any> {
    protected getColumnsKey() { return ExamRankWiseResultColumns.columnsKey; }
    protected getDialogType() { return ExamRankWiseResultDialog; }
    protected getIdProperty() { return ExamRankWiseResultRow.idProperty; }
    protected getInsertPermission() { return ExamRankWiseResultRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamRankWiseResultRow.localTextPrefix; }
    protected getService() { return ExamRankWiseResultService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}