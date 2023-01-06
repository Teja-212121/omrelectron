namespace Rio.Workspace {
    export interface ExamForm {
        Code: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        SheetTypeId: Serenity.LookupEditor;
        TotalQuestions: Serenity.IntegerEditor;
        TotalMarks: Serenity.IntegerEditor;
        NegativeMarks: Serenity.DecimalEditor;
        OptionsAvailable: Serenity.IntegerEditor;
        ResultCriteria: Serenity.StringEditor;
        QuestionPaper: Serenity.ImageUploadEditor;
        ModelAnswer: Serenity.ImageUploadEditor;
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
                var w2 = s.LookupEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.DecimalEditor;
                var w5 = s.ImageUploadEditor;

                Q.initFormType(ExamForm, [
                    'Code', w0,
                    'Name', w0,
                    'Description', w1,
                    'SheetTypeId', w2,
                    'TotalQuestions', w3,
                    'TotalMarks', w3,
                    'NegativeMarks', w4,
                    'OptionsAvailable', w3,
                    'ResultCriteria', w0,
                    'QuestionPaper', w5,
                    'ModelAnswer', w5,
                    'SelectedTenant', w2
                ]);
            }
        }
    }
}
