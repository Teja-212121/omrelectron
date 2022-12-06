namespace Rio.Workspace {
    export namespace ApiTheoryExamResultQuestionsService {
        export const baseUrl = '~/Api/Services/Workspace/TheoryExamResultQuestions';

        export declare function Create(request: Serenity.SaveRequest<TheoryExamResultQuestionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TheoryExamResultQuestionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function BulkInsertQuestions(request: Serenity.SaveRequest<TheoryExamResultQuestionsRow[]>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TheoryExamResultQuestionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TheoryExamResultQuestionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/TheoryExamResultQuestions/Create",
            Update = "~/Api/Services/Workspace/TheoryExamResultQuestions/Update",
            BulkInsertQuestions = "~/Api/Services/Workspace/TheoryExamResultQuestions/BulkInsertQuestions",
            Delete = "~/Api/Services/Workspace/TheoryExamResultQuestions/Delete",
            Retrieve = "~/Api/Services/Workspace/TheoryExamResultQuestions/Retrieve",
            List = "~/Api/Services/Workspace/TheoryExamResultQuestions/List"
        }

        [
            'Create', 
            'Update', 
            'BulkInsertQuestions', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ApiTheoryExamResultQuestionsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
