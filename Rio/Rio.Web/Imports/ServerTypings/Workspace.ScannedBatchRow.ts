namespace Rio.Workspace {
    export interface ScannedBatchRow {
        Id?: string;
        Name?: string;
        Description?: string;
        IsActive?: number;
        TenantId?: number;
        ScannedSheets?: ScannedSheetRow[];
        ScannedQuestions?: ScannedQuestionRow[];
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ScannedBatchRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.ScannedBatch';
        export const lookupKey = 'Workspace.ScannedBatchs';

        export function getLookup(): Q.Lookup<ScannedBatchRow> {
            return Q.getLookup<ScannedBatchRow>('Workspace.ScannedBatchs');
        }
        export const deletePermission = 'Workspace:ScannedDataManagement:Modify';
        export const insertPermission = 'Workspace:ScannedDataManagement:Modify';
        export const readPermission = 'Workspace:ScannedDataManagement:View';
        export const updatePermission = 'Workspace:ScannedDataManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            IsActive = "IsActive",
            TenantId = "TenantId",
            ScannedSheets = "ScannedSheets",
            ScannedQuestions = "ScannedQuestions",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
