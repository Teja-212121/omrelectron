import { SaveRequest, SaveResponse, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse } from "@serenity-is/corelib";
import { SheetTypeRow } from "./SheetTypeRow";
import { ServiceOptions, serviceRequest } from "@serenity-is/corelib/q";

export namespace SheetTypeService {
    export const baseUrl = 'Workspace/SheetType';

    export declare function Create(request: SaveRequest<SheetTypeRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<SheetTypeRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SheetTypeRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SheetTypeRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export declare const enum Methods {
        Create = "Workspace/SheetType/Create",
        Update = "Workspace/SheetType/Update",
        Delete = "Workspace/SheetType/Delete",
        Retrieve = "Workspace/SheetType/Retrieve",
        List = "Workspace/SheetType/List"
    }

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SheetTypeService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
