namespace Rio.Workspace {
    export interface ExamSectionForm {
        ExamId: Serenity.LookupEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        ParentId: Serenity.LookupEditor;
    }

    export class ExamSectionForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamSection';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamSectionForm.init)  {
                ExamSectionForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.TextAreaEditor;

                Q.initFormType(ExamSectionForm, [
                    'ExamId', w0,
                    'Name', w1,
                    'Description', w2,
                    'ParentId', w0
                ]);
            }
        }
    }
}
