namespace Rio.Workspace {
    export interface ScannedBatchForm {
        Id: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
    }

    export class ScannedBatchForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ScannedBatch';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ScannedBatchForm.init)  {
                ScannedBatchForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;

                Q.initFormType(ScannedBatchForm, [
                    'Id', w0,
                    'Name', w0,
                    'Description', w1
                ]);
            }
        }
    }
}
