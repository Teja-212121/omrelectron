namespace Rio.Workspace {
    export namespace ApiCouponCodeService {
        export const baseUrl = '~/Api/Services/Workspace/CouponCode';

        export declare function Create(request: Serenity.SaveRequest<CouponCodeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ActivateCouponCode(request: ActivaieCouponCode, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<CouponCodeRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<CouponCodeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<CouponCodeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/CouponCode/Create",
            ActivateCouponCode = "~/Api/Services/Workspace/CouponCode/ActivateCouponCode",
            Update = "~/Api/Services/Workspace/CouponCode/Update",
            Delete = "~/Api/Services/Workspace/CouponCode/Delete",
            Retrieve = "~/Api/Services/Workspace/CouponCode/Retrieve",
            List = "~/Api/Services/Workspace/CouponCode/List"
        }

        [
            'Create', 
            'ActivateCouponCode', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ApiCouponCodeService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
