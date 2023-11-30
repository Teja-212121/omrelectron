import { Decorators, EntityDialog } from '@serenity-is/corelib';
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

}