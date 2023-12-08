import { Decorators, ToolButton, EditorUtils,  EntityDialog } from '@serenity-is/corelib';
import { KeyGenAsForm, KeyGenAsRow, KeyGenAsService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class KeyGenAsDialog extends EntityDialog<KeyGenAsRow, any> {
    protected getFormKey() { return KeyGenAsForm.formKey; }
    protected getIdProperty() { return KeyGenAsRow.idProperty; }
    protected getLocalTextPrefix() { return KeyGenAsRow.localTextPrefix; }
    protected getNameProperty() { return KeyGenAsRow.nameProperty; }
    protected getService() { return KeyGenAsService.baseUrl; }
    protected getDeletePermission() { return KeyGenAsRow.deletePermission; }
    protected getInsertPermission() { return KeyGenAsRow.insertPermission; }
    protected getUpdatePermission() { return KeyGenAsRow.updatePermission; }

    protected form = new KeyGenAsForm(this.idPrefix);

    loadEntity(entity: KeyGenAsRow) {
        super.loadEntity(entity);
        this.form.ValidityType.changeSelect2(e => {
            this.setValidityInfo();
        });
        this.setValidityInfo();
    }
    setValidityInfo() {
        debugger;
        if (this.form.ValidityType.value != null) {
            var unlimited = (this.form.ValidityType.value == "1");
            var validtill = (this.form.ValidityType.value == "2");
            var validinDays = (this.form.ValidityType.value == "3");
            this.form.ValidityType.getGridField().toggle(validtill);
            if (validtill) {
                this.form.ValidDate.value = "";
                EditorUtils.setRequired(this.form.ValidDate, true);
                EditorUtils.setRequired(this.form.ValidityInDays, false);
            }
            this.form.ValidityType.getGridField().toggle(validinDays);
            if (validinDays) {
                this.form.ValidityInDays.value = 0;
                EditorUtils.setRequired(this.form.ValidityInDays, true);
                EditorUtils.setRequired(this.form.ValidDate, false);

            }
            if (unlimited) {
                this.form.ValidityInDays.getGridField().toggle(false);
                this.form.ValidDate.getGridField().toggle(false);
                EditorUtils.setRequired(this.form.ValidDate, false);
                EditorUtils.setRequired(this.form.ValidityInDays, false);
            }
        }
        else {
            this.form.ValidityInDays.getGridField().toggle(false);
            this.form.ValidDate.getGridField().toggle(false);
            EditorUtils.setRequired(this.form.ValidDate, true);
            EditorUtils.setRequired(this.form.ValidityInDays, true);
        }
    }
    protected getToolbarButtons(): ToolButton[] {
        let buttons = super.getToolbarButtons();

        buttons.splice(1, 5);
        //buttons.splice(indexOf(buttons, x => x.action == "apply-changes"), 1);

        // We could also remove delete button here, but for demonstration 
        // purposes we'll hide it in another method (updateInterface)
        // buttons.splice(Q.indexOf(buttons, x => x.action == "delete"), 1);

        return buttons;
    }
}