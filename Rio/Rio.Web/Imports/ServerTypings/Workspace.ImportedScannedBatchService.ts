namespace Rio.Workspace {
    export namespace ImportedScannedBatchService {
        export const baseUrl = 'Workspace/ImportedScannedBatch';

        export declare function Create(request: Serenity.SaveRequest<ImportedScannedBatchRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ImportedScannedBatchRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ImportedScannedBatchRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ImportedScannedBatchRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function InsertStudentSelectedDetail(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/ImportedScannedBatch/Create",
            Update = "Workspace/ImportedScannedBatch/Update",
            Delete = "Workspace/ImportedScannedBatch/Delete",
            Retrieve = "Workspace/ImportedScannedBatch/Retrieve",
            List = "Workspace/ImportedScannedBatch/List",
            InsertStudentSelectedDetail = "Workspace/ImportedScannedBatch/InsertStudentSelectedDetail",
            ExcelImport = "Workspace/ImportedScannedBatch/ExcelImport"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'InsertStudentSelectedDetail', 
            'ExcelImport'
        ].forEach(x => {
            (<any>ImportedScannedBatchService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
