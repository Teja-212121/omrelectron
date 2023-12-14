namespace Rio.Workspace {
    export interface SerialKeyRow {
        Id?: number;
        SerialKey?: string;
        ExamListId?: number;
        ValidityType?: Web.Enums.EValidityType;
        ValidityInDays?: number;
        KeyGenAsId?: number;
        ValidDate?: string;
        Note?: string;
        EStatus?: Web.Enums.KeyStatus;
        IsActive?: number;
        ExamListName?: string;
        ExamListDescription?: string;
        ExamListInsertDate?: string;
        ExamListInsertUserId?: number;
        ExamListUpdateDate?: string;
        ExamListUpdateUserId?: number;
        ExamListIsActive?: number;
        ExamListTenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace SerialKeyRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SerialKey';
        export const localTextPrefix = 'Workspace.SerialKey';
        export const lookupKey = 'Workspace.SerialKey';

        export function getLookup(): Q.Lookup<SerialKeyRow> {
            return Q.getLookup<SerialKeyRow>('Workspace.SerialKey');
        }
        export const deletePermission = 'Workspace:ExamListManagement:Modify';
        export const insertPermission = 'Workspace:ExamListManagement:Modify';
        export const readPermission = 'Workspace:ExamListManagement:View';
        export const updatePermission = 'Workspace:ExamListManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            SerialKey = "SerialKey",
            ExamListId = "ExamListId",
            ValidityType = "ValidityType",
            ValidityInDays = "ValidityInDays",
            KeyGenAsId = "KeyGenAsId",
            ValidDate = "ValidDate",
            Note = "Note",
            EStatus = "EStatus",
            IsActive = "IsActive",
            ExamListName = "ExamListName",
            ExamListDescription = "ExamListDescription",
            ExamListInsertDate = "ExamListInsertDate",
            ExamListInsertUserId = "ExamListInsertUserId",
            ExamListUpdateDate = "ExamListUpdateDate",
            ExamListUpdateUserId = "ExamListUpdateUserId",
            ExamListIsActive = "ExamListIsActive",
            ExamListTenantId = "ExamListTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
