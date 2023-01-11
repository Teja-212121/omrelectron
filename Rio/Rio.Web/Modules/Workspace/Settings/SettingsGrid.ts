import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SettingsColumns, SettingsRow, SettingsService } from '../../ServerTypes/Workspace';
import { SettingsDialog } from './SettingsDialog';

@Decorators.registerClass()
export class SettingsGrid extends EntityGrid<SettingsRow, any> {
    protected getColumnsKey() { return SettingsColumns.columnsKey; }
    protected getDialogType() { return SettingsDialog; }
    protected getIdProperty() { return SettingsRow.idProperty; }
    protected getInsertPermission() { return SettingsRow.insertPermission; }
    protected getLocalTextPrefix() { return SettingsRow.localTextPrefix; }
    protected getService() { return SettingsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}