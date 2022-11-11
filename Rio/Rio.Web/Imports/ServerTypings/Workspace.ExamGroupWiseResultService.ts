namespace Rio.Workspace {
    export namespace ExamGroupWiseResultService {
        export const baseUrl = 'Workspace/ExamGroupWiseResult';

        export declare function Create(request: Serenity.SaveRequest<ExamGroupWiseResultRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ExamGroupWiseResultRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ExamGroupWiseResultRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ExamGroupWiseResultRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/ExamGroupWiseResult/Create",
            Update = "Workspace/ExamGroupWiseResult/Update",
            Delete = "Workspace/ExamGroupWiseResult/Delete",
            Retrieve = "Workspace/ExamGroupWiseResult/Retrieve",
            List = "Workspace/ExamGroupWiseResult/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ExamGroupWiseResultService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
