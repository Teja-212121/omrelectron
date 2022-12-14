import { Decorators, EntityDialog, TabsExtensions, EditorUtils } from '@serenity-is/corelib';
import { ScannedSheetForm, ScannedSheetRow, ScannedSheetService } from '../../ServerTypes/Workspace';
import { ScannedQuestionTabGrid } from '../ScannedQuestion/ScannedQuestionTabGrid';

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

    private scannedQuestiongrid: ScannedQuestionTabGrid;
    private loadedState: string;

    constructor() {
        super();

        this.scannedQuestiongrid = new ScannedQuestionTabGrid(this.byId('ScannedQuestionTabGrid'));
        // force order dialog to open in Dialog mode instead of Panel mode
        // which is set as default on OrderDialog with @panelAttribute
        this.scannedQuestiongrid.openDialogsAsPanel = false;

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

    loadEntity(entity: ScannedSheetRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'ScannedQuestion', this.isNewOrDeleted());

        this.scannedQuestiongrid.scannedSheetId = entity.Id;
    }

    protected afterLoadEntity() {
        super.afterLoadEntity();
        this.scannedQuestiongrid.scannedSheetId = this.entityId;
    }

    onSaveSuccess(response) {
        super.onSaveSuccess(response);
        TabsExtensions.setDisabled(this.tabs, 'ScannedQuestion', this.isNewOrDeleted());
        this.loadedState = this.getSaveState();
    }

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
                    /*alert("Result generated Successfully");*/
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
        <li><a href="#~_TabScannedQuestionTab"><span>Scanned Question</span></a></li>
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
    <div id="~_TabScannedQuestionTab" class="tab-pane s-TabScannedQuestionTab">
        <div id="~_ScannedQuestionTabGrid">
        </div>
    </div>
</div>`;
    }
}