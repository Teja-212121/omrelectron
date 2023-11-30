import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CouponCodeColumns, CouponCodeRow, CouponCodeService } from '../../ServerTypes/Workspace';
import { CouponCodeDialog } from './CouponCodeDialog';

@Decorators.registerClass()
export class CouponCodeGrid extends EntityGrid<CouponCodeRow, any> {
    protected getColumnsKey() { return CouponCodeColumns.columnsKey; }
    protected getDialogType() { return CouponCodeDialog; }
    protected getIdProperty() { return CouponCodeRow.idProperty; }
    protected getInsertPermission() { return CouponCodeRow.insertPermission; }
    protected getLocalTextPrefix() { return CouponCodeRow.localTextPrefix; }
    protected getService() { return CouponCodeService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}