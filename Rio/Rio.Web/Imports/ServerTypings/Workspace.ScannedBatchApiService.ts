namespace Rio.Workspace {
    export namespace ScannedBatchApiService {
        export const baseUrl = '~/Api/Services/Workspace/ScannedBatch';

        export declare function Create(request: Serenity.SaveRequest<ScannedBatchRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ScannedBatchRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function InsertScannedBatchData(request: Serenity.SaveRequest<ScannedBatchRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ScannedBatchRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ScannedBatchRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/ScannedBatch/Create",
            Update = "~/Api/Services/Workspace/ScannedBatch/Update",
            InsertScannedBatchData = "~/Api/Services/Workspace/ScannedBatch/InsertScannedBatchData",
            Delete = "~/Api/Services/Workspace/ScannedBatch/Delete",
            Retrieve = "~/Api/Services/Workspace/ScannedBatch/Retrieve",
            List = "~/Api/Services/Workspace/ScannedBatch/List"
        }

        [
            'Create', 
            'Update', 
            'InsertScannedBatchData', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ScannedBatchApiService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
