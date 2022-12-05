namespace Rio.Workspace {
    export namespace ApiTheoryExamsService {
        export const baseUrl = '~/Api/Services/Workspace/TheoryExams';

        export declare function Create(request: Serenity.SaveRequest<TheoryExamsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TheoryExamsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TheoryExamsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ExamDetails(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TheoryExamsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TheoryExamsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/TheoryExams/Create",
            Update = "~/Api/Services/Workspace/TheoryExams/Update",
            Delete = "~/Api/Services/Workspace/TheoryExams/Delete",
            Retrieve = "~/Api/Services/Workspace/TheoryExams/Retrieve",
            ExamDetails = "~/Api/Services/Workspace/TheoryExams/ExamDetails",
            List = "~/Api/Services/Workspace/TheoryExams/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'ExamDetails', 
            'List'
        ].forEach(x => {
            (<any>ApiTheoryExamsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
