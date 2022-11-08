import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ScannedQuestionForm, ScannedQuestionRow, ScannedQuestionService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ScannedQuestionDialog extends EntityDialog<ScannedQuestionRow, any> {
    protected getFormKey() { return ScannedQuestionForm.formKey; }
    protected getIdProperty() { return ScannedQuestionRow.idProperty; }
    protected getLocalTextPrefix() { return ScannedQuestionRow.localTextPrefix; }
    protected getService() { return ScannedQuestionService.baseUrl; }
    protected getDeletePermission() { return ScannedQuestionRow.deletePermission; }
    protected getInsertPermission() { return ScannedQuestionRow.insertPermission; }
    protected getUpdatePermission() { return ScannedQuestionRow.updatePermission; }

    protected form = new ScannedQuestionForm(this.idPrefix);

}