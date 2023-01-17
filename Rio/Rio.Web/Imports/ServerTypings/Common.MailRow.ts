namespace Rio.Common {
    export interface MailRow {
        MailId?: number;
        Uid?: string;
        Subject?: string;
        Body?: string;
        MailFrom?: string;
        MailTo?: string;
        ReplyTo?: string;
        Cc?: string;
        Bcc?: string;
        Host?: string;
        FromName?: string;
        Priority?: MailQueuePriority;
        Port?: number;
        Status?: MailStatus;
        RetryCount?: number;
        ErrorMessage?: string;
        LockExpiration?: string;
        SentDate?: string;
        InsertUserId?: number;
        InsertDate?: string;
        SerializedMessage?: number[];
        AwsUserId?: string;
        AwsPassword?: string;
        UseXOAUTH2?: boolean;
    }

    export namespace MailRow {
        export const idProperty = 'MailId';
        export const nameProperty = 'Subject';
        export const localTextPrefix = 'Common.Mail';
        export const deletePermission = 'Administration:Security';
        export const insertPermission = 'Administration:Security';
        export const readPermission = 'Administration:Security';
        export const updatePermission = 'Administration:Security';

        export declare const enum Fields {
            MailId = "MailId",
            Uid = "Uid",
            Subject = "Subject",
            Body = "Body",
            MailFrom = "MailFrom",
            MailTo = "MailTo",
            ReplyTo = "ReplyTo",
            Cc = "Cc",
            Bcc = "Bcc",
            Host = "Host",
            FromName = "FromName",
            Priority = "Priority",
            Port = "Port",
            Status = "Status",
            RetryCount = "RetryCount",
            ErrorMessage = "ErrorMessage",
            LockExpiration = "LockExpiration",
            SentDate = "SentDate",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            SerializedMessage = "SerializedMessage",
            AwsUserId = "AwsUserId",
            AwsPassword = "AwsPassword",
            UseXOAUTH2 = "UseXOAUTH2"
        }
    }
}
