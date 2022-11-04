import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { SheetTypeForm, SheetTypeRow, SheetTypeService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class SheetTypeDialog extends EntityDialog<SheetTypeRow, any> {
    protected getFormKey() { return SheetTypeForm.formKey; }
    protected getIdProperty() { return SheetTypeRow.idProperty; }
    protected getLocalTextPrefix() { return SheetTypeRow.localTextPrefix; }
    protected getNameProperty() { return SheetTypeRow.nameProperty; }
    protected getService() { return SheetTypeService.baseUrl; }
    protected getDeletePermission() { return SheetTypeRow.deletePermission; }
    protected getInsertPermission() { return SheetTypeRow.insertPermission; }
    protected getUpdatePermission() { return SheetTypeRow.updatePermission; }

    protected form = new SheetTypeForm(this.idPrefix);

}