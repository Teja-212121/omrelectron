namespace Rio.Workspace {
    export interface TheoryExamSectionsRow {
        Id?: number;
        Name?: string;
        Description?: string;
        TheoryExamId?: number;
        ParentId?: number;
        SortOrder?: number;
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
        ParentName?: string;
        ParentDescription?: string;
        ParentTheoryExamId?: number;
        ParentParentId?: number;
        ParentSortOrder?: number;
        ParentInsertDate?: string;
        ParentInsertUserId?: number;
        ParentUpdateDate?: string;
        ParentUpdateUserId?: number;
        ParentIsActive?: number;
        ParentTenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace TheoryExamSectionsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.TheoryExamSections';
        export const lookupKey = 'Workspace.TheoryExamSections';

        export function getLookup(): Q.Lookup<TheoryExamSectionsRow> {
            return Q.getLookup<TheoryExamSectionsRow>('Workspace.TheoryExamSections');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            TheoryExamId = "TheoryExamId",
            ParentId = "ParentId",
            SortOrder = "SortOrder",
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
            ParentName = "ParentName",
            ParentDescription = "ParentDescription",
            ParentTheoryExamId = "ParentTheoryExamId",
            ParentParentId = "ParentParentId",
            ParentSortOrder = "ParentSortOrder",
            ParentInsertDate = "ParentInsertDate",
            ParentInsertUserId = "ParentInsertUserId",
            ParentUpdateDate = "ParentUpdateDate",
            ParentUpdateUserId = "ParentUpdateUserId",
            ParentIsActive = "ParentIsActive",
            ParentTenantId = "ParentTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
