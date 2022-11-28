namespace Rio.Workspace {
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

    export namespace GroupStudentRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const localTextPrefix = 'Workspace.GroupStudent';
        export const deletePermission = 'Workspace:GroupManagement:Modify';
        export const insertPermission = 'Workspace:GroupManagement:Modify';
        export const readPermission = 'Workspace:GroupManagement:View';
        export const updatePermission = 'Workspace:GroupManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            GroupId = "GroupId",
            StudentId = "StudentId",
            IsActive = "IsActive",
            TenantId = "TenantId",
            GroupName = "GroupName",
            GroupDescription = "GroupDescription",
            GroupParentId = "GroupParentId",
            GroupInsertDate = "GroupInsertDate",
            GroupInsertUserId = "GroupInsertUserId",
            GroupUpdateDate = "GroupUpdateDate",
            GroupUpdateUserId = "GroupUpdateUserId",
            GroupIsActive = "GroupIsActive",
            GroupTenantId = "GroupTenantId",
            StudentRollNo = "StudentRollNo",
            StudentFirstName = "StudentFirstName",
            StudentMiddleName = "StudentMiddleName",
            StudentLastName = "StudentLastName",
            StudentFullName = "StudentFullName",
            StudentEmail = "StudentEmail",
            StudentMobile = "StudentMobile",
            StudentDob = "StudentDob",
            StudentGender = "StudentGender",
            StudentNote = "StudentNote",
            StudentInsertDate = "StudentInsertDate",
            StudentInsertUserId = "StudentInsertUserId",
            StudentUpdateDate = "StudentUpdateDate",
            StudentUpdateUserId = "StudentUpdateUserId",
            StudentIsActive = "StudentIsActive",
            StudentTenantId = "StudentTenantId",
            RowIds = "RowIds",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
