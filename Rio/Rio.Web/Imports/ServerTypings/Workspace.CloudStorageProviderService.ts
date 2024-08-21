namespace Rio.Workspace {
    export namespace CloudStorageProviderService {
        export const baseUrl = 'Workspace/CloudStorageProvider';

        export declare function Create(request: Serenity.SaveRequest<CloudStorageProviderRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<CloudStorageProviderRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CloudStorageProviderRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CloudStorageProviderRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/CloudStorageProvider/Create",
            Update = "Workspace/CloudStorageProvider/Update",
            Delete = "Workspace/CloudStorageProvider/Delete",
            Retrieve = "Workspace/CloudStorageProvider/Retrieve",
            List = "Workspace/CloudStorageProvider/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>CloudStorageProviderService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
