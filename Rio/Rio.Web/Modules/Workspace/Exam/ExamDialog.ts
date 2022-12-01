import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { Authorization } from '@serenity-is/corelib/q';
import { ExamForm, ExamRow, ExamService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class ExamDialog extends EntityDialog<ExamRow, any> {
    protected getFormKey() { return ExamForm.formKey; }
    protected getIdProperty() { return ExamRow.idProperty; }
    protected getLocalTextPrefix() { return ExamRow.localTextPrefix; }
    protected getNameProperty() { return ExamRow.nameProperty; }
    protected getService() { return ExamService.baseUrl; }
    protected getDeletePermission() { return ExamRow.deletePermission; }
    protected getInsertPermission() { return ExamRow.insertPermission; }
    protected getUpdatePermission() { return ExamRow.updatePermission; }

    protected form = new ExamForm(this.idPrefix);

    constructor() {
        super();
        this.form = new ExamForm(this.idPrefix);

        if (!Authorization.hasPermission("Administration:Security")) {
            this.form.SelectedTenant.getGridField().toggle(false);
        }
    }
}