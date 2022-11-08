namespace Rio.Workspace {
    export interface ImportedScannedBatchForm {
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
    }

    export class ImportedScannedBatchForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ImportedScannedBatch';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ImportedScannedBatchForm.init)  {
                ImportedScannedBatchForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;

                Q.initFormType(ImportedScannedBatchForm, [
                    'Name', w0,
                    'Description', w1
                ]);
            }
        }
    }
}
