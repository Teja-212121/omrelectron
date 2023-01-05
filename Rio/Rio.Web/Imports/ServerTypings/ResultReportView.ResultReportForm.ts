namespace Rio.ResultReportView {
    export interface ResultReportForm {
        ScannedSheetId: Serenity.StringEditor;
        RollNumber: Serenity.IntegerEditor;
        ExamId: Serenity.IntegerEditor;
        ExamCode: Serenity.StringEditor;
        QuestionIndex: Serenity.IntegerEditor;
        IsAttempted: Serenity.IntegerEditor;
        IsCorrect: Serenity.IntegerEditor;
        RightOptions: Serenity.IntegerEditor;
        CorrectedOptions: Serenity.IntegerEditor;
        Score: Serenity.DecimalEditor;
        ObtainedMarks: Serenity.DecimalEditor;
    }

    export class ResultReportForm extends Serenity.PrefixedContext {
        static formKey = 'ResultReportView.ResultReport';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ResultReportForm.init)  {
                ResultReportForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;

                Q.initFormType(ResultReportForm, [
                    'ScannedSheetId', w0,
                    'RollNumber', w1,
                    'ExamId', w1,
                    'ExamCode', w0,
                    'QuestionIndex', w1,
                    'IsAttempted', w1,
                    'IsCorrect', w1,
                    'RightOptions', w1,
                    'CorrectedOptions', w1,
                    'Score', w2,
                    'ObtainedMarks', w2
                ]);
            }
        }
    }
}
