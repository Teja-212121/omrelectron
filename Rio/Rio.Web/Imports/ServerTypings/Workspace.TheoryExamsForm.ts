namespace Rio.Workspace {
    export interface TheoryExamsForm {
        Code: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        TotalMarks: Serenity.IntegerEditor;
    }

    export class TheoryExamsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExams';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamsForm.init)  {
                TheoryExamsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(TheoryExamsForm, [
                    'Code', w0,
                    'Name', w0,
                    'Description', w0,
                    'TotalMarks', w1
                ]);
            }
        }
    }
}
