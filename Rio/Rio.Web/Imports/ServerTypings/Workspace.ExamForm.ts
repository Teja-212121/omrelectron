namespace Rio.Workspace {
    export interface ExamForm {
        Code: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        TotalQuestions: Serenity.IntegerEditor;
        TotalMarks: Serenity.IntegerEditor;
        NegativeMarks: Serenity.DecimalEditor;
        OptionsAvailable: Serenity.IntegerEditor;
        ResultCriteria: Serenity.StringEditor;
        SelectedTenant: Serenity.LookupEditor;
    }

    export class ExamForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.Exam';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamForm.init)  {
                ExamForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DecimalEditor;
                var w4 = s.LookupEditor;

                Q.initFormType(ExamForm, [
                    'Code', w0,
                    'Name', w0,
                    'Description', w1,
                    'TotalQuestions', w2,
                    'TotalMarks', w2,
                    'NegativeMarks', w3,
                    'OptionsAvailable', w2,
                    'ResultCriteria', w0,
                    'SelectedTenant', w4
                ]);
            }
        }
    }
}
