namespace Rio.Workspace {
    export namespace ExamListExamsApiService {
        export const baseUrl = '~/Api/Services/Workspace/ExamListExams';

        export declare function Create(request: Serenity.SaveRequest<ExamListExamsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ExamListExamsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ExamListExamsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ExamListExamsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ListExams(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ExamListExamsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/ExamListExams/Create",
            Update = "~/Api/Services/Workspace/ExamListExams/Update",
            Delete = "~/Api/Services/Workspace/ExamListExams/Delete",
            Retrieve = "~/Api/Services/Workspace/ExamListExams/Retrieve",
            List = "~/Api/Services/Workspace/ExamListExams/List",
            ListExams = "~/Api/Services/Workspace/ExamListExams/ListExams"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'ListExams'
        ].forEach(x => {
            (<any>ExamListExamsApiService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
