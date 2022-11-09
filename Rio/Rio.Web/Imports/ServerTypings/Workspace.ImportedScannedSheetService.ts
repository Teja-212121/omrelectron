namespace Rio.Workspace {
    export namespace ImportedScannedSheetService {
        export const baseUrl = 'Workspace/ImportedScannedSheet';

        export declare function Create(request: Serenity.SaveRequest<ImportedScannedSheetRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ImportedScannedSheetRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ImportedScannedSheetRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ImportedScannedSheetRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/ImportedScannedSheet/Create",
            Update = "Workspace/ImportedScannedSheet/Update",
            Delete = "Workspace/ImportedScannedSheet/Delete",
            Retrieve = "Workspace/ImportedScannedSheet/Retrieve",
            List = "Workspace/ImportedScannedSheet/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ImportedScannedSheetService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
