﻿namespace Rio.Workspace {
    export interface ExamResultRow {
        Id?: number;
        StudentId?: number;
        RollNumber?: number;
        SheetNumber?: string;
        SheetGuid?: string;
        ExamId?: number;
        TotalMarks?: number;
        ObtainedMarks?: number;
        Percentage?: number;
        TotalQuestions?: number;
        TotalAttempted?: number;
        TotalNotAttempted?: number;
        TotalRightAnswers?: number;
        TotalWrongAnswers?: number;
        IsActive?: number;
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

    export namespace ExamResultRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'SheetNumber';
        export const localTextPrefix = 'Workspace.ExamResult';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            StudentId = "StudentId",
            RollNumber = "RollNumber",
            SheetNumber = "SheetNumber",
            SheetGuid = "SheetGuid",
            ExamId = "ExamId",
            TotalMarks = "TotalMarks",
            ObtainedMarks = "ObtainedMarks",
            Percentage = "Percentage",
            TotalQuestions = "TotalQuestions",
            TotalAttempted = "TotalAttempted",
            TotalNotAttempted = "TotalNotAttempted",
            TotalRightAnswers = "TotalRightAnswers",
            TotalWrongAnswers = "TotalWrongAnswers",
            IsActive = "IsActive",
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