namespace Rio.Workspace {
    export interface ExamListRow {
        Id?: number;
        Name?: string;
        Description?: string;
        Thumbnail?: string;
        IsActive?: number;
        TenantId?: number;
        TenantTenantName?: string;
        TenantEApprovalStatus?: number;
        TenantIsActive?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ExamListRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.ExamList';
        export const lookupKey = 'Workspace.ExamList';

        export function getLookup(): Q.Lookup<ExamListRow> {
            return Q.getLookup<ExamListRow>('Workspace.ExamList');
        }
        export const deletePermission = 'Workspace:ExamListManagement:Modify';
        export const insertPermission = 'Workspace:ExamListManagement:Modify';
        export const readPermission = 'Workspace:ExamListManagement:View';
        export const updatePermission = 'Workspace:ExamListManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            Thumbnail = "Thumbnail",
            IsActive = "IsActive",
            TenantId = "TenantId",
            TenantTenantName = "TenantTenantName",
            TenantEApprovalStatus = "TenantEApprovalStatus",
            TenantIsActive = "TenantIsActive",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
