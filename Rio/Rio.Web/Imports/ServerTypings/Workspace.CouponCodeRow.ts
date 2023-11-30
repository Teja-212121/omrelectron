namespace Rio.Workspace {
    export interface CouponCodeRow {
        Id?: number;
        Code?: string;
        ExamListId?: number;
        ValidityType?: number;
        CountType?: number;
        Count?: number;
        ValidityInDays?: number;
        ValidDate?: string;
        ConsumedCount?: number;
        CouponValidityDate?: string;
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

    export namespace CouponCodeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Workspace.CouponCode';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

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
