import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ResultReportColumns, ResultReportRow, ResultReportService } from '../../ServerTypes/ResultReportView';
import { ResultReportDialog } from './ResultReportDialog';

@Decorators.registerClass()
export class ResultReportGrid extends EntityGrid<ResultReportRow, any> {
    protected getColumnsKey() { return ResultReportColumns.columnsKey; }
    protected getDialogType() { return ResultReportDialog; }
    protected getIdProperty() { return ResultReportRow.idProperty; }
    protected getInsertPermission() { return ResultReportRow.insertPermission; }
    protected getLocalTextPrefix() { return ResultReportRow.localTextPrefix; }
    protected getService() { return ResultReportService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}