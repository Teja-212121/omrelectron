namespace Rio.Workspace {
    export interface TheoryExamQuestionsForm {
        TheoryExamId: Serenity.StringEditor;
        QuestionIndex: Serenity.IntegerEditor;
        MaxMarks: Serenity.DecimalEditor;
        DisplayIndex: Serenity.StringEditor;
        Tags: Serenity.StringEditor;
        TheoryExamSectionId: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class TheoryExamQuestionsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExamQuestions';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamQuestionsForm.init)  {
                TheoryExamQuestionsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.DateEditor;

                Q.initFormType(TheoryExamQuestionsForm, [
                    'TheoryExamId', w0,
                    'QuestionIndex', w1,
                    'MaxMarks', w2,
                    'DisplayIndex', w0,
                    'Tags', w0,
                    'TheoryExamSectionId', w1,
                    'InsertDate', w3,
                    'InsertUserId', w1,
                    'UpdateDate', w3,
                    'UpdateUserId', w1,
                    'IsActive', w1,
                    'TenantId', w1
                ]);
            }
        }
    }
}
