import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TheoryExamsColumns, TheoryExamsRow, TheoryExamsService } from '../../ServerTypes/Workspace';
import { TheoryExamsDialog } from './TheoryExamsDialog';

@Decorators.registerClass()
export class TheoryExamsGrid extends EntityGrid<TheoryExamsRow, any> {
    protected getColumnsKey() { return TheoryExamsColumns.columnsKey; }
    protected getDialogType() { return TheoryExamsDialog; }
    protected getIdProperty() { return TheoryExamsRow.idProperty; }
    protected getInsertPermission() { return TheoryExamsRow.insertPermission; }
    protected getLocalTextPrefix() { return TheoryExamsRow.localTextPrefix; }
    protected getService() { return TheoryExamsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}