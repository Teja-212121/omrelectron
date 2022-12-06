namespace Rio.Workspace {
    export interface ScannedQuestionForm {
        ScannedBatchId: Serenity.LookupEditor;
        ScannedSheetId: Serenity.LookupEditor;
        QuestionIndex: Serenity.IntegerEditor;
        ScannedOptions: Serenity.StringEditor;
        CorrectedOptions: Serenity.StringEditor;
    }

    export class ScannedQuestionForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ScannedQuestion';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ScannedQuestionForm.init)  {
                ScannedQuestionForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.StringEditor;

                Q.initFormType(ScannedQuestionForm, [
                    'ScannedBatchId', w0,
                    'ScannedSheetId', w0,
                    'QuestionIndex', w1,
                    'ScannedOptions', w2,
                    'CorrectedOptions', w2
                ]);
            }
        }
    }
}
