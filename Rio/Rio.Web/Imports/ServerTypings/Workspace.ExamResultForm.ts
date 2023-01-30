namespace Rio.Workspace {
    export interface ExamResultForm {
        StudentId: Serenity.LookupEditor;
        OCRData1Value: Serenity.StringEditor;
        RollNumber: Serenity.StringEditor;
        SheetNumber: Serenity.StringEditor;
        SheetGuid: Serenity.StringEditor;
        ExamId: Serenity.LookupEditor;
        TotalMarks: Serenity.DecimalEditor;
        ObtainedMarks: Serenity.DecimalEditor;
        Percentage: Serenity.DecimalEditor;
        TotalQuestions: Serenity.IntegerEditor;
        TotalAttempted: Serenity.IntegerEditor;
        TotalNotAttempted: Serenity.IntegerEditor;
        TotalRightAnswers: Serenity.IntegerEditor;
        TotalWrongAnswers: Serenity.IntegerEditor;
    }

    export class ExamResultForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamResult';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamResultForm.init)  {
                ExamResultForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.IntegerEditor;

                Q.initFormType(ExamResultForm, [
                    'StudentId', w0,
                    'OCRData1Value', w1,
                    'RollNumber', w1,
                    'SheetNumber', w1,
                    'SheetGuid', w1,
                    'ExamId', w0,
                    'TotalMarks', w2,
                    'ObtainedMarks', w2,
                    'Percentage', w2,
                    'TotalQuestions', w3,
                    'TotalAttempted', w3,
                    'TotalNotAttempted', w3,
                    'TotalRightAnswers', w3,
                    'TotalWrongAnswers', w3
                ]);
            }
        }
    }
}
