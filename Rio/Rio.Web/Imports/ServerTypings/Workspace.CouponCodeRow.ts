namespace Rio.Workspace {
    export interface CouponCodeRow {
        Id?: number;
        Code?: string;
        ExamListId?: number;
        ValidityType?: Web.Enums.EValidityType;
        CountType?: Web.Enums.ECountType;
        Count?: number;
        ValidityInDays?: number;
        ValidDate?: string;
        ConsumedCount?: number;
        CouponValidityDate?: string;
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

    export namespace CouponCodeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Workspace.CouponCode';
        export const deletePermission = 'Workspace:ExamListManagement:Modify';
        export const insertPermission = 'Workspace:ExamListManagement:Modify';
        export const readPermission = 'Workspace:ExamListManagement:View';
        export const updatePermission = 'Workspace:ExamListManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            Code = "Code",
            ExamListId = "ExamListId",
            ValidityType = "ValidityType",
            CountType = "CountType",
            Count = "Count",
            ValidityInDays = "ValidityInDays",
            ValidDate = "ValidDate",
            ConsumedCount = "ConsumedCount",
            CouponValidityDate = "CouponValidityDate",
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
