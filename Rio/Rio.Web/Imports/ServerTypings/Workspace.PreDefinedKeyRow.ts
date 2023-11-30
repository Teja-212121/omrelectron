namespace Rio.Workspace {
    export interface PreDefinedKeyRow {
        Id?: number;
        SerialKey?: string;
        EStatus?: number;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsActive?: number;
    }

    export namespace PreDefinedKeyRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SerialKey';
        export const localTextPrefix = 'Workspace.PreDefinedKey';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            SerialKey = "SerialKey",
            EStatus = "EStatus",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsActive = "IsActive"
        }
    }
}
