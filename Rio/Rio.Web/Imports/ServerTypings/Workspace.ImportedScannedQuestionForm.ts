namespace Rio.Workspace {
    export interface ImportedScannedQuestionForm {
        ScannedBatchId: Serenity.LookupEditor;
        ScannedSheetId: Serenity.LookupEditor;
        QuestionIndex: Serenity.IntegerEditor;
        ScannedOptions: Serenity.StringEditor;
        CorrectedOptions: Serenity.StringEditor;
    }

    export class ImportedScannedQuestionForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ImportedScannedQuestion';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ImportedScannedQuestionForm.init)  {
                ImportedScannedQuestionForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.StringEditor;

                Q.initFormType(ImportedScannedQuestionForm, [
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
