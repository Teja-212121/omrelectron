/// <reference types="serenity.corelib" />
/// <reference types="jquery" />
/// <reference types="jquery.validation" />
/// <reference types="jqueryui" />
/// <reference types="serenity.extensions" />
declare namespace Serenity.Pro.DataExplorer {
    interface DataExplorerConnection {
        Key?: string;
    }
}
declare namespace Serenity.Pro.DataExplorer {
    interface DataExplorerListRequest extends ListRequest {
        ConnectionKey?: string;
        TableName?: string;
    }
}
declare namespace Serenity.Pro.DataExplorer {
    interface DataExplorerListTablesRequest extends ListRequest {
        ConnectionKey?: string;
    }
}
declare namespace Serenity.Pro.DataExplorer {
    namespace DataExplorerService {
        const baseUrl = "Serenity.Pro.DataExplorer";
        function ListConnections(request: ListRequest, onSuccess?: (response: ListResponse<DataExplorerConnection>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListTables(request: DataExplorerListTablesRequest, onSuccess?: (response: ListResponse<DataExplorerTable>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListColumns(request: DataExplorerListRequest, onSuccess?: (response: ListResponse<PropertyItem>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: DataExplorerListRequest, onSuccess?: (response: ListResponse<{
            [key: string]: any;
        }>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            ListConnections = "Serenity.Pro.DataExplorer/ListConnections",
            ListTables = "Serenity.Pro.DataExplorer/ListTables",
            ListColumns = "Serenity.Pro.DataExplorer/ListColumns",
            List = "Serenity.Pro.DataExplorer/List"
        }
    }
}
declare namespace Serenity.Pro.DataExplorer {
    interface DataExplorerTable {
        Name?: string;
    }
}
declare namespace Serenity.Pro.DataExplorer {
    namespace PermissionKeys {
        const DataExplorer = "Administration:DataExplorer";
    }
}
declare namespace Serenity.Pro.DataExplorer {
    class DataConnectionEditor extends Extensions.ServiceEditorBase<Extensions.ServiceEditorOptions, DataExplorerConnection> {
        constructor(hidden: JQuery);
        getItemKey(item: DataExplorerConnection): string;
        getItemText(item: DataExplorerConnection): string;
        getService(): string;
        executeQuery(options: Serenity.ServiceOptions<Serenity.ListResponse<DataExplorerConnection>>): void;
        executeQueryByKey(options: Serenity.ServiceOptions<Serenity.RetrieveResponse<DataExplorerConnection>>): void;
    }
}
declare namespace Serenity.Pro.DataExplorer {
    class DataExplorerGrid extends Serenity.EntityGrid<any, any> {
        protected getDialogType(): any;
        protected getIdProperty(): string;
        protected getInitialTitle(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        private connection;
        private table;
        constructor(container: JQuery);
        protected getButtons(): any[];
        protected createToolbarExtensions(): void;
        protected getGridCanLoad(): boolean;
        protected onViewSubmit(): boolean;
        protected onViewProcessData(response: any): any;
    }
}
declare namespace Serenity.Pro.DataExplorer {
    class DataTableEditor extends Extensions.ServiceEditorBase<Extensions.ServiceEditorOptions, DataExplorerTable> {
        constructor(hidden: JQuery, options: Extensions.ServiceEditorOptions);
        getItemKey(item: DataExplorerTable): string;
        getItemText(item: DataExplorerTable): string;
        getService(): string;
        executeQuery(options: Serenity.ServiceOptions<Serenity.ListResponse<DataExplorerTable>>): void;
        executeQueryByKey(options: Serenity.ServiceOptions<Serenity.RetrieveResponse<DataExplorerTable>>): void;
    }
}
