import { Decorators, PropertyDialog } from '@serenity-is/corelib';
import { DialogButton, Authorization, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib/q';
import { ScannedDataExcelImportForm } from '../../ServerTypes/Workspace';
import { ImportedScannedBatchService } from '../../ServerTypes/Workspace/ImportedScannedBatchService';

    @Decorators.registerClass()
    export class ScannedDataExcelImportDialog extends PropertyDialog<any, any> {
        protected getFormKey() { return ScannedDataExcelImportForm.formKey }

        protected form = new ScannedDataExcelImportForm(this.idPrefix);

        constructor() {
            super();
            this.form = new ScannedDataExcelImportForm(this.idPrefix);

            if (!Authorization.hasPermission("Administration:Security")) {
                this.form.TenantId.getGridField().toggle(false);
            }

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

                        ImportedScannedBatchService.ExcelImport({
                            FileName: this.form.FileName.value.Filename,
                            ExamId: this.form.ExamId.value,
                            TenantId: this.form.TenantId.value
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