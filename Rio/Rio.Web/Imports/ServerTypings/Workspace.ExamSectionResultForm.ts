namespace Rio.Workspace {
    export interface ExamSectionResultForm {
        StudentId: Serenity.LookupEditor;
        RollNumber: Serenity.StringEditor;
        ScannedBatchId: Serenity.LookupEditor;
        SheetNumber: Serenity.StringEditor;
        SheetGuid: Serenity.LookupEditor;
        ExamId: Serenity.LookupEditor;
        ExamSectionId: Serenity.LookupEditor;
        TotalMarks: Serenity.DecimalEditor;
        ObtainedMarks: Serenity.DecimalEditor;
        Percentage: Serenity.DecimalEditor;
        TotalQuestions: Serenity.IntegerEditor;
        TotalAttempted: Serenity.IntegerEditor;
        TotalNotAttempted: Serenity.IntegerEditor;
        TotalRightAnswers: Serenity.IntegerEditor;
        TotalWrongAnswers: Serenity.IntegerEditor;
    }

    export class ExamSectionResultForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamSectionResult';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamSectionResultForm.init)  {
                ExamSectionResultForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.IntegerEditor;

                Q.initFormType(ExamSectionResultForm, [
                    'StudentId', w0,
                    'RollNumber', w1,
                    'ScannedBatchId', w0,
                    'SheetNumber', w1,
                    'SheetGuid', w0,
                    'ExamId', w0,
                    'ExamSectionId', w0,
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
