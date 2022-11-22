namespace Rio.Workspace {
    export namespace SelectSheetTypeService {
        export const baseUrl = 'Workspace/SelectSheetType';

        export declare function Create(request: Serenity.SaveRequest<SelectSheetTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<SelectSheetTypeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SelectSheetTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SelectSheetTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function UpdateSheetTypeTenants(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/SelectSheetType/Create",
            Update = "Workspace/SelectSheetType/Update",
            Delete = "Workspace/SelectSheetType/Delete",
            Retrieve = "Workspace/SelectSheetType/Retrieve",
            List = "Workspace/SelectSheetType/List",
            UpdateSheetTypeTenants = "Workspace/SelectSheetType/UpdateSheetTypeTenants"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'UpdateSheetTypeTenants'
        ].forEach(x => {
            (<any>SelectSheetTypeService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
