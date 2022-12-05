namespace Rio.Workspace {
    export interface ScannedDataExcelImportForm {
        ExamId: Serenity.LookupEditor;
        TenantId: Serenity.LookupEditor;
        FileName: Serenity.ImageUploadEditor;
    }

    export class ScannedDataExcelImportForm extends Serenity.PrefixedContext {
        static formKey = 'Rio.ScannedDataExcelImportForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ScannedDataExcelImportForm.init)  {
                ScannedDataExcelImportForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.ImageUploadEditor;

                Q.initFormType(ScannedDataExcelImportForm, [
                    'ExamId', w0,
                    'TenantId', w0,
                    'FileName', w1
                ]);
            }
        }
    }
}
