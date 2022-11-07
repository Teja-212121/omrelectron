namespace Rio.Workspace {
    export interface ExamQuestionRow {
        Id?: number;
        ExamId?: number;
        QuestionIndex?: number;
        RightOptions?: number;
        Score?: number;
        Tags?: string;
        RuleTypeId?: number;
        ExamSectionId?: number;
        IsActive?: number;
        TenantId?: number;
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
        RuleTypeName?: string;
        RuleTypeDescription?: string;
        ExamSectionName?: string;
        ExamSectionDescription?: string;
        ExamSectionExamId?: number;
        ExamSectionParentId?: number;
        ExamSectionInsertDate?: string;
        ExamSectionInsertUserId?: number;
        ExamSectionUpdateDate?: string;
        ExamSectionUpdateUserId?: number;
        ExamSectionIsActive?: number;
        ExamSectionTenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ExamQuestionRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Tags';
        export const localTextPrefix = 'Workspace.ExamQuestion';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            ExamId = "ExamId",
            QuestionIndex = "QuestionIndex",
            RightOptions = "RightOptions",
            Score = "Score",
            Tags = "Tags",
            RuleTypeId = "RuleTypeId",
            ExamSectionId = "ExamSectionId",
            IsActive = "IsActive",
            TenantId = "TenantId",
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
            RuleTypeName = "RuleTypeName",
            RuleTypeDescription = "RuleTypeDescription",
            ExamSectionName = "ExamSectionName",
            ExamSectionDescription = "ExamSectionDescription",
            ExamSectionExamId = "ExamSectionExamId",
            ExamSectionParentId = "ExamSectionParentId",
            ExamSectionInsertDate = "ExamSectionInsertDate",
            ExamSectionInsertUserId = "ExamSectionInsertUserId",
            ExamSectionUpdateDate = "ExamSectionUpdateDate",
            ExamSectionUpdateUserId = "ExamSectionUpdateUserId",
            ExamSectionIsActive = "ExamSectionIsActive",
            ExamSectionTenantId = "ExamSectionTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
