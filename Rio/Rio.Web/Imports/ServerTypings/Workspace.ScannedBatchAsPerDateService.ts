namespace Rio.Workspace {
    export namespace ScannedBatchAsPerDateService {
        export const baseUrl = 'Workspace/ScannedBatchAsPerDate';

        export declare function Create(request: Serenity.SaveRequest<ScannedBatchAsPerDateRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ScannedBatchAsPerDateRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ScannedBatchAsPerDateRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ScannedBatchAsPerDateRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/ScannedBatchAsPerDate/Create",
            Update = "Workspace/ScannedBatchAsPerDate/Update",
            Delete = "Workspace/ScannedBatchAsPerDate/Delete",
            Retrieve = "Workspace/ScannedBatchAsPerDate/Retrieve",
            List = "Workspace/ScannedBatchAsPerDate/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ScannedBatchAsPerDateService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
