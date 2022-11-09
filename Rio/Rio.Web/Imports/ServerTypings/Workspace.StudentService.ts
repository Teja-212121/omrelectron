namespace Rio.Workspace {
    export namespace StudentService {
        export const baseUrl = 'Workspace/Student';

        export declare function Create(request: Serenity.SaveRequest<StudentRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<StudentRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<StudentRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<StudentRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function DeleteStudent(request: string[], onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/Student/Create",
            Update = "Workspace/Student/Update",
            Delete = "Workspace/Student/Delete",
            Retrieve = "Workspace/Student/Retrieve",
            List = "Workspace/Student/List",
            DeleteStudent = "Workspace/Student/DeleteStudent"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'DeleteStudent'
        ].forEach(x => {
            (<any>StudentService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
