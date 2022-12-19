namespace Rio.Membership {
    export interface PublisherSignUpForm {
        Organization: Serenity.StringEditor;
        DisplayName: Serenity.StringEditor;
        Mobile: Serenity.StringEditor;
        Email: Serenity.EmailAddressEditor;
        ConfirmEmail: Serenity.EmailAddressEditor;
        Password: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }

    export class PublisherSignUpForm extends Serenity.PrefixedContext {
        static formKey = 'Membership.SignUp';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PublisherSignUpForm.init)  {
                PublisherSignUpForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EmailAddressEditor;
                var w2 = s.PasswordEditor;

                Q.initFormType(PublisherSignUpForm, [
                    'Organization', w0,
                    'DisplayName', w0,
                    'Mobile', w0,
                    'Email', w1,
                    'ConfirmEmail', w1,
                    'Password', w2,
                    'ConfirmPassword', w2
                ]);
            }
        }
    }
}
