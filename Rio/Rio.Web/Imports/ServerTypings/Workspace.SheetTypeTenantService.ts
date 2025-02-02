﻿namespace Rio.Workspace {
    export namespace SheetTypeTenantService {
        export const baseUrl = 'Workspace/SheetTypeTenant';

        export declare function Create(request: Serenity.SaveRequest<SheetTypeTenantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<SheetTypeTenantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SheetTypeTenantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SheetTypeTenantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function DeleteSheetTypeTenant(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Assign(request: Serenity.SaveRequest<SheetTypeTenantRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function UpdateSheetTypeTenants(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/SheetTypeTenant/Create",
            Update = "Workspace/SheetTypeTenant/Update",
            Delete = "Workspace/SheetTypeTenant/Delete",
            Retrieve = "Workspace/SheetTypeTenant/Retrieve",
            List = "Workspace/SheetTypeTenant/List",
            DeleteSheetTypeTenant = "Workspace/SheetTypeTenant/DeleteSheetTypeTenant",
            Assign = "Workspace/SheetTypeTenant/Assign",
            UpdateSheetTypeTenants = "Workspace/SheetTypeTenant/UpdateSheetTypeTenants"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'DeleteSheetTypeTenant', 
            'Assign', 
            'UpdateSheetTypeTenants'
        ].forEach(x => {
            (<any>SheetTypeTenantService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
