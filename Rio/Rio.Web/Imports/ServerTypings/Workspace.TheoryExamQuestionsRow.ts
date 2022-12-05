namespace Rio.Workspace {
    export interface TheoryExamQuestionsRow {
        Id?: number;
        TheoryExamId?: number;
        QuestionIndex?: number;
        MaxMarks?: number;
        DisplayIndex?: string;
        Tags?: string;
        TheoryExamSectionId?: number;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
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
        TheoryExamSectionName?: string;
        TheoryExamSectionDescription?: string;
        TheoryExamSectionTheoryExamId?: number;
        TheoryExamSectionParentId?: number;
        TheoryExamSectionSortOrder?: number;
        TheoryExamSectionInsertDate?: string;
        TheoryExamSectionInsertUserId?: number;
        TheoryExamSectionUpdateDate?: string;
        TheoryExamSectionUpdateUserId?: number;
        TheoryExamSectionIsActive?: number;
        TheoryExamSectionTenantId?: number;
    }

    export namespace TheoryExamQuestionsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'DisplayIndex';
        export const localTextPrefix = 'Workspace.TheoryExamQuestions';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            TheoryExamId = "TheoryExamId",
            QuestionIndex = "QuestionIndex",
            MaxMarks = "MaxMarks",
            DisplayIndex = "DisplayIndex",
            Tags = "Tags",
            TheoryExamSectionId = "TheoryExamSectionId",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
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
            TheoryExamSectionName = "TheoryExamSectionName",
            TheoryExamSectionDescription = "TheoryExamSectionDescription",
            TheoryExamSectionTheoryExamId = "TheoryExamSectionTheoryExamId",
            TheoryExamSectionParentId = "TheoryExamSectionParentId",
            TheoryExamSectionSortOrder = "TheoryExamSectionSortOrder",
            TheoryExamSectionInsertDate = "TheoryExamSectionInsertDate",
            TheoryExamSectionInsertUserId = "TheoryExamSectionInsertUserId",
            TheoryExamSectionUpdateDate = "TheoryExamSectionUpdateDate",
            TheoryExamSectionUpdateUserId = "TheoryExamSectionUpdateUserId",
            TheoryExamSectionIsActive = "TheoryExamSectionIsActive",
            TheoryExamSectionTenantId = "TheoryExamSectionTenantId"
        }
    }
}
