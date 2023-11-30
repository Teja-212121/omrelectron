namespace Rio.Workspace {
    export interface SerialKeyRow {
        Id?: number;
        SerialKey?: string;
        ExamListId?: number;
        ValidityType?: number;
        ValidityInDays?: number;
        ValidDate?: string;
        Note?: string;
        EStatus?: number;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsActive?: number;
        ExamListName?: string;
        ExamListDescription?: string;
        ExamListInsertDate?: string;
        ExamListInsertUserId?: number;
        ExamListUpdateDate?: string;
        ExamListUpdateUserId?: number;
        ExamListIsActive?: number;
        ExamListTenantId?: number;
    }

    export namespace SerialKeyRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SerialKey';
        export const localTextPrefix = 'Workspace.SerialKey';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            SerialKey = "SerialKey",
            ExamListId = "ExamListId",
            ValidityType = "ValidityType",
            ValidityInDays = "ValidityInDays",
            ValidDate = "ValidDate",
            Note = "Note",
            EStatus = "EStatus",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsActive = "IsActive",
            ExamListName = "ExamListName",
            ExamListDescription = "ExamListDescription",
            ExamListInsertDate = "ExamListInsertDate",
            ExamListInsertUserId = "ExamListInsertUserId",
            ExamListUpdateDate = "ExamListUpdateDate",
            ExamListUpdateUserId = "ExamListUpdateUserId",
            ExamListIsActive = "ExamListIsActive",
            ExamListTenantId = "ExamListTenantId"
        }
    }
}
