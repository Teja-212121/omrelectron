import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { TenantRow } from "./TenantRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace TenantService {
    export const baseUrl = 'Administration/Tenant';

    export declare function Create(request: SaveRequest<TenantRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<TenantRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<TenantRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<TenantRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ApproveTenants(request: string[], onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Administration/Tenant/Create",
        Update: "Administration/Tenant/Update",
        Delete: "Administration/Tenant/Delete",
        Retrieve: "Administration/Tenant/Retrieve",
        List: "Administration/Tenant/List",
        ApproveTenants: "Administration/Tenant/ApproveTenants"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ApproveTenants'
    ].forEach(x => {
        (<any>TenantService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
