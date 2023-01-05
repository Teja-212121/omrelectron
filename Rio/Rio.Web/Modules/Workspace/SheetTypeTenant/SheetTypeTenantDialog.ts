import { Decorators, EditorUtils, EntityDialog } from '@serenity-is/corelib';
import { SheetTypeTenantForm, SheetTypeTenantRow, SheetTypeTenantService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class SheetTypeTenantDialog extends EntityDialog<SheetTypeTenantRow, any> {
    protected getFormKey() { return SheetTypeTenantForm.formKey; }
    protected getIdProperty() { return SheetTypeTenantRow.idProperty; }
    protected getLocalTextPrefix() { return SheetTypeTenantRow.localTextPrefix; }
    protected getNameProperty() { return SheetTypeTenantRow.nameProperty; }
    protected getService() { return SheetTypeTenantService.baseUrl; }
    protected getDeletePermission() { return SheetTypeTenantRow.deletePermission; }
    protected getInsertPermission() { return SheetTypeTenantRow.insertPermission; }
    protected getUpdatePermission() { return SheetTypeTenantRow.updatePermission; }

    protected form = new SheetTypeTenantForm(this.idPrefix);

    updateInterface() {
        super.updateInterface();

        EditorUtils.setReadOnly(this.form.SheetTypeDescription, true);
        EditorUtils.setReadOnly(this.form.SheetTypeTotalQuestions, true);
        EditorUtils.setReadOnly(this.form.SheetTypeEPaperSize, true);
        EditorUtils.setReadOnly(this.form.SheetTypeHeightInPixel, true);
        EditorUtils.setReadOnly(this.form.SheetTypeWidthInPixel, true);
        EditorUtils.setReadOnly(this.form.SheetTypeSheetData, true);
        EditorUtils.setReadOnly(this.form.SheetTypeSheetImage, true);
        EditorUtils.setReadOnly(this.form.SheetTypeOverlayImage, true);
        EditorUtils.setReadOnly(this.form.SheetTypeSynced, true);
        EditorUtils.setReadOnly(this.form.SheetTypeIsPrivate, true);
        EditorUtils.setReadOnly(this.form.SheetTypeSheetNumber, true);
        EditorUtils.setReadOnly(this.form.SheetTypePdfTemplate, true);
    }
}