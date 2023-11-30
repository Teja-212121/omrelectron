namespace Rio.Workspace {
    export namespace PreDefinedKeyService {
        export const baseUrl = 'Workspace/PreDefinedKey';

        export declare function Create(request: Serenity.SaveRequest<PreDefinedKeyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<PreDefinedKeyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PreDefinedKeyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PreDefinedKeyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/PreDefinedKey/Create",
            Update = "Workspace/PreDefinedKey/Update",
            Delete = "Workspace/PreDefinedKey/Delete",
            Retrieve = "Workspace/PreDefinedKey/Retrieve",
            List = "Workspace/PreDefinedKey/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>PreDefinedKeyService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
