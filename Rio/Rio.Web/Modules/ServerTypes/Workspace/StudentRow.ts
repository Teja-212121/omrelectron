import { Gender } from "../Web/Enums.Gender";
import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

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
    Gender?: Gender;
    Note?: string;
    StudentId?: string;
    Comments?: string;
    IsActive?: number;
    TenantId?: number;
    TenantName?: string;
    SelectedTenant?: number;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class StudentRow {
    static readonly idProperty = 'Id';
    static readonly isActiveProperty = 'IsActive';
    static readonly nameProperty = 'FullName';
    static readonly localTextPrefix = 'Workspace.Student';
    static readonly lookupKey = 'Workspace.Student';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<StudentRow>('Workspace.Student') }
    static async getLookupAsync() { return getLookupAsync<StudentRow>('Workspace.Student') }

    static readonly deletePermission = 'Workspace:StudentManagement:Modify';
    static readonly insertPermission = 'Workspace:StudentManagement:Modify';
    static readonly readPermission = 'Workspace:StudentManagement:View';
    static readonly updatePermission = 'Workspace:StudentManagement:Modify';

    static readonly Fields = fieldsProxy<StudentRow>();
}
