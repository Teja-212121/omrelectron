namespace Rio.Workspace {
    export namespace ExamApiService {
        export const baseUrl = '~/Api/Services/Workspace/Exam';

        export declare function Create(request: Serenity.SaveRequest<ExamRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ExamRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ExamRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ExamRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function DeleteExam(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/Exam/Create",
            Update = "~/Api/Services/Workspace/Exam/Update",
            Delete = "~/Api/Services/Workspace/Exam/Delete",
            Retrieve = "~/Api/Services/Workspace/Exam/Retrieve",
            List = "~/Api/Services/Workspace/Exam/List",
            DeleteExam = "~/Api/Services/Workspace/Exam/DeleteExam"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'DeleteExam'
        ].forEach(x => {
            (<any>ExamApiService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
