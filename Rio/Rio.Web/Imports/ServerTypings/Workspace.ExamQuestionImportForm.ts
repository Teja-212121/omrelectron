namespace Rio.Workspace {
    export interface ExamQuestionImportForm {
        ExamId: Serenity.LookupEditor;
        FileName: Serenity.ImageUploadEditor;
    }

    export class ExamQuestionImportForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamQuestionImportForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamQuestionImportForm.init)  {
                ExamQuestionImportForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.ImageUploadEditor;

                Q.initFormType(ExamQuestionImportForm, [
                    'ExamId', w0,
                    'FileName', w1
                ]);
            }
        }
    }
}
