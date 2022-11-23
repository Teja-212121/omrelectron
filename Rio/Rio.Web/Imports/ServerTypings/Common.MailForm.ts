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
        Priority: Serenity.IntegerEditor;
        Status: Serenity.IntegerEditor;
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
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

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
                    'RetryCount', w1,
                    'ErrorMessage', w0,
                    'LockExpiration', w2,
                    'SentDate', w2,
                    'InsertUserId', w1,
                    'InsertDate', w2,
                    'SerializedMessage', w0,
                    'AwsUserId', w0,
                    'AwsPassword', w0
                ]);
            }
        }
    }
}
