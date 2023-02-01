namespace Rio.Workspace {
    export namespace ScannedSheetService {
        export const baseUrl = 'Workspace/ScannedSheet';

        export declare function Create(request: Serenity.SaveRequest<ScannedSheetRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ScannedSheetRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Updateresults(request: Serenity.SaveRequest<ScannedSheetRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ScannedSheetRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: MyCustomListRequest, onSuccess?: (response: Serenity.ListResponse<ScannedSheetRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function InsertScannedBatchData(request: Serenity.SaveRequest<ScannedSheetRow[]>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function UpdateResult(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function UpdateDisplayname(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function UpdateCorrectedRollNumber(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function RecalculateResult(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/ScannedSheet/Create",
            Update = "Workspace/ScannedSheet/Update",
            Updateresults = "Workspace/ScannedSheet/Updateresults",
            Delete = "Workspace/ScannedSheet/Delete",
            Retrieve = "Workspace/ScannedSheet/Retrieve",
            List = "Workspace/ScannedSheet/List",
            InsertScannedBatchData = "Workspace/ScannedSheet/InsertScannedBatchData",
            UpdateResult = "Workspace/ScannedSheet/UpdateResult",
            UpdateDisplayname = "Workspace/ScannedSheet/UpdateDisplayname",
            UpdateCorrectedRollNumber = "Workspace/ScannedSheet/UpdateCorrectedRollNumber",
            RecalculateResult = "Workspace/ScannedSheet/RecalculateResult"
        }

        [
            'Create', 
            'Update', 
            'Updateresults', 
            'Delete', 
            'Retrieve', 
            'List', 
            'InsertScannedBatchData', 
            'UpdateResult', 
            'UpdateDisplayname', 
            'UpdateCorrectedRollNumber', 
            'RecalculateResult'
        ].forEach(x => {
            (<any>ScannedSheetService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
