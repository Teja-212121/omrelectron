namespace Rio.Workspace {
    export interface PredfinedSerialKeyExcelImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    export class PredfinedSerialKeyExcelImportForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.PredfinedSerialKeyExcelImportForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PredfinedSerialKeyExcelImportForm.init)  {
                PredfinedSerialKeyExcelImportForm.init = true;

                var s = Serenity;
                var w0 = s.ImageUploadEditor;

                Q.initFormType(PredfinedSerialKeyExcelImportForm, [
                    'FileName', w0
                ]);
            }
        }
    }
}
