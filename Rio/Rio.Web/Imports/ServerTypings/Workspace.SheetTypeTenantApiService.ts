namespace Rio.Workspace {
    export namespace SheetTypeTenantApiService {
        export const baseUrl = '~/Api/Services/Workspace/SheetTypeTenant';

        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SheetTypeTenantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SheetTypeTenantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Retrieve = "~/Api/Services/Workspace/SheetTypeTenant/Retrieve",
            List = "~/Api/Services/Workspace/SheetTypeTenant/List"
        }

        [
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>SheetTypeTenantApiService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
