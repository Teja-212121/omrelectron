namespace Rio.Workspace {
    export interface TheoryExamResultsRow {
        Id?: number;
        TheoryExamId?: number;
        StudentScanId?: string;
        TheoryExamQuestionId?: number;
        MarksObtained?: number;
        AttemptStatus?: number;
        RollNumber?: string;
        StudentId?: number;
        IsActive?: number;
        TenantId?: number;
        TheoryExamCode?: string;
        TheoryExamName?: string;
        TheoryExamDescription?: string;
        TheoryExamTotalMarks?: number;
        TheoryExamInsertDate?: string;
        TheoryExamInsertUserId?: number;
        TheoryExamUpdateDate?: string;
        TheoryExamUpdateUserId?: number;
        TheoryExamIsActive?: number;
        TheoryExamTenantId?: number;
        TheoryExamQuestionTheoryExamId?: number;
        TheoryExamQuestionQuestionIndex?: number;
        TheoryExamQuestionMaxMarks?: number;
        TheoryExamQuestionDisplayIndex?: string;
        TheoryExamQuestionTags?: string;
        TheoryExamQuestionTheoryExamSectionId?: number;
        TheoryExamQuestionInsertDate?: string;
        TheoryExamQuestionInsertUserId?: number;
        TheoryExamQuestionUpdateDate?: string;
        TheoryExamQuestionUpdateUserId?: number;
        TheoryExamQuestionIsActive?: number;
        TheoryExamQuestionTenantId?: number;
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
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace TheoryExamResultsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'StudentScanId';
        export const localTextPrefix = 'Workspace.TheoryExamResults';
        export const deletePermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const insertPermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const readPermission = 'Workspace:ExamsAndSectionManagement:View';
        export const updatePermission = 'Workspace:ExamsAndSectionManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            TheoryExamId = "TheoryExamId",
            StudentScanId = "StudentScanId",
            TheoryExamQuestionId = "TheoryExamQuestionId",
            MarksObtained = "MarksObtained",
            AttemptStatus = "AttemptStatus",
            RollNumber = "RollNumber",
            StudentId = "StudentId",
            IsActive = "IsActive",
            TenantId = "TenantId",
            TheoryExamCode = "TheoryExamCode",
            TheoryExamName = "TheoryExamName",
            TheoryExamDescription = "TheoryExamDescription",
            TheoryExamTotalMarks = "TheoryExamTotalMarks",
            TheoryExamInsertDate = "TheoryExamInsertDate",
            TheoryExamInsertUserId = "TheoryExamInsertUserId",
            TheoryExamUpdateDate = "TheoryExamUpdateDate",
            TheoryExamUpdateUserId = "TheoryExamUpdateUserId",
            TheoryExamIsActive = "TheoryExamIsActive",
            TheoryExamTenantId = "TheoryExamTenantId",
            TheoryExamQuestionTheoryExamId = "TheoryExamQuestionTheoryExamId",
            TheoryExamQuestionQuestionIndex = "TheoryExamQuestionQuestionIndex",
            TheoryExamQuestionMaxMarks = "TheoryExamQuestionMaxMarks",
            TheoryExamQuestionDisplayIndex = "TheoryExamQuestionDisplayIndex",
            TheoryExamQuestionTags = "TheoryExamQuestionTags",
            TheoryExamQuestionTheoryExamSectionId = "TheoryExamQuestionTheoryExamSectionId",
            TheoryExamQuestionInsertDate = "TheoryExamQuestionInsertDate",
            TheoryExamQuestionInsertUserId = "TheoryExamQuestionInsertUserId",
            TheoryExamQuestionUpdateDate = "TheoryExamQuestionUpdateDate",
            TheoryExamQuestionUpdateUserId = "TheoryExamQuestionUpdateUserId",
            TheoryExamQuestionIsActive = "TheoryExamQuestionIsActive",
            TheoryExamQuestionTenantId = "TheoryExamQuestionTenantId",
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
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
