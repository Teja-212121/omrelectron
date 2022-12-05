namespace Rio.Workspace {
    export interface TheoryExamQuestionsRow {
        Id?: number;
        TheoryExamId?: number;
        QuestionIndex?: number;
        MaxMarks?: number;
        DisplayIndex?: string;
        Tags?: string;
        TheoryExamSectionId?: number;
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
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace TheoryExamQuestionsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'DisplayIndex';
        export const localTextPrefix = 'Workspace.TheoryExamQuestions';
        export const lookupKey = 'Workspace.TheoryExamQuestions';

        export function getLookup(): Q.Lookup<TheoryExamQuestionsRow> {
            return Q.getLookup<TheoryExamQuestionsRow>('Workspace.TheoryExamQuestions');
        }
        export const deletePermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const insertPermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const readPermission = 'Workspace:ExamsAndSectionManagement:View';
        export const updatePermission = 'Workspace:ExamsAndSectionManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            TheoryExamId = "TheoryExamId",
            QuestionIndex = "QuestionIndex",
            MaxMarks = "MaxMarks",
            DisplayIndex = "DisplayIndex",
            Tags = "Tags",
            TheoryExamSectionId = "TheoryExamSectionId",
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
            TheoryExamSectionTenantId = "TheoryExamSectionTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
