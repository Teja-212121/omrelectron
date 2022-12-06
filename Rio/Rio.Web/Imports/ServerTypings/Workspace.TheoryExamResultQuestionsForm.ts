namespace Rio.Workspace {
    export interface TheoryExamResultQuestionsForm {
        TheoryExamResultId: Serenity.LookupEditor;
        TheoryExamQuestionId: Serenity.StringEditor;
        MarksObtained: Serenity.DecimalEditor;
        OutOfMarks: Serenity.DecimalEditor;
        AttemptStatus: Serenity.EnumEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class TheoryExamResultQuestionsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExamResultQuestions';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamResultQuestionsForm.init)  {
                TheoryExamResultQuestionsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.EnumEditor;
                var w4 = s.DateEditor;
                var w5 = s.IntegerEditor;

                Q.initFormType(TheoryExamResultQuestionsForm, [
                    'TheoryExamResultId', w0,
                    'TheoryExamQuestionId', w1,
                    'MarksObtained', w2,
                    'OutOfMarks', w2,
                    'AttemptStatus', w3,
                    'InsertDate', w4,
                    'InsertUserId', w5,
                    'UpdateDate', w4,
                    'UpdateUserId', w5,
                    'IsActive', w5,
                    'TenantId', w5
                ]);
            }
        }
    }
}
