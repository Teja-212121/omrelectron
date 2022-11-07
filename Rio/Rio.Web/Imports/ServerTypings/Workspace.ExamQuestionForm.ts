namespace Rio.Workspace {
    export interface ExamQuestionForm {
        ExamId: Serenity.LookupEditor;
        QuestionIndex: Serenity.IntegerEditor;
        RightOptions: Serenity.IntegerEditor;
        Score: Serenity.DecimalEditor;
        Tags: Serenity.StringEditor;
        RuleTypeId: Serenity.IntegerEditor;
        ExamSectionId: Serenity.LookupEditor;
    }

    export class ExamQuestionForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamQuestion';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamQuestionForm.init)  {
                ExamQuestionForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.StringEditor;

                Q.initFormType(ExamQuestionForm, [
                    'ExamId', w0,
                    'QuestionIndex', w1,
                    'RightOptions', w1,
                    'Score', w2,
                    'Tags', w3,
                    'RuleTypeId', w1,
                    'ExamSectionId', w0
                ]);
            }
        }
    }
}
