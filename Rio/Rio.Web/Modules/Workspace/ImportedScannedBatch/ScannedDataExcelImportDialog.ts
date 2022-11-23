import { Decorators, PropertyDialog } from '@serenity-is/corelib';
import { DialogButton } from '@serenity-is/corelib/q';
import { ScannedDataExcelImportForm } from '../../ServerTypes/Workspace';
import { ImportedScannedBatchService } from '../../ServerTypes/Workspace/ImportedScannedBatchService';

    @Decorators.registerClass()
    export class ScannedDataExcelImportDialog extends PropertyDialog<any, any> {
        protected getFormKey() { return ScannedDataExcelImportForm.formKey }

        protected form = new ScannedDataExcelImportForm(this.idPrefix);

        constructor() {
            super();
            this.form = new ScannedDataExcelImportForm(this.idPrefix);

            /*this.form.ExamId.changeSelect2(e => {
                var examId = Q.toId(this.form.ExamId.value);
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
                            Q.isEmptyOrNull(this.form.FileName.value.Filename)) {
                            Q.notifyError("Please select a file!");
                            return;
                        }

                        ImportedScannedBatchService.ExcelImport({
                            FileName: this.form.FileName.value.Filename,
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