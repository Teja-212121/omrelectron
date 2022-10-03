/// <reference types="serenity.corelib" />
/// <reference types="jquery" />
/// <reference types="jquery.validation" />
/// <reference types="jqueryui" />
declare namespace Serenity.Pro.Organization {
    class BusinessUnitColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Organization {
    interface BusinessUnitForm {
        Name: StringEditor;
        ParentUnitId: BusinessUnitEditor;
    }
    class BusinessUnitForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Organization {
    interface BusinessUnitRow {
        UnitId?: number;
        Name?: string;
        ParentUnitId?: number;
        ParentUnitName?: string;
        ParentUnitParentUnitId?: number;
    }
    namespace BusinessUnitRow {
        const idProperty = "UnitId";
        const nameProperty = "Name";
        const localTextPrefix = "Serenity.Pro.Organization.BusinessUnit";
        const lookupKey = "Serenity.Pro.Organization.BusinessUnit";
        function getLookup(): Q.Lookup<BusinessUnitRow>;
        const deletePermission = "Organization:BusinessUnits:Management";
        const insertPermission = "Organization:BusinessUnits:Management";
        const readPermission = "Organization:BusinessUnits:Management";
        const updatePermission = "Organization:BusinessUnits:Management";
        const enum Fields {
            UnitId = "UnitId",
            Name = "Name",
            ParentUnitId = "ParentUnitId",
            ParentUnitName = "ParentUnitName",
            ParentUnitParentUnitId = "ParentUnitParentUnitId"
        }
    }
}
declare namespace Serenity.Pro.Organization {
    namespace BusinessUnitService {
        const baseUrl = "Organization/BusinessUnit";
        function Create(request: SaveRequest<BusinessUnitRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<BusinessUnitRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BusinessUnitRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<BusinessUnitRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Organization/BusinessUnit/Create",
            Update = "Organization/BusinessUnit/Update",
            Delete = "Organization/BusinessUnit/Delete",
            Retrieve = "Organization/BusinessUnit/Retrieve",
            List = "Organization/BusinessUnit/List"
        }
    }
}
declare namespace Serenity.Pro.Organization {
    class ContactColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Organization {
    interface ContactForm {
        Title: StringEditor;
        FirstName: StringEditor;
        LastName: StringEditor;
        Email: EmailAddressEditor;
        IdentityNo: StringEditor;
        UserId: LookupEditor;
    }
    class ContactForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Organization {
    interface ContactRow {
        ContactId?: number;
        Title?: string;
        FirstName?: string;
        LastName?: string;
        FullName?: string;
        Email?: string;
        IdentityNo?: string;
        UserId?: number;
        Username?: string;
        UserDisplayName?: string;
        UserEmail?: string;
        UserImage?: string;
    }
    namespace ContactRow {
        const idProperty = "ContactId";
        const nameProperty = "FullName";
        const localTextPrefix = "Serenity.Pro.Organization.Contact";
        const lookupKey = "Serenity.Pro.Organization.Contact";
        function getLookup(): Q.Lookup<ContactRow>;
        const deletePermission = "Organization:Contacts:Management";
        const insertPermission = "Organization:Contacts:Management";
        const readPermission = "Organization:Contacts:Management";
        const updatePermission = "Organization:Contacts:Management";
        const enum Fields {
            ContactId = "ContactId",
            Title = "Title",
            FirstName = "FirstName",
            LastName = "LastName",
            FullName = "FullName",
            Email = "Email",
            IdentityNo = "IdentityNo",
            UserId = "UserId",
            Username = "Username",
            UserDisplayName = "UserDisplayName",
            UserEmail = "UserEmail",
            UserImage = "UserImage"
        }
    }
}
declare namespace Serenity.Pro.Organization {
    namespace ContactService {
        const baseUrl = "Organization/Contact";
        function Create(request: SaveRequest<ContactRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<ContactRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ContactRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<ContactRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Organization/Contact/Create",
            Update = "Organization/Contact/Update",
            Delete = "Organization/Contact/Delete",
            Retrieve = "Organization/Contact/Retrieve",
            List = "Organization/Contact/List"
        }
    }
}
declare namespace Serenity.Pro.Organization {
    namespace PermissionKeys {
        const General = "Organization:General";
    }
}
declare namespace Serenity.Pro.Organization {
    class BusinessUnitDialog extends Serenity.EntityDialog<BusinessUnitRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: BusinessUnitForm;
    }
}
declare namespace Serenity.Pro.Organization {
    class BusinessUnitEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, BusinessUnitRow> {
        constructor(hidden: JQuery, opt: Serenity.LookupEditorOptions);
        protected getLookupKey(): string;
        protected getLookup(): Q.Lookup<BusinessUnitRow>;
        protected singleRootUnitId: number;
        protected getItemText(item: BusinessUnitRow, lookup: Q.Lookup<BusinessUnitRow>): string;
    }
}
declare namespace Serenity.Pro.Organization {
    class BusinessUnitGrid extends Serenity.EntityGrid<BusinessUnitRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof BusinessUnitDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected subDialogDataChange(): void;
        protected usePager(): boolean;
        protected getColumns(): Slick.Column<any>[];
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
    }
}
declare namespace Serenity.Pro.Organization {
    class ContactDialog extends Serenity.EntityDialog<ContactRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: ContactForm;
    }
}
declare namespace Serenity.Pro.Organization {
    class ContactGrid extends Serenity.EntityGrid<ContactRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof ContactDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
