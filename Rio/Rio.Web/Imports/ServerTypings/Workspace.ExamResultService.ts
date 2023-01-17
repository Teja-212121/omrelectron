namespace Rio.Workspace {
    export namespace ExamResultService {
        export const baseUrl = 'Workspace/ExamResult';

        export declare function Create(request: Serenity.SaveRequest<ExamResultRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ExamResultRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ExamResultRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ExamResultRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function SendEmails(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/ExamResult/Create",
            Update = "Workspace/ExamResult/Update",
            Delete = "Workspace/ExamResult/Delete",
            Retrieve = "Workspace/ExamResult/Retrieve",
            List = "Workspace/ExamResult/List",
            SendEmails = "Workspace/ExamResult/SendEmails"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'SendEmails'
        ].forEach(x => {
            (<any>ExamResultService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
