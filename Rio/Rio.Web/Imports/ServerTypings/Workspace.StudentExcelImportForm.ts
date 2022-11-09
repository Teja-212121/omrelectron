namespace Rio.Workspace {
    export interface StudentExcelImportForm {
        FileName: Serenity.ImageUploadEditor;
    }

    export class StudentExcelImportForm extends Serenity.PrefixedContext {
        static formKey = 'Rio.StudentExcelImportForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StudentExcelImportForm.init)  {
                StudentExcelImportForm.init = true;

                var s = Serenity;
                var w0 = s.ImageUploadEditor;

                Q.initFormType(StudentExcelImportForm, [
                    'FileName', w0
                ]);
            }
        }
    }
}
