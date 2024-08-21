namespace Rio.Workspace {
    export interface CloudStorageProviderForm {
        Id: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        NumberOfParameter: Serenity.IntegerEditor;
        TenantId: Serenity.LookupEditor;
        Parameter1Title: Serenity.StringEditor;
        Parameter2Title: Serenity.StringEditor;
        Parameter3Title: Serenity.StringEditor;
        Parameter4Title: Serenity.StringEditor;
        Parameter5Title: Serenity.StringEditor;
        Parameter6Title: Serenity.StringEditor;
        Parameter7Title: Serenity.StringEditor;
        Parameter8Title: Serenity.StringEditor;
        Parameter9Title: Serenity.StringEditor;
        Parameter10Title: Serenity.StringEditor;
        ParameterProvider: Serenity.StringEditor;
    }

    export class CloudStorageProviderForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.CloudStorageProvider';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CloudStorageProviderForm.init)  {
                CloudStorageProviderForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.LookupEditor;

                Q.initFormType(CloudStorageProviderForm, [
                    'Id', w0,
                    'Name', w0,
                    'Description', w1,
                    'NumberOfParameter', w2,
                    'TenantId', w3,
                    'Parameter1Title', w0,
                    'Parameter2Title', w0,
                    'Parameter3Title', w0,
                    'Parameter4Title', w0,
                    'Parameter5Title', w0,
                    'Parameter6Title', w0,
                    'Parameter7Title', w0,
                    'Parameter8Title', w0,
                    'Parameter9Title', w0,
                    'Parameter10Title', w0,
                    'ParameterProvider', w0
                ]);
            }
        }
    }
}
