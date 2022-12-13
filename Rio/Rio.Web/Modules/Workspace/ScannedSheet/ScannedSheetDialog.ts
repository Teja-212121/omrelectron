import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ScannedSheetForm, ScannedSheetRow, ScannedSheetService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ScannedSheetDialog extends EntityDialog<ScannedSheetRow, any> {
    protected getFormKey() { return ScannedSheetForm.formKey; }
    protected getIdProperty() { return ScannedSheetRow.idProperty; }
    protected getLocalTextPrefix() { return ScannedSheetRow.localTextPrefix; }
    protected getNameProperty() { return ScannedSheetRow.nameProperty; }
    protected getService() { return ScannedSheetService.baseUrl; }
    protected getDeletePermission() { return ScannedSheetRow.deletePermission; }
    protected getInsertPermission() { return ScannedSheetRow.insertPermission; }
    protected getUpdatePermission() { return ScannedSheetRow.updatePermission; }

    protected form = new ScannedSheetForm(this.idPrefix);

    protected getToolbarButtons() {
        let buttons = super.getToolbarButtons();

        buttons.push({
            title: 'generate results',
            cssClass: 'edit-permissions-button',
            icon: 'fa-lock text-green',
            onClick: () => {
                ScannedSheetService.Update({
                    EntityId: this.entityId,
                    Entity: this.entity
                }, response => {
                    /*Q.alert("Result generated Successfully");*/
                });
            }
        });

        return buttons;
    }
}