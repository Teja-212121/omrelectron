import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { GroupStudentRow } from "./GroupStudentRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace GroupStudentService {
    export const baseUrl = 'Workspace/GroupStudent';

    export declare function Create(request: SaveRequest<GroupStudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<GroupStudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<GroupStudentRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<GroupStudentRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Workspace/GroupStudent/Create",
        Update: "Workspace/GroupStudent/Update",
        Delete: "Workspace/GroupStudent/Delete",
        Retrieve: "Workspace/GroupStudent/Retrieve",
        List: "Workspace/GroupStudent/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>GroupStudentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
