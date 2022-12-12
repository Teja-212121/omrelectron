import { Decorators, PropertyDialog, EditorUtils } from "@serenity-is/corelib";
import { DialogButton } from '@serenity-is/corelib/q';
import { ExamQuestionImportForm, ExamQuestionService } from "../../ServerTypes/Workspace";

@Decorators.registerClass()
export class ExamQuestionImportDialog extends PropertyDialog<any, any> {
        protected getFormKey() { return ExamQuestionImportForm.formKey }

        protected form = new ExamQuestionImportForm(this.idPrefix);

        constructor() {
            super();
            this.form = new ExamQuestionImportForm(this.idPrefix);

            //this.form.ExamId.changeSelect2(e => {
            //    var examId = Q.toId(this.form.ExamId.value);
            //    if (examId != null) {
            //        this.form.ExamId.value = Workspace.ExamRow.getLookup().itemById[examId].Id;
            //    }
            //});
            this.form.ExamId = this.entity.Id;
        
        }

    updateTitle() {
        super.updateTitle();

        EditorUtils.setReadOnly(this.form.ExamId, true);
    }

        protected getDialogTitle(): string {
            return "Excel Import";
        }

        protected getDialogButtons(): DialogButton[] {
            return [
                {
                    text: 'Import',
                    click: () => {
                        /debugger;/
                        if (!this.validateBeforeSave())
                            return;

                        if (this.form.FileName.value == null ||
                            Q.isEmptyOrNull(this.form.FileName.value.Filename)) {
                            Q.notifyError("Please select a file!");
                            return;
                        }

                        ExamQuestionService.ExcelImport({
                            FileName: this.form.FileName.value.Filename,
                            ExamId: this.form.ExamId.value
                        }, response => {
                            Q.notifyInfo(
                                'Inserted: ' + (response.Inserted || 0));

                            if (response.ErrorList != null && response.ErrorList.length > 0) {
                                Q.notifyError(response.ErrorList.join(',\r\n '));
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