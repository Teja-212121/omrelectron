namespace Rio.Workspace {
    export namespace ScannedQuestionService {
        export const baseUrl = 'Workspace/ScannedQuestion';

        export declare function Create(request: Serenity.SaveRequest<ScannedQuestionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ScannedQuestionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ScannedQuestionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ScannedQuestionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/ScannedQuestion/Create",
            Update = "Workspace/ScannedQuestion/Update",
            Delete = "Workspace/ScannedQuestion/Delete",
            Retrieve = "Workspace/ScannedQuestion/Retrieve",
            List = "Workspace/ScannedQuestion/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ScannedQuestionService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
