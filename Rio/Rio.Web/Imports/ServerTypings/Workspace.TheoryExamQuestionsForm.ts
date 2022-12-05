namespace Rio.Workspace {
    export interface TheoryExamQuestionsForm {
        TheoryExamId: Serenity.LookupEditor;
        QuestionIndex: Serenity.IntegerEditor;
        MaxMarks: Serenity.DecimalEditor;
        DisplayIndex: Serenity.StringEditor;
        Tags: Serenity.StringEditor;
        TheoryExamSectionId: Serenity.LookupEditor;
    }

    export class TheoryExamQuestionsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExamQuestions';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamQuestionsForm.init)  {
                TheoryExamQuestionsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.StringEditor;

                Q.initFormType(TheoryExamQuestionsForm, [
                    'TheoryExamId', w0,
                    'QuestionIndex', w1,
                    'MaxMarks', w2,
                    'DisplayIndex', w3,
                    'Tags', w3,
                    'TheoryExamSectionId', w0
                ]);
            }
        }
    }
}
