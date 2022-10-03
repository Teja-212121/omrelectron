namespace Rio.Administration {
    export interface UserForm {
        Username: Serenity.StringEditor;
        DisplayName: Serenity.StringEditor;
        Email: Serenity.EmailAddressEditor;
        Roles: Serenity.LookupEditor;
        MobilePhoneNumber: Serenity.StringEditor;
        MobilePhoneVerified: Serenity.BooleanEditor;
        TwoFactorAuth: Serenity.EnumEditor;
        UserImage: Serenity.ImageUploadEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
        Source: Serenity.StringEditor;
    }

    export class UserForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.User';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserForm.init)  {
                UserForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EmailAddressEditor;
                var w2 = s.LookupEditor;
                var w3 = s.BooleanEditor;
                var w4 = s.EnumEditor;
                var w5 = s.ImageUploadEditor;
                var w6 = s.PasswordEditor;

                Q.initFormType(UserForm, [
                    'Username', w0,
                    'DisplayName', w0,
                    'Email', w1,
                    'Roles', w2,
                    'MobilePhoneNumber', w0,
                    'MobilePhoneVerified', w3,
                    'TwoFactorAuth', w4,
                    'UserImage', w5,
                    'Password', w6,
                    'PasswordConfirm', w6,
                    'Source', w0
                ]);
            }
        }
    }
}
