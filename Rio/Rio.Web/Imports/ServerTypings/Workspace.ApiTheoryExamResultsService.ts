namespace Rio.Workspace {
    export namespace ApiTheoryExamResultsService {
        export const baseUrl = '~/Api/Services/Workspace/TheoryExamResults';

        export declare function Create(request: Serenity.SaveRequest<TheoryExamResultsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TheoryExamResultsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TheoryExamResultsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TheoryExamResultsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/TheoryExamResults/Create",
            Update = "~/Api/Services/Workspace/TheoryExamResults/Update",
            Delete = "~/Api/Services/Workspace/TheoryExamResults/Delete",
            Retrieve = "~/Api/Services/Workspace/TheoryExamResults/Retrieve",
            List = "~/Api/Services/Workspace/TheoryExamResults/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ApiTheoryExamResultsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
