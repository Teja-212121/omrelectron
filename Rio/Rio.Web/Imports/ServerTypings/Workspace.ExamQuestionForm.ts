namespace Rio.Workspace {
    export interface ExamQuestionForm {
        ExamId: Serenity.LookupEditor;
        QuestionIndex: Serenity.IntegerEditor;
        RightOptions: Serenity.StringEditor;
        Score: Serenity.StringEditor;
        Tags: Serenity.StringEditor;
        RuleTypeId: Serenity.LookupEditor;
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
                var w2 = s.StringEditor;

                Q.initFormType(ExamQuestionForm, [
                    'ExamId', w0,
                    'QuestionIndex', w1,
                    'RightOptions', w2,
                    'Score', w2,
                    'Tags', w2,
                    'RuleTypeId', w0,
                    'ExamSectionId', w0
                ]);
            }
        }
    }
}
