import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { RuleTypeForm, RuleTypeRow, RuleTypeService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class RuleTypeDialog extends EntityDialog<RuleTypeRow, any> {
    protected getFormKey() { return RuleTypeForm.formKey; }
    protected getIdProperty() { return RuleTypeRow.idProperty; }
    protected getLocalTextPrefix() { return RuleTypeRow.localTextPrefix; }
    protected getNameProperty() { return RuleTypeRow.nameProperty; }
    protected getService() { return RuleTypeService.baseUrl; }
    protected getDeletePermission() { return RuleTypeRow.deletePermission; }
    protected getInsertPermission() { return RuleTypeRow.insertPermission; }
    protected getUpdatePermission() { return RuleTypeRow.updatePermission; }

    protected form = new RuleTypeForm(this.idPrefix);

}