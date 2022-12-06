namespace Rio.Workspace {
    export interface TheoryExamResultQuestionsRow {
        Id?: number;
        TheoryExamResultId?: number;
        TheoryExamQuestionId?: number;
        MarksObtained?: number;
        OutOfMarks?: number;
        AttemptStatus?: number;
        IsActive?: number;
        TenantId?: number;
        TheoryExamResultTheoryExamId?: number;
        TheoryExamResultStudentScanId?: string;
        TheoryExamResultMarksScored?: number;
        TheoryExamResultOutOfMarks?: number;
        TheoryExamResultResultStatus?: number;
        TheoryExamResultRollNumber?: string;
        TheoryExamResultSheetImage?: string;
        TheoryExamResultStudentId?: number;
        TheoryExamResultAttemptDate?: string;
        TheoryExamResultInsertDate?: string;
        TheoryExamResultInsertUserId?: number;
        TheoryExamResultUpdateDate?: string;
        TheoryExamResultUpdateUserId?: number;
        TheoryExamResultIsActive?: number;
        TheoryExamResultTenantId?: number;
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
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace TheoryExamResultQuestionsRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'Workspace.TheoryExamResultQuestions';
        export const deletePermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const insertPermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const readPermission = 'Workspace:ExamsAndSectionManagement:View';
        export const updatePermission = 'Workspace:ExamsAndSectionManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            TheoryExamResultId = "TheoryExamResultId",
            TheoryExamQuestionId = "TheoryExamQuestionId",
            MarksObtained = "MarksObtained",
            OutOfMarks = "OutOfMarks",
            AttemptStatus = "AttemptStatus",
            IsActive = "IsActive",
            TenantId = "TenantId",
            TheoryExamResultTheoryExamId = "TheoryExamResultTheoryExamId",
            TheoryExamResultStudentScanId = "TheoryExamResultStudentScanId",
            TheoryExamResultMarksScored = "TheoryExamResultMarksScored",
            TheoryExamResultOutOfMarks = "TheoryExamResultOutOfMarks",
            TheoryExamResultResultStatus = "TheoryExamResultResultStatus",
            TheoryExamResultRollNumber = "TheoryExamResultRollNumber",
            TheoryExamResultSheetImage = "TheoryExamResultSheetImage",
            TheoryExamResultStudentId = "TheoryExamResultStudentId",
            TheoryExamResultAttemptDate = "TheoryExamResultAttemptDate",
            TheoryExamResultInsertDate = "TheoryExamResultInsertDate",
            TheoryExamResultInsertUserId = "TheoryExamResultInsertUserId",
            TheoryExamResultUpdateDate = "TheoryExamResultUpdateDate",
            TheoryExamResultUpdateUserId = "TheoryExamResultUpdateUserId",
            TheoryExamResultIsActive = "TheoryExamResultIsActive",
            TheoryExamResultTenantId = "TheoryExamResultTenantId",
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
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
