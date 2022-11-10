import { fieldsProxy } from "@serenity-is/corelib/q";

export interface GroupStudentRow {
    Id?: number;
    GroupId?: number;
    StudentId?: number;
    IsActive?: number;
    TenantId?: number;
    GroupName?: string;
    GroupDescription?: string;
    GroupParentId?: number;
    GroupInsertDate?: string;
    GroupInsertUserId?: number;
    GroupUpdateDate?: string;
    GroupUpdateUserId?: number;
    GroupIsActive?: number;
    GroupTenantId?: number;
    StudentRollNo?: number;
    StudentFirstName?: string;
    StudentMiddleName?: string;
    StudentLastName?: string;
    StudentFullName?: string;
    StudentEmail?: string;
    StudentMobile?: string;
    StudentDob?: string;
    StudentGender?: number;
    StudentNote?: string;
    StudentInsertDate?: string;
    StudentInsertUserId?: number;
    StudentUpdateDate?: string;
    StudentUpdateUserId?: number;
    StudentIsActive?: number;
    StudentTenantId?: number;
    RowIds?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class GroupStudentRow {
    static readonly idProperty = 'Id';
    static readonly isActiveProperty = 'IsActive';
    static readonly localTextPrefix = 'Workspace.GroupStudent';
    static readonly deletePermission = 'Workspace:GroupStudents';
    static readonly insertPermission = 'Workspace:GroupStudents';
    static readonly readPermission = 'Workspace:GroupStudents';
    static readonly updatePermission = 'Workspace:GroupStudents';

    static readonly Fields = fieldsProxy<GroupStudentRow>();
}
