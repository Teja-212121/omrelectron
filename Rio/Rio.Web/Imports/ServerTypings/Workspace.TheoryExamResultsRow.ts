namespace Rio.Workspace {
    export interface TheoryExamResultsRow {
        Id?: number;
        TheoryExamId?: number;
        StudentScanId?: string;
        MarksScored?: number;
        OutOfMarks?: number;
        ResultStatus?: Web.Enums.EResultSyncStatus;
        RollNumber?: string;
        SheetImage?: string;
        StudentId?: number;
        AttemptDate?: string;
        IsActive?: number;
        TenantId?: number;
        TheoryExamResultQuestions?: TheoryExamResultQuestionsRow[];
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
        export const lookupKey = 'Workspace.TheoryExamResults';

        export function getLookup(): Q.Lookup<TheoryExamResultsRow> {
            return Q.getLookup<TheoryExamResultsRow>('Workspace.TheoryExamResults');
        }
        export const deletePermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const insertPermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const readPermission = 'Workspace:ExamsAndSectionManagement:View';
        export const updatePermission = 'Workspace:ExamsAndSectionManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            TheoryExamId = "TheoryExamId",
            StudentScanId = "StudentScanId",
            MarksScored = "MarksScored",
            OutOfMarks = "OutOfMarks",
            ResultStatus = "ResultStatus",
            RollNumber = "RollNumber",
            SheetImage = "SheetImage",
            StudentId = "StudentId",
            AttemptDate = "AttemptDate",
            IsActive = "IsActive",
            TenantId = "TenantId",
            TheoryExamResultQuestions = "TheoryExamResultQuestions",
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
