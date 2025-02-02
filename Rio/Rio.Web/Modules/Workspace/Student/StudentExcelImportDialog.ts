import { Decorators, PropertyDialog } from '@serenity-is/corelib';
import { DialogButton, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib/q';
import { StudentService } from '../../ServerTypes/Workspace';
import { StudentExcelImportForm } from '../../ServerTypes/Workspace/StudentExcelImportForm';

    @Decorators.registerClass()
    export class StudentExcelImportDialog extends PropertyDialog<any, any> {
        protected getFormKey() { return StudentExcelImportForm.formKey }

        protected form = new StudentExcelImportForm(this.idPrefix);

        constructor() {
            super();
            this.form = new StudentExcelImportForm(this.idPrefix);

            /*this.form.ExamId.changeSelect2(e => {
                var examId = toId(this.form.ExamId.value);
                if (examId != null) {
                    this.form.ExamId.value = .ExamRow.getLookup().itemById[examId].Id;
                }
            });*/
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

                        StudentService.ExcelImport({
                            FileName: this.form.FileName.value.Filename,
                            Comments: this.form.Comments.value
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