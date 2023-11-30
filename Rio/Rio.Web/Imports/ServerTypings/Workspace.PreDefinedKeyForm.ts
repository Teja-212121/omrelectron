namespace Rio.Workspace {
    export interface PreDefinedKeyForm {
        SerialKey: Serenity.StringEditor;
        EStatus: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
    }

    export class PreDefinedKeyForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.PreDefinedKey';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PreDefinedKeyForm.init)  {
                PreDefinedKeyForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(PreDefinedKeyForm, [
                    'SerialKey', w0,
                    'EStatus', w1,
                    'InsertDate', w2,
                    'InsertUserId', w1,
                    'UpdateDate', w2,
                    'UpdateUserId', w1,
                    'IsActive', w1
                ]);
            }
        }
    }
}
