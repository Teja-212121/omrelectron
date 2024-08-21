namespace Rio.Workspace {
    export interface CloudStorageSettingForm {
        CloudStorageProvidersId: Serenity.LookupEditor;
        TenantId: Serenity.LookupEditor;
        Parameter1: Serenity.StringEditor;
        Parameter2: Serenity.StringEditor;
        Parameter3: Serenity.StringEditor;
        Parameter4: Serenity.StringEditor;
        Parameter5: Serenity.StringEditor;
        Parameter6: Serenity.StringEditor;
        Parameter7: Serenity.StringEditor;
        Parameter8: Serenity.StringEditor;
        Parameter9: Serenity.StringEditor;
        Parameter10: Serenity.StringEditor;
        ParameterProvider: Serenity.StringEditor;
    }

    export class CloudStorageSettingForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.CloudStorageSetting';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CloudStorageSettingForm.init)  {
                CloudStorageSettingForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(CloudStorageSettingForm, [
                    'CloudStorageProvidersId', w0,
                    'TenantId', w0,
                    'Parameter1', w1,
                    'Parameter2', w1,
                    'Parameter3', w1,
                    'Parameter4', w1,
                    'Parameter5', w1,
                    'Parameter6', w1,
                    'Parameter7', w1,
                    'Parameter8', w1,
                    'Parameter9', w1,
                    'Parameter10', w1,
                    'ParameterProvider', w1
                ]);
            }
        }
    }
}
