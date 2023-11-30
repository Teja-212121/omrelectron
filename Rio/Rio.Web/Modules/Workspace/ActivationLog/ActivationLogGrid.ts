import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ActivationLogColumns, ActivationLogRow, ActivationLogService } from '../../ServerTypes/Workspace';
import { ActivationLogDialog } from './ActivationLogDialog';

@Decorators.registerClass()
export class ActivationLogGrid extends EntityGrid<ActivationLogRow, any> {
    protected getColumnsKey() { return ActivationLogColumns.columnsKey; }
    protected getDialogType() { return ActivationLogDialog; }
    protected getIdProperty() { return ActivationLogRow.idProperty; }
    protected getInsertPermission() { return ActivationLogRow.insertPermission; }
    protected getLocalTextPrefix() { return ActivationLogRow.localTextPrefix; }
    protected getService() { return ActivationLogService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}