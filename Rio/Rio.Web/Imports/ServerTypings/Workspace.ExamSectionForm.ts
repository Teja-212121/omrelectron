namespace Rio.Workspace {
    export interface ExamSectionForm {
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        ExamId: Serenity.LookupEditor;
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
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.LookupEditor;

                Q.initFormType(ExamSectionForm, [
                    'Name', w0,
                    'Description', w1,
                    'ExamId', w2,
                    'ParentId', w2
                ]);
            }
        }
    }
}
