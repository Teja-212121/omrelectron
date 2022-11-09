namespace Rio.Workspace {
    export interface ImportedScannedBatchRow {
        Id?: string;
        Name?: string;
        Description?: string;
        IsActive?: number;
        TenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ImportedScannedBatchRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.ImportedScannedBatch';
        export const lookupKey = 'Workspace.ImportedScannedBatches';

        export function getLookup(): Q.Lookup<ImportedScannedBatchRow> {
            return Q.getLookup<ImportedScannedBatchRow>('Workspace.ImportedScannedBatches');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            IsActive = "IsActive",
            TenantId = "TenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
