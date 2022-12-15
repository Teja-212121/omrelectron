import { Decorators, PropertyDialog, EditorUtils } from "@serenity-is/corelib";
import { DialogButton, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib/q';
import { ExamQuestionImportForm, ExamQuestionService, ExamService } from "../../ServerTypes/Workspace";

@Decorators.registerClass()
export class ExamQuestionImportDialog extends PropertyDialog<any, any> {
        protected getFormKey() { return ExamQuestionImportForm.formKey }

        protected form = new ExamQuestionImportForm(this.idPrefix);

        constructor() {
            super();
            this.form = new ExamQuestionImportForm(this.idPrefix);

            if (this.dialogOpen) {
                ExamQuestionService.Retrieve({
                    EntityId: 1
                }, response => {
                    if (response.Entity != null)
                        this.form.ExamId.value = response.Entity.Id.toString();
                });
            }

            this.form.ExamId.set_readOnly(true);

            //this.form.ExamId.changeSelect2(e => {
            //    var examId = toId(this.form.ExamId.value);
            //    if (examId != null) {
            //        this.form.ExamId.value = Workspace.ExamRow.getLookup().itemById[examId].Id;
            //    }
            //});
        
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
                            isEmptyOrNull(this.form.FileName.value.Filename)) {
                            notifyError("Please select a file!");
                            return;
                        }

                        ExamQuestionService.ExcelImport({
                            FileName: this.form.FileName.value.Filename,
                            ExamId: this.form.ExamId.value
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