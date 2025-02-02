import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';
import { isEmptyOrNull } from '@serenity-is/corelib/q';
import { SerialKeyForm, SerialKeyRow, SerialKeyService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class SerialKeyDialog extends EntityDialog<SerialKeyRow, any> {
    protected getFormKey() { return SerialKeyForm.formKey; }
    protected getIdProperty() { return SerialKeyRow.idProperty; }
    protected getLocalTextPrefix() { return SerialKeyRow.localTextPrefix; }
    protected getNameProperty() { return SerialKeyRow.nameProperty; }
    protected getService() { return SerialKeyService.baseUrl; }
    protected getDeletePermission() { return SerialKeyRow.deletePermission; }
    protected getInsertPermission() { return SerialKeyRow.insertPermission; }
    protected getUpdatePermission() { return SerialKeyRow.updatePermission; }

    protected form = new SerialKeyForm(this.idPrefix);



    loadEntity(entity: SerialKeyRow) {
        super.loadEntity(entity);
        //debugger;
        if (this.isNew())
        {
            this.form.EStatus.set_readOnly(true);
            /* this.form.EStatus.value = '2';*/
          
        }
        else {
            
            EditorUtils.setReadonly(this.form.SerialKey.element, true);
            EditorUtils.setReadonly(this.form.ExamListId.element, true);
            
        }

        this.form.ValidityType.changeSelect2(e => {
            var vValidityType = this.form.ValidityType.value;
            if (isEmptyOrNull(vValidityType)) {
                this.form.ValidityInDays.getGridField().toggle(false);
                this.form.ValidDate.getGridField().toggle(false);
            }

            if (vValidityType == '2') {

                this.form.ValidDate.getGridField().toggle(true);
                this.form.ValidityInDays.getGridField().toggle(false);
                EditorUtils.setRequired(this.form.ValidDate, true);
                EditorUtils.setRequired(this.form.ValidityInDays, false);
            }
            else if (vValidityType == '3') {
                this.form.ValidDate.getGridField().toggle(false);
                this.form.ValidityInDays.getGridField().toggle(true);
                EditorUtils.setRequired(this.form.ValidityInDays, true);
                EditorUtils.setRequired(this.form.ValidDate, false);
            }
            else {
                this.form.ValidityInDays.getGridField().toggle(false);
                this.form.ValidDate.getGridField().toggle(false);
                EditorUtils.setRequired(this.form.ValidityInDays, false);
                EditorUtils.setRequired(this.form.ValidDate, false);
            }
        });

        var vValidityType = this.form.ValidityType.value;
        if (isEmptyOrNull(vValidityType)) {
            this.form.ValidityInDays.getGridField().toggle(false);
            this.form.ValidDate.getGridField().toggle(false);
        }

        if (vValidityType == '2') {

            this.form.ValidDate.getGridField().toggle(true);
            this.form.ValidityInDays.getGridField().toggle(false);
            EditorUtils.setRequired(this.form.ValidDate, true);
            EditorUtils.setRequired(this.form.ValidityInDays, false);
        }
        else if (vValidityType == '3') {
            this.form.ValidDate.getGridField().toggle(false);
            this.form.ValidityInDays.getGridField().toggle(true);
            EditorUtils.setRequired(this.form.ValidityInDays, true);
            EditorUtils.setRequired(this.form.ValidDate, false);
        }
        else {
            this.form.ValidityInDays.getGridField().toggle(false);
            this.form.ValidDate.getGridField().toggle(false);
            //this.form.ValidDate.value = new Date()
            EditorUtils.setRequired(this.form.ValidityInDays, false);
            EditorUtils.setRequired(this.form.ValidDate, false);
        }

    }

}