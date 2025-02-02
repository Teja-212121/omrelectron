﻿namespace Rio.Administration {
    export interface TenantRow {
        TenantId?: number;
        TenantName?: string;
        EApprovalStatus?: Web.Enums.EApprovalStatus;
        IsActive?: number;
    }

    export namespace TenantRow {
        export const idProperty = 'TenantId';
        export const nameProperty = 'TenantName';
        export const localTextPrefix = 'Administration.Tenant';
        export const lookupKey = 'Administration.Tenant';

        export function getLookup(): Q.Lookup<TenantRow> {
            return Q.getLookup<TenantRow>('Administration.Tenant');
        }
        export const deletePermission = 'Administration:Tenants';
        export const insertPermission = 'Administration:Tenants';
        export const readPermission = 'Administration:Tenants';
        export const updatePermission = 'Administration:Tenants';

        export declare const enum Fields {
            TenantId = "TenantId",
            TenantName = "TenantName",
            EApprovalStatus = "EApprovalStatus",
            IsActive = "IsActive"
        }
    }
}
