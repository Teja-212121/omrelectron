import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { SelectSheetTypeForm, SelectSheetTypeRow, SelectSheetTypeService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class SelectSheetTypeDialog extends EntityDialog<SelectSheetTypeRow, any> {
    protected getFormKey() { return SelectSheetTypeForm.formKey; }
    protected getIdProperty() { return SelectSheetTypeRow.idProperty; }
    protected getLocalTextPrefix() { return SelectSheetTypeRow.localTextPrefix; }
    protected getNameProperty() { return SelectSheetTypeRow.nameProperty; }
    protected getService() { return SelectSheetTypeService.baseUrl; }
    protected getDeletePermission() { return SelectSheetTypeRow.deletePermission; }
    protected getInsertPermission() { return SelectSheetTypeRow.insertPermission; }
    protected getUpdatePermission() { return SelectSheetTypeRow.updatePermission; }

    protected form = new SelectSheetTypeForm(this.idPrefix);

}