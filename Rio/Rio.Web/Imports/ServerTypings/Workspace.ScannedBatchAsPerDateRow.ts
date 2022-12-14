namespace Rio.Workspace {
    export interface ScannedBatchAsPerDateRow {
        Id?: string;
        Name?: string;
        ScannedSheetDisplayName?: string;
        ScanBatchid?: string;
        InsertDate?: string;
        ScannedBatchInsertDate?: string;
        IsActive?: number;
        TenantId?: number;
    }

    export namespace ScannedBatchAsPerDateRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.ScannedBatchAsPerDate';
        export const lookupKey = 'Workspace.ScannedBatchAsPerDate';

        export function getLookup(): Q.Lookup<ScannedBatchAsPerDateRow> {
            return Q.getLookup<ScannedBatchAsPerDateRow>('Workspace.ScannedBatchAsPerDate');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            ScannedSheetDisplayName = "ScannedSheetDisplayName",
            ScanBatchid = "ScanBatchid",
            InsertDate = "InsertDate",
            ScannedBatchInsertDate = "ScannedBatchInsertDate",
            IsActive = "IsActive",
            TenantId = "TenantId"
        }
    }
}
