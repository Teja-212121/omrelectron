import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ImportedScannedQuestionColumns, ImportedScannedQuestionRow, ImportedScannedQuestionService } from '../../ServerTypes/Workspace';
import { ImportedScannedQuestionDialog } from './ImportedScannedQuestionDialog';

@Decorators.registerClass()
export class ImportedScannedQuestionGrid extends EntityGrid<ImportedScannedQuestionRow, any> {
    protected getColumnsKey() { return ImportedScannedQuestionColumns.columnsKey; }
    protected getDialogType() { return ImportedScannedQuestionDialog; }
    protected getIdProperty() { return ImportedScannedQuestionRow.idProperty; }
    protected getInsertPermission() { return ImportedScannedQuestionRow.insertPermission; }
    protected getLocalTextPrefix() { return ImportedScannedQuestionRow.localTextPrefix; }
    protected getService() { return ImportedScannedQuestionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}