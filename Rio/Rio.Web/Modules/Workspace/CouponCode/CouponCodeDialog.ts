import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { isEmptyOrNull } from '@serenity-is/corelib/q';
import { CouponCodeForm, CouponCodeRow, CouponCodeService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class CouponCodeDialog extends EntityDialog<CouponCodeRow, any> {
    protected getFormKey() { return CouponCodeForm.formKey; }
    protected getIdProperty() { return CouponCodeRow.idProperty; }
    protected getLocalTextPrefix() { return CouponCodeRow.localTextPrefix; }
    protected getNameProperty() { return CouponCodeRow.nameProperty; }
    protected getService() { return CouponCodeService.baseUrl; }
    protected getDeletePermission() { return CouponCodeRow.deletePermission; }
    protected getInsertPermission() { return CouponCodeRow.insertPermission; }
    protected getUpdatePermission() { return CouponCodeRow.updatePermission; }

    protected form = new CouponCodeForm(this.idPrefix);

    loadEntity(entity: CouponCodeRow) {
        super.loadEntity(entity);
        //debugger;
        if (this.isNew()) {
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