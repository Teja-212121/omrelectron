import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { ExamSectionRow } from "./ExamSectionRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace ExamSectionService {
    export const baseUrl = 'Workspace/ExamSection';

    export declare function Create(request: SaveRequest<ExamSectionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<ExamSectionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExamSectionRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExamSectionRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function DeleteExamSection(request: string[], onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export declare const enum Methods {
        Create = "Workspace/ExamSection/Create",
        Update = "Workspace/ExamSection/Update",
        Delete = "Workspace/ExamSection/Delete",
        Retrieve = "Workspace/ExamSection/Retrieve",
        List = "Workspace/ExamSection/List",
        DeleteExamSection = "Workspace/ExamSection/DeleteExamSection"
    }

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'DeleteExamSection'
    ].forEach(x => {
        (<any>ExamSectionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
