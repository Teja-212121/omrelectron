import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamGroupWiseResultColumns, ExamGroupWiseResultRow, ExamGroupWiseResultService } from '../../ServerTypes/Workspace';
import { ExamGroupWiseResultDialog } from './ExamGroupWiseResultDialog';

@Decorators.registerClass()
export class ExamGroupWiseResultGrid extends EntityGrid<ExamGroupWiseResultRow, any> {
    protected getColumnsKey() { return ExamGroupWiseResultColumns.columnsKey; }
    protected getDialogType() { return ExamGroupWiseResultDialog; }
    protected getIdProperty() { return ExamGroupWiseResultRow.idProperty; }
    protected getInsertPermission() { return ExamGroupWiseResultRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamGroupWiseResultRow.localTextPrefix; }
    protected getService() { return ExamGroupWiseResultService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}