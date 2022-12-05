import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TheoryExamsForm, TheoryExamsRow, TheoryExamsService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class TheoryExamsDialog extends EntityDialog<TheoryExamsRow, any> {
    protected getFormKey() { return TheoryExamsForm.formKey; }
    protected getIdProperty() { return TheoryExamsRow.idProperty; }
    protected getLocalTextPrefix() { return TheoryExamsRow.localTextPrefix; }
    protected getNameProperty() { return TheoryExamsRow.nameProperty; }
    protected getService() { return TheoryExamsService.baseUrl; }
    protected getDeletePermission() { return TheoryExamsRow.deletePermission; }
    protected getInsertPermission() { return TheoryExamsRow.insertPermission; }
    protected getUpdatePermission() { return TheoryExamsRow.updatePermission; }

    protected form = new TheoryExamsForm(this.idPrefix);

}