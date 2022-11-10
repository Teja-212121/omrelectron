﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

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

export abstract class GroupRow {
    static readonly idProperty = 'Id';
    static readonly isActiveProperty = 'IsActive';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Workspace.Group';
    static readonly lookupKey = 'Workspace.Group';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<GroupRow>('Workspace.Group') }
    static async getLookupAsync() { return getLookupAsync<GroupRow>('Workspace.Group') }

    static readonly deletePermission = 'Workspace:GroupStudents';
    static readonly insertPermission = 'Workspace:GroupStudents';
    static readonly readPermission = 'Workspace:GroupStudents';
    static readonly updatePermission = 'Workspace:GroupStudents';

    static readonly Fields = fieldsProxy<GroupRow>();
}
