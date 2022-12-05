namespace Rio.Workspace {
    export interface TeachersRow {
        Id?: number;
        FirstName?: string;
        MiddleName?: string;
        LastName?: string;
        FullName?: string;
        Email?: string;
        Mobile?: string;
        Dob?: string;
        AllowedIps?: string;
        Address?: string;
        City?: string;
        UserId?: number;
        IsActive?: number;
        TenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace TeachersRow {
        export const idProperty = 'Id';
        export const nameProperty = 'FirstName';
        export const localTextPrefix = 'Workspace.Teachers';
        export const lookupKey = 'Workspace.Teachers';

        export function getLookup(): Q.Lookup<TeachersRow> {
            return Q.getLookup<TeachersRow>('Workspace.Teachers');
        }
        export const deletePermission = 'Workspace:StudentManagement:Modify';
        export const insertPermission = 'Workspace:StudentManagement:Modify';
        export const readPermission = 'Workspace:StudentManagement:View';
        export const updatePermission = 'Workspace:StudentManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            FirstName = "FirstName",
            MiddleName = "MiddleName",
            LastName = "LastName",
            FullName = "FullName",
            Email = "Email",
            Mobile = "Mobile",
            Dob = "Dob",
            AllowedIps = "AllowedIps",
            Address = "Address",
            City = "City",
            UserId = "UserId",
            IsActive = "IsActive",
            TenantId = "TenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
