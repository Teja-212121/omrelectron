namespace Rio.Workspace {
    export interface ExamGroupWiseResultRow {
        Id?: number;
        StudentId?: number;
        RollNumber?: number;
        SheetNumber?: string;
        SheetGuid?: string;
        ExamId?: number;
        Rank?: number;
        GroupId?: number;
        TenantId?: number;
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
        ExamCode?: string;
        ExamName?: string;
        ExamDescription?: string;
        ExamTotalMarks?: number;
        ExamNegativeMarks?: number;
        ExamOptionsAvailable?: number;
        ExamResultCriteria?: string;
        ExamInsertDate?: string;
        ExamInsertUserId?: number;
        ExamUpdateDate?: string;
        ExamUpdateUserId?: number;
        ExamIsActive?: number;
        ExamTenantId?: number;
        GroupName?: string;
        GroupDescription?: string;
        GroupParentId?: number;
        GroupInsertDate?: string;
        GroupInsertUserId?: number;
        GroupUpdateDate?: string;
        GroupUpdateUserId?: number;
        GroupIsActive?: number;
        GroupTenantId?: number;
    }

    export namespace ExamGroupWiseResultRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SheetNumber';
        export const localTextPrefix = 'Workspace.ExamGroupWiseResult';
        export const deletePermission = 'Workspace:ExamResultManagement:View';
        export const insertPermission = 'Workspace:ExamResultManagement:View';
        export const readPermission = 'Workspace:ExamResultManagement:View';
        export const updatePermission = 'Workspace:ExamResultManagement:View';

        export declare const enum Fields {
            Id = "Id",
            StudentId = "StudentId",
            RollNumber = "RollNumber",
            SheetNumber = "SheetNumber",
            SheetGuid = "SheetGuid",
            ExamId = "ExamId",
            Rank = "Rank",
            GroupId = "GroupId",
            TenantId = "TenantId",
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
            ExamCode = "ExamCode",
            ExamName = "ExamName",
            ExamDescription = "ExamDescription",
            ExamTotalMarks = "ExamTotalMarks",
            ExamNegativeMarks = "ExamNegativeMarks",
            ExamOptionsAvailable = "ExamOptionsAvailable",
            ExamResultCriteria = "ExamResultCriteria",
            ExamInsertDate = "ExamInsertDate",
            ExamInsertUserId = "ExamInsertUserId",
            ExamUpdateDate = "ExamUpdateDate",
            ExamUpdateUserId = "ExamUpdateUserId",
            ExamIsActive = "ExamIsActive",
            ExamTenantId = "ExamTenantId",
            GroupName = "GroupName",
            GroupDescription = "GroupDescription",
            GroupParentId = "GroupParentId",
            GroupInsertDate = "GroupInsertDate",
            GroupInsertUserId = "GroupInsertUserId",
            GroupUpdateDate = "GroupUpdateDate",
            GroupUpdateUserId = "GroupUpdateUserId",
            GroupIsActive = "GroupIsActive",
            GroupTenantId = "GroupTenantId"
        }
    }
}
