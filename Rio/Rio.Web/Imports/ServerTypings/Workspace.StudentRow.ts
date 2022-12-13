namespace Rio.Workspace {
    export interface StudentRow {
        Id?: number;
        RollNo?: number;
        FirstName?: string;
        MiddleName?: string;
        LastName?: string;
        FullName?: string;
        Email?: string;
        Mobile?: string;
        Dob?: string;
        Gender?: Web.Enums.Gender;
        Note?: string;
        StudentId?: string;
        Comments?: string;
        IsActive?: number;
        TenantId?: number;
        SelectedTenant?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace StudentRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'FullName';
        export const localTextPrefix = 'Workspace.Student';
        export const lookupKey = 'Workspace.Student';

        export function getLookup(): Q.Lookup<StudentRow> {
            return Q.getLookup<StudentRow>('Workspace.Student');
        }
        export const deletePermission = 'Workspace:StudentManagement:Modify';
        export const insertPermission = 'Workspace:StudentManagement:Modify';
        export const readPermission = 'Workspace:StudentManagement:View';
        export const updatePermission = 'Workspace:StudentManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            RollNo = "RollNo",
            FirstName = "FirstName",
            MiddleName = "MiddleName",
            LastName = "LastName",
            FullName = "FullName",
            Email = "Email",
            Mobile = "Mobile",
            Dob = "Dob",
            Gender = "Gender",
            Note = "Note",
            StudentId = "StudentId",
            Comments = "Comments",
            IsActive = "IsActive",
            TenantId = "TenantId",
            SelectedTenant = "SelectedTenant",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
