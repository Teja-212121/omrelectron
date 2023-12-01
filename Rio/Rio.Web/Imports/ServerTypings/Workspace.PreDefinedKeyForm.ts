namespace Rio.Workspace {
    export interface PreDefinedKeyForm {
        SerialKey: Serenity.StringEditor;
        EStatus: Serenity.EnumEditor;
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
                var w1 = s.EnumEditor;

                Q.initFormType(PreDefinedKeyForm, [
                    'SerialKey', w0,
                    'EStatus', w1
                ]);
            }
        }
    }
}
