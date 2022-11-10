﻿import { Gender } from "../Web/Enums.Gender";
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
    IsActive?: number;
    TenantId?: number;
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

    static readonly deletePermission = 'Workspace:GroupStudents';
    static readonly insertPermission = 'Workspace:GroupStudents';
    static readonly readPermission = 'Workspace:GroupStudents';
    static readonly updatePermission = 'Workspace:GroupStudents';

    static readonly Fields = fieldsProxy<StudentRow>();
}
