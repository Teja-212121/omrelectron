import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ScannedQuestionColumns, ScannedQuestionRow, ScannedQuestionService } from '../../ServerTypes/Workspace';
import { ScannedQuestionDialog } from './ScannedQuestionDialog';

@Decorators.registerClass()
export class ScannedQuestionGrid extends EntityGrid<ScannedQuestionRow, any> {
    protected getColumnsKey() { return ScannedQuestionColumns.columnsKey; }
    protected getDialogType() { return ScannedQuestionDialog; }
    protected getIdProperty() { return ScannedQuestionRow.idProperty; }
    protected getInsertPermission() { return ScannedQuestionRow.insertPermission; }
    protected getLocalTextPrefix() { return ScannedQuestionRow.localTextPrefix; }
    protected getService() { return ScannedQuestionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}