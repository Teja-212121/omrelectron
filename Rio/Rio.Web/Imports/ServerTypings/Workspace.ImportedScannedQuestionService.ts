namespace Rio.Workspace {
    export namespace ImportedScannedQuestionService {
        export const baseUrl = 'Workspace/ImportedScannedQuestion';

        export declare function Create(request: Serenity.SaveRequest<ImportedScannedQuestionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ImportedScannedQuestionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ImportedScannedQuestionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ImportedScannedQuestionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/ImportedScannedQuestion/Create",
            Update = "Workspace/ImportedScannedQuestion/Update",
            Delete = "Workspace/ImportedScannedQuestion/Delete",
            Retrieve = "Workspace/ImportedScannedQuestion/Retrieve",
            List = "Workspace/ImportedScannedQuestion/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ImportedScannedQuestionService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
