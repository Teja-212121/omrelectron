namespace Rio.Workspace {
    export interface ExamQuestionResultForm {
        StudentId: Serenity.LookupEditor;
        RollNumber: Serenity.StringEditor;
        SheetNumber: Serenity.StringEditor;
        SheetGuid: Serenity.StringEditor;
        ExamId: Serenity.LookupEditor;
        QuestionIndex: Serenity.IntegerEditor;
        IsAttempted: Serenity.BooleanEditor;
        IsCorrect: Serenity.BooleanEditor;
        ObtainedMarks: Serenity.DecimalEditor;
    }

    export class ExamQuestionResultForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamQuestionResult';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamQuestionResultForm.init)  {
                ExamQuestionResultForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.BooleanEditor;
                var w4 = s.DecimalEditor;

                Q.initFormType(ExamQuestionResultForm, [
                    'StudentId', w0,
                    'RollNumber', w1,
                    'SheetNumber', w1,
                    'SheetGuid', w1,
                    'ExamId', w0,
                    'QuestionIndex', w2,
                    'IsAttempted', w3,
                    'IsCorrect', w3,
                    'ObtainedMarks', w4
                ]);
            }
        }
    }
}
