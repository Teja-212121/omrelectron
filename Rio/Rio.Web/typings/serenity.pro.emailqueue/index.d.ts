/// <reference types="serenity.corelib" />
/// <reference types="jquery" />
/// <reference types="jquery.validation" />
/// <reference types="jqueryui" />
declare namespace Serenity.Pro.EmailQueue {
    class EmailQueueColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.EmailQueue {
    interface EmailQueueForm {
        Uid: StringEditor;
        Subject: StringEditor;
        Body: HtmlNoteContentEditor;
        MailFrom: StringEditor;
        MailTo: StringEditor;
        ReplyTo: StringEditor;
        Cc: StringEditor;
        Bcc: StringEditor;
        Priority: EnumEditor;
        Status: EnumEditor;
        RetryCount: IntegerEditor;
        LockExpiration: DateTimeEditor;
        ErrorMessage: StringEditor;
        SentDate: DateTimeEditor;
        InsertUser: StringEditor;
        InsertDate: DateTimeEditor;
    }
    class EmailQueueForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.EmailQueue {
    enum EmailQueuePriority {
        High = 1,
        Medium = 2,
        Low = 3
    }
}
declare namespace Serenity.Pro.EmailQueue {
    interface EmailQueueRow {
        MailId?: number;
        Uid?: string;
        Subject?: string;
        Body?: string;
        SerializedMessage?: number[];
        MailFrom?: string;
        MailTo?: string;
        ReplyTo?: string;
        Cc?: string;
        Bcc?: string;
        Priority?: EmailQueuePriority;
        ErrorMessage?: string;
        Status?: EmailQueueStatus;
        RetryCount?: number;
        LockExpiration?: string;
        SentDate?: string;
        InsertUserId?: number;
        InsertDate?: string;
        InsertUser?: string;
    }
    namespace EmailQueueRow {
        const idProperty = "MailId";
        const nameProperty = "Subject";
        const localTextPrefix = "Serenity.Pro.EmailQueue.EmailQueue";
        const deletePermission = "Administration:EmailQueue";
        const insertPermission = "Administration:EmailQueue";
        const readPermission = "Administration:EmailQueue";
        const updatePermission = "Administration:EmailQueue";
        const enum Fields {
            MailId = "MailId",
            Uid = "Uid",
            Subject = "Subject",
            Body = "Body",
            SerializedMessage = "SerializedMessage",
            MailFrom = "MailFrom",
            MailTo = "MailTo",
            ReplyTo = "ReplyTo",
            Cc = "Cc",
            Bcc = "Bcc",
            Priority = "Priority",
            ErrorMessage = "ErrorMessage",
            Status = "Status",
            RetryCount = "RetryCount",
            LockExpiration = "LockExpiration",
            SentDate = "SentDate",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            InsertUser = "InsertUser"
        }
    }
}
declare namespace Serenity.Pro.EmailQueue {
    namespace EmailQueueService {
        const baseUrl = "Serenity.Pro.EmailQueue";
        function Create(request: SaveRequest<EmailQueueRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<EmailQueueRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<EmailQueueRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<EmailQueueRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Serenity.Pro.EmailQueue/Create",
            Update = "Serenity.Pro.EmailQueue/Update",
            Delete = "Serenity.Pro.EmailQueue/Delete",
            Retrieve = "Serenity.Pro.EmailQueue/Retrieve",
            List = "Serenity.Pro.EmailQueue/List"
        }
    }
}
declare namespace Serenity.Pro.EmailQueue {
    enum EmailQueueStatus {
        Failed = -1,
        InQueue = 0,
        Sent = 1
    }
}
declare namespace Serenity.Pro.EmailQueue {
    namespace PermissionKeys {
        const EmailQueue = "Administration:EmailQueue";
    }
}
declare namespace Serenity.Pro.EmailQueue {
    class EmailQueueDialog extends Serenity.EntityDialog<EmailQueueRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: EmailQueueForm;
        constructor();
    }
}
declare namespace Serenity.Pro.EmailQueue {
    class EmailQueueGrid extends Serenity.EntityGrid<EmailQueueRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof EmailQueueDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): Serenity.ToolButton[];
    }
}
