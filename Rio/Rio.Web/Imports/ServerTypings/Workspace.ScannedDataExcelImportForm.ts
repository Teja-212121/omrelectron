namespace Rio.Workspace {
    export interface ScannedDataExcelImportForm {
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
                var w0 = s.ImageUploadEditor;

                Q.initFormType(ScannedDataExcelImportForm, [
                    'FileName', w0
                ]);
            }
        }
    }
}
