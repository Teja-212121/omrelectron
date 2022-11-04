import { fieldsProxy } from "@serenity-is/corelib/q";

export interface GroupRow {
    Id?: number;
    Name?: string;
    Description?: string;
    ParentId?: number;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
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
}

export abstract class GroupRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Workspace.Group';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<GroupRow>();
}
