namespace Rio.Workspace {
    export interface TheoryExamResultsForm {
        TheoryExamId: Serenity.LookupEditor;
        StudentScanId: Serenity.StringEditor;
        MarksScored: Serenity.DecimalEditor;
        OutOfMarks: Serenity.DecimalEditor;
        ResultStatus: Serenity.IntegerEditor;
        RollNumber: Serenity.StringEditor;
        SheetImage: Serenity.ImageUploadEditor;
        StudentId: Serenity.StringEditor;
        AttemptDate: Serenity.DateEditor;
    }

    export class TheoryExamResultsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExamResults';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamResultsForm.init)  {
                TheoryExamResultsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.ImageUploadEditor;
                var w5 = s.DateEditor;

                Q.initFormType(TheoryExamResultsForm, [
                    'TheoryExamId', w0,
                    'StudentScanId', w1,
                    'MarksScored', w2,
                    'OutOfMarks', w2,
                    'ResultStatus', w3,
                    'RollNumber', w1,
                    'SheetImage', w4,
                    'StudentId', w1,
                    'AttemptDate', w5
                ]);
            }
        }
    }
}
