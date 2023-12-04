namespace Rio.Workspace {
    export namespace ExamListApiService {
        export const baseUrl = '~/Api/Services/Workspace/ExamList';

        export declare function Create(request: Serenity.SaveRequest<ExamListRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ExamListRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ExamListRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ExamListRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/ExamList/Create",
            Update = "~/Api/Services/Workspace/ExamList/Update",
            Delete = "~/Api/Services/Workspace/ExamList/Delete",
            Retrieve = "~/Api/Services/Workspace/ExamList/Retrieve",
            List = "~/Api/Services/Workspace/ExamList/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ExamListApiService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
