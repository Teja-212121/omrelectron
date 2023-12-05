namespace Rio.Workspace {
    export namespace SerialKeyService {
        export const baseUrl = 'Workspace/SerialKey';

        export declare function Create(request: Serenity.SaveRequest<SerialKeyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<SerialKeyRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<SerialKeyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<SerialKeyRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function GenerateSerialKey(request: GenerateCodeRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/SerialKey/Create",
            Update = "Workspace/SerialKey/Update",
            Delete = "Workspace/SerialKey/Delete",
            Retrieve = "Workspace/SerialKey/Retrieve",
            List = "Workspace/SerialKey/List",
            GenerateSerialKey = "Workspace/SerialKey/GenerateSerialKey"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'GenerateSerialKey'
        ].forEach(x => {
            (<any>SerialKeyService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
