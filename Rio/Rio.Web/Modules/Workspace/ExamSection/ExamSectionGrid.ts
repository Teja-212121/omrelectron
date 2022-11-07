import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamSectionColumns, ExamSectionRow, ExamSectionService } from '../../ServerTypes/Workspace';
import { ExamSectionDialog } from './ExamSectionDialog';

@Decorators.registerClass()
export class ExamSectionGrid extends EntityGrid<ExamSectionRow, any> {
    protected getColumnsKey() { return ExamSectionColumns.columnsKey; }
    protected getDialogType() { return ExamSectionDialog; }
    protected getIdProperty() { return ExamSectionRow.idProperty; }
    protected getInsertPermission() { return ExamSectionRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamSectionRow.localTextPrefix; }
    protected getService() { return ExamSectionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}