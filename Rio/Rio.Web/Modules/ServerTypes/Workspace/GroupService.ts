import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { GroupRow } from "./GroupRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace GroupService {
    export const baseUrl = 'Workspace/Group';

    export declare function Create(request: SaveRequest<GroupRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<GroupRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<GroupRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<GroupRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function DeleteGroup(request: string[], onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export declare const enum Methods {
        Create = "Workspace/Group/Create",
        Update = "Workspace/Group/Update",
        Delete = "Workspace/Group/Delete",
        Retrieve = "Workspace/Group/Retrieve",
        List = "Workspace/Group/List",
        DeleteGroup = "Workspace/Group/DeleteGroup"
    }

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'DeleteGroup'
    ].forEach(x => {
        (<any>GroupService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
