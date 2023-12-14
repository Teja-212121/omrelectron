namespace Rio.Workspace {
    export namespace APIExamQuestionService {
        export const baseUrl = '~/Api/Services/Workspace/ExamQuestion';

        export declare function Create(request: Serenity.SaveRequest<ExamQuestionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ExamQuestionRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ExamQuestionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ExamQuestionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function DeleteExamQuestion(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "~/Api/Services/Workspace/ExamQuestion/Create",
            Update = "~/Api/Services/Workspace/ExamQuestion/Update",
            Delete = "~/Api/Services/Workspace/ExamQuestion/Delete",
            Retrieve = "~/Api/Services/Workspace/ExamQuestion/Retrieve",
            List = "~/Api/Services/Workspace/ExamQuestion/List",
            DeleteExamQuestion = "~/Api/Services/Workspace/ExamQuestion/DeleteExamQuestion",
            ExcelImport = "~/Api/Services/Workspace/ExamQuestion/ExcelImport"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'DeleteExamQuestion', 
            'ExcelImport'
        ].forEach(x => {
            (<any>APIExamQuestionService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
