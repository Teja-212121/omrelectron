import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ActivationColumns, ActivationRow, ActivationService } from '../../ServerTypes/Workspace';
import { ActivationDialog } from './ActivationDialog';

@Decorators.registerClass()
export class ActivationGrid extends EntityGrid<ActivationRow, any> {
    protected getColumnsKey() { return ActivationColumns.columnsKey; }
    protected getDialogType() { return ActivationDialog; }
    protected getIdProperty() { return ActivationRow.idProperty; }
    protected getInsertPermission() { return ActivationRow.insertPermission; }
    protected getLocalTextPrefix() { return ActivationRow.localTextPrefix; }
    protected getService() { return ActivationService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons() {
        const buttons = super.getButtons();
        buttons.splice(0, 3);

       
        return buttons;
    }
}