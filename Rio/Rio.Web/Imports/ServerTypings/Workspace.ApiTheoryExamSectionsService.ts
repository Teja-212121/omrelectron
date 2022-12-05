namespace Rio.Workspace {
    export namespace ApiTheoryExamSectionsService {
        export const baseUrl = 'Workspace/TheoryExamSections';

        export declare function Create(request: Serenity.SaveRequest<TheoryExamSectionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TheoryExamSectionsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TheoryExamSectionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TheoryExamSectionsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Workspace/TheoryExamSections/Create",
            Update = "Workspace/TheoryExamSections/Update",
            Delete = "Workspace/TheoryExamSections/Delete",
            Retrieve = "Workspace/TheoryExamSections/Retrieve",
            List = "Workspace/TheoryExamSections/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ApiTheoryExamSectionsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
