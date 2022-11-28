namespace Rio.Workspace {
    export interface ScannedBatchRow {
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

    export namespace ScannedBatchRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.ScannedBatch';
        export const lookupKey = 'Workspace.ScannedBatchs';

        export function getLookup(): Q.Lookup<ScannedBatchRow> {
            return Q.getLookup<ScannedBatchRow>('Workspace.ScannedBatchs');
        }
        export const deletePermission = 'Workspace:ScannedData:Modify';
        export const insertPermission = 'Workspace:ScannedData:Modify';
        export const readPermission = 'Workspace:ScannedData:View';
        export const updatePermission = 'Workspace:ScannedData:Modify';

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
