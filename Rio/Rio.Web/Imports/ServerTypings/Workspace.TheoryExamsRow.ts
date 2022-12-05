namespace Rio.Workspace {
    export interface TheoryExamsRow {
        Id?: number;
        RowIds?: string;
        Code?: string;
        Name?: string;
        Description?: string;
        TotalMarks?: number;
        IsActive?: number;
        TenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace TheoryExamsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Workspace.TheoryExams';
        export const lookupKey = 'Workspace.TheoryExams';

        export function getLookup(): Q.Lookup<TheoryExamsRow> {
            return Q.getLookup<TheoryExamsRow>('Workspace.TheoryExams');
        }
        export const deletePermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const insertPermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const readPermission = 'Workspace:ExamsAndSectionManagement:View';
        export const updatePermission = 'Workspace:ExamsAndSectionManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            RowIds = "RowIds",
            Code = "Code",
            Name = "Name",
            Description = "Description",
            TotalMarks = "TotalMarks",
            IsActive = "IsActive",
            TenantId = "TenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
