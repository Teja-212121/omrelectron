namespace Rio.Workspace {
    export interface GroupRow {
        Id?: number;
        Name?: string;
        Description?: string;
        ParentId?: number;
        IsActive?: number;
        TenantId?: number;
        ParentName?: string;
        ParentDescription?: string;
        ParentParentId?: number;
        ParentInsertDate?: string;
        ParentInsertUserId?: number;
        ParentUpdateDate?: string;
        ParentUpdateUserId?: number;
        ParentIsActive?: number;
        ParentTenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace GroupRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.Group';
        export const lookupKey = 'Workspace.Group';

        export function getLookup(): Q.Lookup<GroupRow> {
            return Q.getLookup<GroupRow>('Workspace.Group');
        }
        export const deletePermission = 'Workspace:GroupStudents:Modify';
        export const insertPermission = 'Workspace:GroupStudents:Modify';
        export const readPermission = 'Workspace:GroupStudents:View';
        export const updatePermission = 'Workspace:GroupStudents:Modify';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            ParentId = "ParentId",
            IsActive = "IsActive",
            TenantId = "TenantId",
            ParentName = "ParentName",
            ParentDescription = "ParentDescription",
            ParentParentId = "ParentParentId",
            ParentInsertDate = "ParentInsertDate",
            ParentInsertUserId = "ParentInsertUserId",
            ParentUpdateDate = "ParentUpdateDate",
            ParentUpdateUserId = "ParentUpdateUserId",
            ParentIsActive = "ParentIsActive",
            ParentTenantId = "ParentTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
