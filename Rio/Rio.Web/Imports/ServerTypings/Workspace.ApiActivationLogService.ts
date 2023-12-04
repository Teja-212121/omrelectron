namespace Rio.Workspace {
    export namespace ApiActivationLogService {
        export const baseUrl = '~/Api/Services/Workspace/ActivationLog';

        export declare function Create(request: Serenity.SaveRequest<ActivationLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ActivationLogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ActivationLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ActivationLogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/ActivationLog/Create",
            Update = "~/Api/Services/Workspace/ActivationLog/Update",
            Delete = "~/Api/Services/Workspace/ActivationLog/Delete",
            Retrieve = "~/Api/Services/Workspace/ActivationLog/Retrieve",
            List = "~/Api/Services/Workspace/ActivationLog/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ApiActivationLogService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
