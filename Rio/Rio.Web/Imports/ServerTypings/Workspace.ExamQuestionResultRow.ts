namespace Rio.Workspace {
    export interface ExamQuestionResultRow {
        Id?: number;
        StudentId?: number;
        RollNumber?: string;
        SheetNumber?: string;
        SheetGuid?: string;
        ExamId?: number;
        QuestionIndex?: number;
        IsAttempted?: boolean;
        IsCorrect?: boolean;
        ObtainedMarks?: number;
        ScannedBatchId?: string;
        ScannedSheetId?: string;
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
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ExamQuestionResultRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SheetNumber';
        export const localTextPrefix = 'Workspace.ExamQuestionResult';
        export const deletePermission = 'Administration.Security';
        export const insertPermission = 'Administration.Security';
        export const readPermission = 'Workspace:ExamResultManagement:View';
        export const updatePermission = 'Administration.Security';

        export declare const enum Fields {
            Id = "Id",
            StudentId = "StudentId",
            RollNumber = "RollNumber",
            SheetNumber = "SheetNumber",
            SheetGuid = "SheetGuid",
            ExamId = "ExamId",
            QuestionIndex = "QuestionIndex",
            IsAttempted = "IsAttempted",
            IsCorrect = "IsCorrect",
            ObtainedMarks = "ObtainedMarks",
            ScannedBatchId = "ScannedBatchId",
            ScannedSheetId = "ScannedSheetId",
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
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
