namespace Rio.Workspace {
    export interface ExamListRow {
        Id?: number;
        Name?: string;
        Description?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsActive?: number;
        TenantId?: number;
        TenantTenantName?: string;
        TenantEApprovalStatus?: number;
        TenantIsActive?: number;
    }

    export namespace ExamListRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.ExamList';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsActive = "IsActive",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName",
            TenantEApprovalStatus = "TenantEApprovalStatus",
            TenantIsActive = "TenantIsActive"
        }
    }
}
