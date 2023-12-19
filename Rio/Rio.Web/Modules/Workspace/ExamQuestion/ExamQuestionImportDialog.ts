import { Decorators, EntityDialog, EditorUtils } from "@serenity-is/corelib";
import { DialogButton, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib/q';
import { ExamQuestionRow, ExamQuestionImportForm, ExamQuestionService, ExamService } from "../../ServerTypes/Workspace";

@Decorators.registerClass()
export class ExamQuestionImportDialog extends EntityDialog<ExamQuestionRow, any> {
    protected getFormKey() { return ExamQuestionImportForm.formKey }

    protected form = new ExamQuestionImportForm(this.idPrefix);
    public ExamId: number;
    constructor(ExamId) {
        super();
        this.form = new ExamQuestionImportForm(this.idPrefix);
        this.ExamId = ExamId;
        //this.form.ExamId = ExamId;
    
    }

    protected getDialogTitle(): string {
        return "Excel Import";
    }
    
    //loadEntity(entity: ExamQuestionRow) {
    //    super.loadEntity(entity);
    //    this.form.ExamId.value = this.ExamId.toString();
        
    //}
    protected getDialogButtons(): DialogButton[] {
        return [
            {
                text: 'Import',
                click: () => {
                    /debugger;/
                    if (!this.validateBeforeSave())
                        return;

                    if (this.form.FileName.value == null ||
                        isEmptyOrNull(this.form.FileName.value.Filename)) {
                        notifyError("Please select a file!");
                        return;
                    }

                    ExamQuestionService.ExcelImport({
                        FileName: this.form.FileName.value.Filename,
                        ExamId: Number(this.ExamId)
                    }, response => {
                        notifyInfo(
                            'Inserted: ' + (response.Inserted || 0));

                        if (response.ErrorList != null && response.ErrorList.length > 0) {
                            notifyError(response.ErrorList.join(',\r\n '));
                        }

                        this.dialogClose();
                    });
                },
            },
            {
                text: 'Cancel',
                click: () => this.dialogClose()
            }
        ];
    }

}