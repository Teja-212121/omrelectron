namespace Rio.Workspace {
    export namespace ImportedScannedBatchService {
        export const baseUrl = 'Workspace/ImportedScannedBatch';

        export declare function Create(request: Serenity.SaveRequest<ImportedScannedBatchRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ImportedScannedBatchRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ImportedScannedBatchRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ImportedScannedBatchRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/ImportedScannedBatch/Create",
            Update = "Workspace/ImportedScannedBatch/Update",
            Delete = "Workspace/ImportedScannedBatch/Delete",
            Retrieve = "Workspace/ImportedScannedBatch/Retrieve",
            List = "Workspace/ImportedScannedBatch/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ImportedScannedBatchService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
