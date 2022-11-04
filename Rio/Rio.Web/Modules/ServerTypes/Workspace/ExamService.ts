import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { ExamRow } from "./ExamRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace ExamService {
    export const baseUrl = 'Workspace/Exam';

    export declare function Create(request: SaveRequest<ExamRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<ExamRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExamRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExamRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export declare const enum Methods {
        Create = "Workspace/Exam/Create",
        Update = "Workspace/Exam/Update",
        Delete = "Workspace/Exam/Delete",
        Retrieve = "Workspace/Exam/Retrieve",
        List = "Workspace/Exam/List"
    }

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ExamService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
