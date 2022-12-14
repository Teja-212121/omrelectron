import { Decorators, EntityDialog, ToolButton, TabsExtensions, EditorUtils } from '@serenity-is/corelib';
import { ImportedScannedSheetForm, ImportedScannedSheetRow, ImportedScannedSheetService } from '../../ServerTypes/Workspace';
import { ImportedScannedQuestionTabGrid } from '../ImportedScannedQuestion/ImportedScannedQuestionTabGrid';

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

    private importedScannedQuestiongrid: ImportedScannedQuestionTabGrid;
    private loadedState: string;

    constructor() {
        super();

        this.importedScannedQuestiongrid = new ImportedScannedQuestionTabGrid(this.byId('ImportedScannedQuestionTabGrid'));
        // force order dialog to open in Dialog mode instead of Panel mode
        // which is set as default on OrderDialog with @panelAttribute
        this.importedScannedQuestiongrid.openDialogsAsPanel = false;

    }

    getSaveState() {
        try {
            return $.toJSON(this.getSaveEntity());
        }
        catch (e) {
            return null;
        }
    }

    loadResponse(data) {
        super.loadResponse(data);
        this.loadedState = this.getSaveState();
    }

    loadEntity(entity: ImportedScannedSheetRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'ImportedScannedQuestion', this.isNewOrDeleted());

        this.importedScannedQuestiongrid.importedScannedSheetId = entity.Id;
    }

    protected afterLoadEntity() {
        super.afterLoadEntity();
        this.importedScannedQuestiongrid.importedScannedSheetId = this.entityId;
    }

    onSaveSuccess(response) {
        super.onSaveSuccess(response);
        TabsExtensions.setDisabled(this.tabs, 'ImportedScannedQuestion', this.isNewOrDeleted());
        this.loadedState = this.getSaveState();
    }

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

    updateInterface() {
        super.updateInterface();

        EditorUtils.setReadOnly(this.form.ScannedRollNo, true);
        EditorUtils.setReadOnly(this.form.ScannedExamNo, true);
    }

    getTemplate() {
        return `<div id="~_Tabs" class="s-DialogContent">
    <ul>
        <li><a href="#~_TabInfo"><span>Genaral</span></a></li>
        <li><a href="#~_TabImportedScannedQuestionTab"><span>Imported Scanned Question</span></a></li>
    </ul>
    <div id="~_TabInfo" class="tab-pane s-TabInfo">
        <div id="~_Toolbar" class="s-DialogToolbar">
        </div>
        <div class="s-Form">
            <form id="~_Form" action="">
                <div class="fieldset ui-widget ui-widget-content ui-corner-all">
                    <div id="~_PropertyGrid"></div>
                    <div class="clear"></div>
                </div>
            </form>
        </div>
    </div>
    <div id="~_TabImportedScannedQuestionTab" class="tab-pane s-TabImportedScannedQuestionTab">
        <div id="~_ImportedScannedQuestionTabGrid">
        </div>
    </div>
</div>`;
    }
}