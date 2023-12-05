namespace Rio.Workspace {
    export interface PreDefinedKeyRow {
        Id?: number;
        SerialKey?: string;
        EStatus?: Web.Enums.PreDefinedKeyStatus;
        IsActive?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace PreDefinedKeyRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SerialKey';
        export const localTextPrefix = 'Workspace.PreDefinedKey';
        export const lookupKey = 'Workspace.PreDefinedKey';

        export function getLookup(): Q.Lookup<PreDefinedKeyRow> {
            return Q.getLookup<PreDefinedKeyRow>('Workspace.PreDefinedKey');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            SerialKey = "SerialKey",
            EStatus = "EStatus",
            IsActive = "IsActive",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
