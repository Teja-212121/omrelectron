/// <reference types="serenity.corelib" />
/// <reference types="jquery" />
/// <reference types="jquery.validation" />
/// <reference types="jqueryui" />
/// <reference types="serenity.pro.extensions" />
declare namespace Serenity.Pro.WorkLog {
    class CurrencyColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface CurrencyForm {
        CurrencyCode: StringEditor;
    }
    class CurrencyForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface CurrencyRow {
        CurrencyCode?: string;
    }
    namespace CurrencyRow {
        const idProperty = "CurrencyCode";
        const nameProperty = "CurrencyCode";
        const localTextPrefix = "WorkLog.Currency";
        const lookupKey = "WorkLog.Currency";
        function getLookup(): Q.Lookup<CurrencyRow>;
        const deletePermission = "WorkLog:Management";
        const insertPermission = "WorkLog:Management";
        const readPermission = "WorkLog:Lookups";
        const updatePermission = "WorkLog:Management";
        const enum Fields {
            CurrencyCode = "CurrencyCode"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    namespace CurrencyService {
        const baseUrl = "WorkLog/Currency";
        function Create(request: SaveRequest<CurrencyRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<CurrencyRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CurrencyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<CurrencyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "WorkLog/Currency/Create",
            Update = "WorkLog/Currency/Update",
            Delete = "WorkLog/Currency/Delete",
            Retrieve = "WorkLog/Currency/Retrieve",
            List = "WorkLog/Currency/List"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    class CustomerColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface CustomerForm {
        UserId: ServiceLookupEditor;
        Name: StringEditor;
        HourlyRate: DecimalEditor;
        CurrencyCode: ServiceLookupEditor;
    }
    class CustomerForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface CustomerRow {
        CustomerId?: number;
        UserId?: number;
        Name?: string;
        HourlyRate?: number;
        CurrencyCode?: string;
        Username?: string;
        UserDisplayName?: string;
    }
    namespace CustomerRow {
        const idProperty = "CustomerId";
        const nameProperty = "Name";
        const localTextPrefix = "Default.Customer";
        const lookupKey = "WorkLog.Customer";
        function getLookup(): Q.Lookup<CustomerRow>;
        const deletePermission = "WorkLog:Management";
        const insertPermission = "WorkLog:Management";
        const readPermission = "WorkLog:Lookups";
        const updatePermission = "WorkLog:Management";
        const enum Fields {
            CustomerId = "CustomerId",
            UserId = "UserId",
            Name = "Name",
            HourlyRate = "HourlyRate",
            CurrencyCode = "CurrencyCode",
            Username = "Username",
            UserDisplayName = "UserDisplayName"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    namespace CustomerService {
        const baseUrl = "Default/Customer";
        function Create(request: SaveRequest<CustomerRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<CustomerRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CustomerRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<CustomerRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Default/Customer/Create",
            Update = "Default/Customer/Update",
            Delete = "Default/Customer/Delete",
            Retrieve = "Default/Customer/Retrieve",
            List = "Default/Customer/List"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    class EmployeeColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface EmployeeForm {
        UserId: ServiceLookupEditor;
        Name: StringEditor;
    }
    class EmployeeForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.WorkLog {
    class EmployeePricingColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface EmployeePricingForm {
        EmployeeId: ServiceLookupEditor;
        CustomerId: ServiceLookupEditor;
        ProjectId: ServiceLookupEditor;
        HourlyRate: DecimalEditor;
        CurrencyCode: ServiceLookupEditor;
    }
    class EmployeePricingForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface EmployeePricingRow {
        EmployeePricingId?: number;
        EmployeeId?: number;
        CustomerId?: number;
        ProjectId?: number;
        HourlyRate?: number;
        CurrencyCode?: string;
        EmployeeUserId?: number;
        EmployeeName?: string;
        CustomerUserId?: number;
        CustomerName?: string;
        CustomerHourlyRate?: number;
        CustomerCurrencyCode?: string;
        ProjectCustomerId?: number;
        ProjectName?: string;
        ProjectEndCustomer?: string;
        ProjectHourlyRate?: number;
        ProjectCurrencyCode?: string;
    }
    namespace EmployeePricingRow {
        const idProperty = "EmployeePricingId";
        const localTextPrefix = "WorkLog.EmployeePricing";
        const deletePermission = "WorkLog:Management";
        const insertPermission = "WorkLog:Management";
        const readPermission = "WorkLog:Pricing";
        const updatePermission = "WorkLog:Management";
        const enum Fields {
            EmployeePricingId = "EmployeePricingId",
            EmployeeId = "EmployeeId",
            CustomerId = "CustomerId",
            ProjectId = "ProjectId",
            HourlyRate = "HourlyRate",
            CurrencyCode = "CurrencyCode",
            EmployeeUserId = "EmployeeUserId",
            EmployeeName = "EmployeeName",
            CustomerUserId = "CustomerUserId",
            CustomerName = "CustomerName",
            CustomerHourlyRate = "CustomerHourlyRate",
            CustomerCurrencyCode = "CustomerCurrencyCode",
            ProjectCustomerId = "ProjectCustomerId",
            ProjectName = "ProjectName",
            ProjectEndCustomer = "ProjectEndCustomer",
            ProjectHourlyRate = "ProjectHourlyRate",
            ProjectCurrencyCode = "ProjectCurrencyCode"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    namespace EmployeePricingService {
        const baseUrl = "WorkLog/EmployeePricing";
        function Create(request: SaveRequest<EmployeePricingRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<EmployeePricingRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<EmployeePricingRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<EmployeePricingRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "WorkLog/EmployeePricing/Create",
            Update = "WorkLog/EmployeePricing/Update",
            Delete = "WorkLog/EmployeePricing/Delete",
            Retrieve = "WorkLog/EmployeePricing/Retrieve",
            List = "WorkLog/EmployeePricing/List"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface EmployeeRow {
        EmployeeId?: number;
        UserId?: number;
        Name?: string;
        Username?: string;
        UserDisplayName?: string;
    }
    namespace EmployeeRow {
        const idProperty = "EmployeeId";
        const nameProperty = "Name";
        const localTextPrefix = "WorkLog.Employee";
        const lookupKey = "WorkLog.Employee";
        function getLookup(): Q.Lookup<EmployeeRow>;
        const deletePermission = "WorkLog:Management";
        const insertPermission = "WorkLog:Management";
        const readPermission = "WorkLog:Lookups";
        const updatePermission = "WorkLog:Management";
        const enum Fields {
            EmployeeId = "EmployeeId",
            UserId = "UserId",
            Name = "Name",
            Username = "Username",
            UserDisplayName = "UserDisplayName"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    namespace EmployeeService {
        const baseUrl = "WorkLog/Employee";
        function Create(request: SaveRequest<EmployeeRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<EmployeeRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<EmployeeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<EmployeeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "WorkLog/Employee/Create",
            Update = "WorkLog/Employee/Update",
            Delete = "WorkLog/Employee/Delete",
            Retrieve = "WorkLog/Employee/Retrieve",
            List = "WorkLog/Employee/List"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    class InvoiceColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface InvoiceForm {
        CustomerId: ServiceLookupEditor;
        InvoiceNo: StringEditor;
        Date: DateEditor;
        Amount: DecimalEditor;
        CurrencyCode: LookupEditor;
        Notes: StringEditor;
        WorkLogs: InvoiceWorkLogGrid;
    }
    class InvoiceForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface InvoiceRow {
        InvoiceId?: number;
        CustomerId?: number;
        InvoiceNo?: string;
        Date?: string;
        Amount?: number;
        CurrencyCode?: string;
        Notes?: string;
        CustomerUserId?: number;
        CustomerName?: string;
        CustomerHourlyRate?: number;
        CustomerCurrencyCode?: string;
    }
    namespace InvoiceRow {
        const idProperty = "InvoiceId";
        const nameProperty = "InvoiceNo";
        const localTextPrefix = "WorkLog.Invoice";
        const lookupKey = "WorkLog.Invoice";
        function getLookup(): Q.Lookup<InvoiceRow>;
        const deletePermission = "WorkLog:Management";
        const insertPermission = "WorkLog:Management";
        const readPermission = "WorkLog:Pricing";
        const updatePermission = "WorkLog:Management";
        const enum Fields {
            InvoiceId = "InvoiceId",
            CustomerId = "CustomerId",
            InvoiceNo = "InvoiceNo",
            Date = "Date",
            Amount = "Amount",
            CurrencyCode = "CurrencyCode",
            Notes = "Notes",
            CustomerUserId = "CustomerUserId",
            CustomerName = "CustomerName",
            CustomerHourlyRate = "CustomerHourlyRate",
            CustomerCurrencyCode = "CustomerCurrencyCode"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    namespace InvoiceService {
        const baseUrl = "WorkLog/Invoice";
        function Create(request: SaveRequest<InvoiceRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<InvoiceRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<InvoiceRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<InvoiceRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "WorkLog/Invoice/Create",
            Update = "WorkLog/Invoice/Update",
            Delete = "WorkLog/Invoice/Delete",
            Retrieve = "WorkLog/Invoice/Retrieve",
            List = "WorkLog/Invoice/List"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    namespace PermissionKeys {
        const Lookups = "WorkLog:Lookups";
        const Commercial = "WorkLog:Commercial";
        const Customer = "WorkLog:Customer";
        const Management = "WorkLog:Management";
        const Employee = "WorkLog:Employee";
        const Pricing = "WorkLog:Pricing";
        const ManagementOrCustomer = "WorkLog:Management|WorkLog:Customer";
    }
}
declare namespace Serenity.Pro.WorkLog {
    class ProjectColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface ProjectForm {
        CustomerId: ServiceLookupEditor;
        Name: StringEditor;
        EndCustomer: StringEditor;
        HourlyRate: DecimalEditor;
        CurrencyCode: LookupEditor;
    }
    class ProjectForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface ProjectRow {
        ProjectId?: number;
        CustomerId?: number;
        Name?: string;
        EndCustomer?: string;
        HourlyRate?: number;
        CurrencyCode?: string;
        CustomerName?: string;
        CustomerHourlyRate?: number;
        CustomerCurrencyCode?: string;
    }
    namespace ProjectRow {
        const idProperty = "ProjectId";
        const nameProperty = "Name";
        const localTextPrefix = "WorkLog.Project";
        const lookupKey = "WorkLog.Project";
        function getLookup(): Q.Lookup<ProjectRow>;
        const deletePermission = "WorkLog:Employee";
        const insertPermission = "WorkLog:Employee";
        const readPermission = "WorkLog:Lookups";
        const updatePermission = "WorkLog:Employee";
        const enum Fields {
            ProjectId = "ProjectId",
            CustomerId = "CustomerId",
            Name = "Name",
            EndCustomer = "EndCustomer",
            HourlyRate = "HourlyRate",
            CurrencyCode = "CurrencyCode",
            CustomerName = "CustomerName",
            CustomerHourlyRate = "CustomerHourlyRate",
            CustomerCurrencyCode = "CustomerCurrencyCode"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    namespace ProjectService {
        const baseUrl = "WorkLog/Project";
        function Create(request: SaveRequest<ProjectRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<ProjectRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProjectRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<ProjectRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "WorkLog/Project/Create",
            Update = "WorkLog/Project/Update",
            Delete = "WorkLog/Project/Delete",
            Retrieve = "WorkLog/Project/Retrieve",
            List = "WorkLog/Project/List"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    class WorkLogColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface WorkLogForm {
        ProjectId: LookupEditor;
        EmployeeId: ServiceLookupEditor;
        Tasks: LookupEditor;
        Description: StringEditor;
        StartDate: DateTimeEditor;
        EndDate: DateTimeEditor;
        TimeSpent: IntegerEditor;
    }
    class WorkLogForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface WorkLogIdRequest extends ServiceRequest {
        EntityId?: number;
    }
}
declare namespace Serenity.Pro.WorkLog {
    enum WorkLogInvoiceState {
        NotAssigned = 0,
        Assigned = 1
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface WorkLogRow {
        WorkLogId?: number;
        ProjectId?: number;
        EmployeeId?: number;
        Tasks?: string;
        Description?: string;
        Year?: number;
        Month?: number;
        StartDate?: string;
        EndDate?: string;
        TimeSpent?: number;
        CurrencyCode?: string;
        Price?: number;
        Hours?: number;
        Amount?: number;
        InvoiceId?: number;
        ProjectCustomerId?: number;
        ProjectCustomerUserId?: number;
        ProjectName?: string;
        ProjectEndCustomer?: string;
        ProjectHourlyRate?: number;
        EmployeeUserId?: number;
        EmployeeName?: string;
        InvoiceNo?: string;
        InvoiceDate?: string;
        InvoiceState?: WorkLogInvoiceState;
    }
    namespace WorkLogRow {
        const idProperty = "WorkLogId";
        const nameProperty = "Tasks";
        const localTextPrefix = "WorkLog.WorkLog";
        const deletePermission = "WorkLog:Employee";
        const insertPermission = "WorkLog:Employee";
        const readPermission = "WorkLog:Employee";
        const updatePermission = "WorkLog:Employee";
        const enum Fields {
            WorkLogId = "WorkLogId",
            ProjectId = "ProjectId",
            EmployeeId = "EmployeeId",
            Tasks = "Tasks",
            Description = "Description",
            Year = "Year",
            Month = "Month",
            StartDate = "StartDate",
            EndDate = "EndDate",
            TimeSpent = "TimeSpent",
            CurrencyCode = "CurrencyCode",
            Price = "Price",
            Hours = "Hours",
            Amount = "Amount",
            InvoiceId = "InvoiceId",
            ProjectCustomerId = "ProjectCustomerId",
            ProjectCustomerUserId = "ProjectCustomerUserId",
            ProjectName = "ProjectName",
            ProjectEndCustomer = "ProjectEndCustomer",
            ProjectHourlyRate = "ProjectHourlyRate",
            EmployeeUserId = "EmployeeUserId",
            EmployeeName = "EmployeeName",
            InvoiceNo = "InvoiceNo",
            InvoiceDate = "InvoiceDate",
            InvoiceState = "InvoiceState"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    namespace WorkLogService {
        const baseUrl = "WorkLog/WorkLog";
        function Create(request: SaveRequest<WorkLogRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<WorkLogRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<WorkLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<WorkLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function FinishTask(request: WorkLogIdRequest, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function StartTask(request: WorkLogIdRequest, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function RecalculatePrice(request: WorklogRecalculatePriceRequest, onSuccess?: (response: ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function AssignToInvoice(request: WorklogAssignToInvoiceRequest, onSuccess?: (response: ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "WorkLog/WorkLog/Create",
            Update = "WorkLog/WorkLog/Update",
            Delete = "WorkLog/WorkLog/Delete",
            Retrieve = "WorkLog/WorkLog/Retrieve",
            List = "WorkLog/WorkLog/List",
            FinishTask = "WorkLog/WorkLog/FinishTask",
            StartTask = "WorkLog/WorkLog/StartTask",
            RecalculatePrice = "WorkLog/WorkLog/RecalculatePrice",
            AssignToInvoice = "WorkLog/WorkLog/AssignToInvoice"
        }
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface WorklogAssignToInvoiceRequest extends ServiceRequest {
        InvoiceId?: number;
        EntityIds?: number[];
    }
}
declare namespace Serenity.Pro.WorkLog {
    interface WorklogRecalculatePriceRequest extends ServiceRequest {
        EntityIds?: number[];
    }
}
declare namespace Serenity.Pro.WorkLog {
    class CurrencyDialog extends Serenity.EntityDialog<CurrencyRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: CurrencyForm;
    }
}
declare namespace Serenity.Pro.WorkLog {
    class CurrencyGrid extends Serenity.EntityGrid<CurrencyRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CurrencyDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.WorkLog {
    class CustomerDialog extends Serenity.EntityDialog<CustomerRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: CustomerForm;
    }
}
declare namespace Serenity.Pro.WorkLog {
    class CustomerGrid extends Serenity.EntityGrid<CustomerRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof CustomerDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.WorkLog {
    class EmployeeDialog extends Serenity.EntityDialog<EmployeeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: EmployeeForm;
    }
}
declare namespace Serenity.Pro.WorkLog {
    class EmployeeGrid extends Serenity.EntityGrid<EmployeeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof EmployeeDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.WorkLog {
    class EmployeePricingDialog extends Serenity.EntityDialog<EmployeePricingRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: EmployeePricingForm;
        constructor();
        protected loadEntity(entity: EmployeePricingRow): void;
    }
}
declare namespace Serenity.Pro.WorkLog {
    class EmployeePricingGrid extends Serenity.EntityGrid<EmployeePricingRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof EmployeePricingDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.WorkLog {
    class InvoiceDialog extends Serenity.EntityDialog<InvoiceRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: InvoiceForm;
        constructor();
        private updateCurrencyWithCustomerId;
        protected afterLoadEntity(): void;
        protected arrange(): void;
    }
}
declare namespace Serenity.Pro.WorkLog {
    class InvoiceGrid extends Serenity.EntityGrid<InvoiceRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof InvoiceDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected createSlickGrid(): Slick.Grid<any>;
        protected getSlickOptions(): Slick.GridOptions<any>;
    }
}
declare namespace Serenity.Pro.WorkLog {
    class WorkLogBaseGrid extends Serenity.EntityGrid<WorkLogRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof WorkLogDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected rowSelection: Serenity.GridRowSelectionMixin;
        constructor(container: JQuery);
        protected getSlickOptions(): Slick.GridOptions<any>;
        protected showAddButton(): boolean;
        protected addButtonClick(): void;
        protected getViewOptions(): RemoteViewOptions;
        protected getColumns(): Slick.Column<any>[];
        protected getButtons(): ToolButton[];
        protected findCurrentEmployeeId(): any;
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
    }
}
declare namespace Serenity.Pro.WorkLog {
    class InvoiceWorkLogGrid extends WorkLogBaseGrid {
        constructor(container: JQuery);
        protected getColumns(): Slick.Column[];
        protected getButtons(): ToolButton[];
        protected addButtonClick(): void;
        protected getInitialTitle(): any;
        protected getGridCanLoad(): boolean;
        protected usePager(): boolean;
        protected getQuickFilters(): any[];
        private _invoiceId;
        get invoiceId(): number;
        set invoiceId(value: number);
    }
}
declare namespace Serenity.Pro.WorkLog {
    class ProjectDialog extends Serenity.EntityDialog<ProjectRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: ProjectForm;
        constructor();
    }
}
declare namespace Serenity.Pro.WorkLog {
    class ProjectGrid extends Serenity.EntityGrid<ProjectRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ProjectDialog;
        protected getIdProperty(): string;
        protected getInsertPermission(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.WorkLog {
    class WorkLogDialog extends Serenity.EntityDialog<WorkLogRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected getDeletePermission(): string;
        protected getInsertPermission(): string;
        protected getUpdatePermission(): string;
        protected form: WorkLogForm;
        protected afterLoadEntity(): void;
        findCurrentEmployeeId(): any;
        constructor();
        protected getStartDate(milliseconds?: number): Date;
        protected getEndDate(milliseconds?: number): Date;
        protected onDateChanged(): void;
    }
}
declare namespace Serenity.Pro.WorkLog {
    class WorkLogGrid extends WorkLogBaseGrid {
        constructor(container: JQuery);
        protected getColumns(): Slick.Column<any>[];
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
        protected getQuickFilters(): QuickFilter<Widget<any>, any>[];
        protected showAddButton(): boolean;
        protected getButtons(): ToolButton[];
    }
}
