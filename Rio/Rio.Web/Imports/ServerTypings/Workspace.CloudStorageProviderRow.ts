namespace Rio.Workspace {
    export interface CloudStorageProviderRow {
        Id?: string;
        Name?: string;
        Description?: string;
        NumberOfParameter?: number;
        TenantId?: number;
        Parameter1Title?: string;
        Parameter2Title?: string;
        Parameter3Title?: string;
        Parameter4Title?: string;
        Parameter5Title?: string;
        Parameter6Title?: string;
        Parameter7Title?: string;
        Parameter8Title?: string;
        Parameter9Title?: string;
        Parameter10Title?: string;
        ParameterProvider?: string;
        TenantTenantName?: string;
        TenantEApprovalStatus?: number;
        TenantIsActive?: number;
    }

    export namespace CloudStorageProviderRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.CloudStorageProvider';
        export const lookupKey = 'Workspace.CloudStorageProvider';

        export function getLookup(): Q.Lookup<CloudStorageProviderRow> {
            return Q.getLookup<CloudStorageProviderRow>('Workspace.CloudStorageProvider');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            NumberOfParameter = "NumberOfParameter",
            TenantId = "TenantId",
            Parameter1Title = "Parameter1Title",
            Parameter2Title = "Parameter2Title",
            Parameter3Title = "Parameter3Title",
            Parameter4Title = "Parameter4Title",
            Parameter5Title = "Parameter5Title",
            Parameter6Title = "Parameter6Title",
            Parameter7Title = "Parameter7Title",
            Parameter8Title = "Parameter8Title",
            Parameter9Title = "Parameter9Title",
            Parameter10Title = "Parameter10Title",
            ParameterProvider = "ParameterProvider",
            TenantTenantName = "TenantTenantName",
            TenantEApprovalStatus = "TenantEApprovalStatus",
            TenantIsActive = "TenantIsActive"
        }
    }
}
