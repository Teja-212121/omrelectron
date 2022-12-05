namespace Rio.Workspace {
    export namespace ApiTheoryExamQuestionsService {
        export const baseUrl = '~/Api/Services/Workspace/TheoryExamQuestions';

        export declare function Create(request: Serenity.SaveRequest<TheoryExamQuestionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TheoryExamQuestionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TheoryExamQuestionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TheoryExamQuestionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/TheoryExamQuestions/Create",
            Update = "~/Api/Services/Workspace/TheoryExamQuestions/Update",
            Delete = "~/Api/Services/Workspace/TheoryExamQuestions/Delete",
            Retrieve = "~/Api/Services/Workspace/TheoryExamQuestions/Retrieve",
            List = "~/Api/Services/Workspace/TheoryExamQuestions/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ApiTheoryExamQuestionsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
