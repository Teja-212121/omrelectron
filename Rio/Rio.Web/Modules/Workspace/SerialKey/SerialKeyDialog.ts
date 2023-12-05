import { Decorators, EntityDialog } from '@serenity-is/corelib';
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
        if (this.isNew()) {
            this.form.EStatus.set_readOnly(true);
            this.form.EStatus.value = '2';
            this.form.ValidityType.changeSelect2(e => {
                var vValidityType = this.form.ValidityType.value;
                if (isEmptyOrNull(vValidityType)) {
                    this.form.ValidityInDays.getGridField().toggle(false);
                    this.form.ValidDate.getGridField().toggle(false);
                }

                if (vValidityType == '2') {

                    this.form.ValidDate.getGridField().toggle(true);
                    this.form.ValidityInDays.getGridField().toggle(false);
                }
                else if (vValidityType == '3') {
                    this.form.ValidDate.getGridField().toggle(false);
                    this.form.ValidityInDays.getGridField().toggle(true);
                }
                else {
                    this.form.ValidityInDays.getGridField().toggle(false);
                    this.form.ValidDate.getGridField().toggle(false);
                }
            });
        }

        this.form.ValidityType.change(e => {
            var vValidityType = this.form.ValidityType.value;

            this.form.ValidityInDays.getGridField().toggle(false);
            this.form.ValidDate.getGridField().toggle(false);


            if (vValidityType == '2') {

                this.form.ValidDate.getGridField().toggle(true);
                this.form.ValidityInDays.getGridField().toggle(false);
            }
            else if (vValidityType == '3') {
                this.form.ValidDate.getGridField().toggle(false);
                this.form.ValidityInDays.getGridField().toggle(true);
            }
            else {
                this.form.ValidityInDays.getGridField().toggle(false);
                this.form.ValidDate.getGridField().toggle(false);
            }

        });

    }

}