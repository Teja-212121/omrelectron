namespace Rio.Workspace {
    export interface ExamListExamsRow {
        Id?: number;
        ExamListId?: number;
        ExamId?: number;
        TenantId?: number;
        Priority?: number;
        StartDate?: string;
        EndDate?: string;
        ModelAnswerPaperStartDate?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsActive?: number;
        ExamListName?: string;
        ExamListDescription?: string;
        ExamListInsertDate?: string;
        ExamListInsertUserId?: number;
        ExamListUpdateDate?: string;
        ExamListUpdateUserId?: number;
        ExamListIsActive?: number;
        ExamListTenantId?: number;
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
        ExamTotalQuestions?: number;
        ExamExamDisplayName?: string;
        ExamQuestionPaper?: string;
        ExamModelAnswer?: string;
        ExamSheetTypeId?: number;
        TenantTenantName?: string;
        TenantEApprovalStatus?: number;
        TenantIsActive?: number;
    }

    export namespace ExamListExamsRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'Workspace.ExamListExams';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            ExamListId = "ExamListId",
            ExamId = "ExamId",
            TenantId = "TenantId",
            Priority = "Priority",
            StartDate = "StartDate",
            EndDate = "EndDate",
            ModelAnswerPaperStartDate = "ModelAnswerPaperStartDate",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsActive = "IsActive",
            ExamListName = "ExamListName",
            ExamListDescription = "ExamListDescription",
            ExamListInsertDate = "ExamListInsertDate",
            ExamListInsertUserId = "ExamListInsertUserId",
            ExamListUpdateDate = "ExamListUpdateDate",
            ExamListUpdateUserId = "ExamListUpdateUserId",
            ExamListIsActive = "ExamListIsActive",
            ExamListTenantId = "ExamListTenantId",
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
            ExamTotalQuestions = "ExamTotalQuestions",
            ExamExamDisplayName = "ExamExamDisplayName",
            ExamQuestionPaper = "ExamQuestionPaper",
            ExamModelAnswer = "ExamModelAnswer",
            ExamSheetTypeId = "ExamSheetTypeId",
            TenantTenantName = "TenantTenantName",
            TenantEApprovalStatus = "TenantEApprovalStatus",
            TenantIsActive = "TenantIsActive"
        }
    }
}
