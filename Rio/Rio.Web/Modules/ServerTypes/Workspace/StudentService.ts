import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { StudentRow } from "./StudentRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace StudentService {
    export const baseUrl = 'Workspace/Student';

    export declare function Create(request: SaveRequest<StudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<StudentRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<StudentRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<StudentRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function DeleteStudent(request: string[], onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export declare const enum Methods {
        Create = "Workspace/Student/Create",
        Update = "Workspace/Student/Update",
        Delete = "Workspace/Student/Delete",
        Retrieve = "Workspace/Student/Retrieve",
        List = "Workspace/Student/List",
        DeleteStudent = "Workspace/Student/DeleteStudent"
    }

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'DeleteStudent'
    ].forEach(x => {
        (<any>StudentService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
