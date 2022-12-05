namespace Rio.Workspace {
    export interface ScannedBatchRow {
        Id?: string;
        Name?: string;
        Description?: string;
        IsActive?: number;
        TenantId?: number;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
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
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId"
        }
    }
}
