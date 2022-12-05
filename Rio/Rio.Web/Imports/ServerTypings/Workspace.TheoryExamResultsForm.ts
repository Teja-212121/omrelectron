namespace Rio.Workspace {
    export interface TheoryExamResultsForm {
        TheoryExamId: Serenity.StringEditor;
        StudentScanId: Serenity.StringEditor;
        TheoryExamQuestionId: Serenity.StringEditor;
        MarksObtained: Serenity.DecimalEditor;
        AttemptStatus: Serenity.IntegerEditor;
        RollNumber: Serenity.StringEditor;
        StudentId: Serenity.StringEditor;
    }

    export class TheoryExamResultsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExamResults';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamResultsForm.init)  {
                TheoryExamResultsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(TheoryExamResultsForm, [
                    'TheoryExamId', w0,
                    'StudentScanId', w0,
                    'TheoryExamQuestionId', w0,
                    'MarksObtained', w1,
                    'AttemptStatus', w2,
                    'RollNumber', w0,
                    'StudentId', w0
                ]);
            }
        }
    }
}
