import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { attrEncode, Authorization, formatNumber, htmlEncode, Lookup, notifyError, parseDecimal, parseInteger, text, toId, trimToNull } from '@serenity-is/corelib/q';
import { Column, FormatterContext, NonDataRow } from '@serenity-is/sleekgrid';
import { ExamListColumns, ExamListExamsRow, ExamListRow, ExamListService } from '../../ServerTypes/Workspace';
import { ExamListExamsForExamListDialog } from '../ExamListExams/ExamListExamsForExamListDialog';
import { ExamListDialog } from './ExamListDialog';

@Decorators.registerClass()
export class ExamListGrid extends EntityGrid<ExamListRow, any> {

    pendingChanges: any;
    protected getColumnsKey() { return ExamListColumns.columnsKey; }
    protected getDialogType() { return ExamListDialog; }
    protected getIdProperty() { return ExamListRow.idProperty; }
    protected getInsertPermission() { return ExamListRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamListRow.localTextPrefix; }
    protected getService() { return ExamListService.baseUrl; }

    private rowSelection: GridRowSelectionMixin;

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns() {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        if (!Authorization.hasPermission("Administration:Security")) {
            columns = columns.filter(f => f.field != ExamListRow.Fields.TenantId);
        }
        return columns;
    }

    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }
}