namespace Rio.Workspace {
    export interface SettingsForm {
        Host: Serenity.StringEditor;
        Port: Serenity.IntegerEditor;
        UseSsl: Serenity.IntegerEditor;
        From: Serenity.StringEditor;
        UserName: Serenity.StringEditor;
        Password: Serenity.StringEditor;
        ApiKey: Serenity.StringEditor;
        Sender: Serenity.StringEditor;
        GatewayUrl: Serenity.StringEditor;
    }

    export class SettingsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.Settings';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SettingsForm.init)  {
                SettingsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(SettingsForm, [
                    'Host', w0,
                    'Port', w1,
                    'UseSsl', w1,
                    'From', w0,
                    'UserName', w0,
                    'Password', w0,
                    'ApiKey', w0,
                    'Sender', w0,
                    'GatewayUrl', w0
                ]);
            }
        }
    }
}
