namespace Rio.Workspace {
    export namespace CloudStorageSettingService {
        export const baseUrl = '~/Api/Services/Workspace/CloudStorageSetting';

        export declare function Create(request: Serenity.SaveRequest<CloudStorageSettingRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<CloudStorageSettingRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CloudStorageSettingRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CloudStorageSettingRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/CloudStorageSetting/Create",
            Update = "~/Api/Services/Workspace/CloudStorageSetting/Update",
            Delete = "~/Api/Services/Workspace/CloudStorageSetting/Delete",
            Retrieve = "~/Api/Services/Workspace/CloudStorageSetting/Retrieve",
            List = "~/Api/Services/Workspace/CloudStorageSetting/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>CloudStorageSettingService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
