namespace Rio.Common {
    export interface MailForm {
        Uid: Serenity.StringEditor;
        Subject: Serenity.StringEditor;
        Body: Serenity.StringEditor;
        MailFrom: Serenity.StringEditor;
        MailTo: Serenity.StringEditor;
        ReplyTo: Serenity.StringEditor;
        Cc: Serenity.StringEditor;
        Bcc: Serenity.StringEditor;
        Priority: Serenity.EnumEditor;
        Status: Serenity.EnumEditor;
        RetryCount: Serenity.IntegerEditor;
        ErrorMessage: Serenity.StringEditor;
        LockExpiration: Serenity.DateEditor;
        SentDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        SerializedMessage: Serenity.StringEditor;
        AwsUserId: Serenity.StringEditor;
        AwsPassword: Serenity.StringEditor;
    }

    export class MailForm extends Serenity.PrefixedContext {
        static formKey = 'Common.Mail';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MailForm.init)  {
                MailForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EnumEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;

                Q.initFormType(MailForm, [
                    'Uid', w0,
                    'Subject', w0,
                    'Body', w0,
                    'MailFrom', w0,
                    'MailTo', w0,
                    'ReplyTo', w0,
                    'Cc', w0,
                    'Bcc', w0,
                    'Priority', w1,
                    'Status', w1,
                    'RetryCount', w2,
                    'ErrorMessage', w0,
                    'LockExpiration', w3,
                    'SentDate', w3,
                    'InsertUserId', w2,
                    'InsertDate', w3,
                    'SerializedMessage', w0,
                    'AwsUserId', w0,
                    'AwsPassword', w0
                ]);
            }
        }
    }
}
