import { Decorators, EntityDialog, ToolButton } from '@serenity-is/corelib';
import { ImportedScannedSheetForm, ImportedScannedSheetRow, ImportedScannedSheetService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ImportedScannedSheetDialog extends EntityDialog<ImportedScannedSheetRow, any> {
    protected getFormKey() { return ImportedScannedSheetForm.formKey; }
    protected getIdProperty() { return ImportedScannedSheetRow.idProperty; }
    protected getLocalTextPrefix() { return ImportedScannedSheetRow.localTextPrefix; }
    protected getNameProperty() { return ImportedScannedSheetRow.nameProperty; }
    protected getService() { return ImportedScannedSheetService.baseUrl; }
    protected getDeletePermission() { return ImportedScannedSheetRow.deletePermission; }
    protected getInsertPermission() { return ImportedScannedSheetRow.insertPermission; }
    protected getUpdatePermission() { return ImportedScannedSheetRow.updatePermission; }

    protected form = new ImportedScannedSheetForm(this.idPrefix);

    protected getToolbarButtons(): ToolButton[] {
        let buttons = super.getToolbarButtons();
        //debugger;
        buttons.splice(0, 6);
        buttons.push({
            title: "Process Results",
            cssClass: 'edit-permissions-button ',
            icon: 'icon-lock-open text-green',
            onClick: () => {

                if (!this.validateBeforeSave())
                    return;
                //debugger;
               


                ImportedScannedSheetService.ProcessResult({
                    EntityId: this.entityId,
                    Entity: this.entity

                }, response => {

                    this.dialogClose();
                    /*this.Studentgrid.refresh();*/
                });
            }
        });
       

        return buttons;
    }
}