namespace Rio.Workspace {
    export namespace TheoryExamResultQuestionsService {
        export const baseUrl = 'Workspace/TheoryExamResultQuestions';

        export declare function Create(request: Serenity.SaveRequest<TheoryExamResultQuestionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TheoryExamResultQuestionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TheoryExamResultQuestionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TheoryExamResultQuestionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/TheoryExamResultQuestions/Create",
            Update = "Workspace/TheoryExamResultQuestions/Update",
            Delete = "Workspace/TheoryExamResultQuestions/Delete",
            Retrieve = "Workspace/TheoryExamResultQuestions/Retrieve",
            List = "Workspace/TheoryExamResultQuestions/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>TheoryExamResultQuestionsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
