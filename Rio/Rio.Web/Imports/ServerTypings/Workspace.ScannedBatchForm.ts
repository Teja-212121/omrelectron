namespace Rio.Workspace {
    export interface ScannedBatchForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
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
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ScannedBatchForm, [
                    'Name', w0,
                    'Description', w0,
                    'InsertDate', w1,
                    'InsertUserId', w2,
                    'UpdateDate', w1,
                    'UpdateUserId', w2,
                    'IsActive', w2,
                    'TenantId', w2
                ]);
            }
        }
    }
}
