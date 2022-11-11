namespace Rio.Workspace {
    export interface ExamQuestionUpdateForm {
        RowIds: Serenity.StringEditor;
        ExamId: Serenity.LookupEditor;
        ExamSectionId: Serenity.LookupEditor;
    }

    export class ExamQuestionUpdateForm extends Serenity.PrefixedContext {
        static formKey = 'Rio.ExamQuestionUpdateForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamQuestionUpdateForm.init)  {
                ExamQuestionUpdateForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(ExamQuestionUpdateForm, [
                    'RowIds', w0,
                    'ExamId', w1,
                    'ExamSectionId', w1
                ]);
            }
        }
    }
}
