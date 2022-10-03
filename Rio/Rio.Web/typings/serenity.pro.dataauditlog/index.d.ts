/// <reference types="serenity.corelib" />
/// <reference types="jquery" />
/// <reference types="jquery.validation" />
/// <reference types="jqueryui" />
declare namespace Serenity.Pro.DataAuditLog {
    class DataAuditLogColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.DataAuditLog {
    interface DataAuditLogForm {
        LogType: EnumEditor;
        LogDate: DateTimeEditor;
        UserId: IntegerEditor;
        Tablename: LookupEditor;
        RecordId: StringEditor;
        FieldName: LookupEditor;
        OldValue: StringEditor;
        NewValue: StringEditor;
    }
    class DataAuditLogForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.DataAuditLog {
    interface DataAuditLogRow {
        LogId?: number;
        LogType?: DataAuditLogType;
        LogDate?: string;
        UserId?: number;
        Tablename?: string;
        RecordId?: string;
        FieldName?: string;
        OldValue?: string;
        NewValue?: string;
        Username?: string;
        UserDisplayName?: string;
    }
    namespace DataAuditLogRow {
        const idProperty = "LogId";
        const localTextPrefix = "Serenity.Pro.DataAuditLog.DataAuditLog";
        const deletePermission = "Administration:DataAuditLog";
        const insertPermission = "Administration:DataAuditLog";
        const readPermission = "Administration:DataAuditLog";
        const updatePermission = "Administration:DataAuditLog";
        const enum Fields {
            LogId = "LogId",
            LogType = "LogType",
            LogDate = "LogDate",
            UserId = "UserId",
            Tablename = "Tablename",
            RecordId = "RecordId",
            FieldName = "FieldName",
            OldValue = "OldValue",
            NewValue = "NewValue",
            Username = "Username",
            UserDisplayName = "UserDisplayName"
        }
    }
}
declare namespace Serenity.Pro.DataAuditLog {
    namespace DataAuditLogService {
        const baseUrl = "Serenity.Pro.DataAuditLog";
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DataAuditLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<DataAuditLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Retrieve = "Serenity.Pro.DataAuditLog/Retrieve",
            List = "Serenity.Pro.DataAuditLog/List"
        }
    }
}
declare namespace Serenity.Pro.DataAuditLog {
    enum DataAuditLogType {
        Insert = 1,
        Update = 2,
        Delete = 3
    }
}
declare namespace Serenity.Pro.DataAuditLog {
    namespace PermissionKeys {
        const DataAuditLog = "Administration:DataAuditLog";
    }
}
declare namespace Serenity.Pro.DataAuditLog {
    class DataAuditLogDialog extends Serenity.EntityDialog<DataAuditLogRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getNameProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: DataAuditLogForm;
        protected getToolbarButtons(): any[];
        protected updateInterface(): void;
    }
}
declare namespace Serenity.Pro.DataAuditLog {
    class DataAuditLogGrid extends Serenity.EntityGrid<DataAuditLogRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof DataAuditLogDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected getButtons(): any[];
        protected getColumns(): Slick.Column<any>[];
    }
}
