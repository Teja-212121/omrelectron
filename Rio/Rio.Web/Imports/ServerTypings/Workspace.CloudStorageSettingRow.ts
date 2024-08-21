namespace Rio.Workspace {
    export interface CloudStorageSettingRow {
        Id?: number;
        CloudStorageProvidersId?: string;
        TenantId?: number;
        Parameter1?: string;
        Parameter2?: string;
        Parameter3?: string;
        Parameter4?: string;
        Parameter5?: string;
        Parameter6?: string;
        Parameter7?: string;
        Parameter8?: string;
        Parameter9?: string;
        Parameter10?: string;
        ParameterProvider?: string;
        CloudStorageProvidersName?: string;
        CloudStorageProvidersDescription?: string;
        CloudStorageProvidersNumberOfParameter?: number;
        CloudStorageProvidersTenantId?: number;
        CloudStorageProvidersParameter1Title?: string;
        CloudStorageProvidersParameter2Title?: string;
        CloudStorageProvidersParameter3Title?: string;
        CloudStorageProvidersParameter4Title?: string;
        CloudStorageProvidersParameter5Title?: string;
        CloudStorageProvidersParameter6Title?: string;
        CloudStorageProvidersParameter7Title?: string;
        CloudStorageProvidersParameter8Title?: string;
        CloudStorageProvidersParameter9Title?: string;
        CloudStorageProvidersParameter10Title?: string;
        CloudStorageProvidersParameterProvider?: string;
        TenantTenantName?: string;
        TenantEApprovalStatus?: number;
        TenantIsActive?: number;
    }

    export namespace CloudStorageSettingRow {
        export const idProperty = 'Id';
        export const nameProperty = 'CloudStorageProvidersId';
        export const localTextPrefix = 'Workspace.CloudStorageSetting';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            CloudStorageProvidersId = "CloudStorageProvidersId",
            TenantId = "TenantId",
            Parameter1 = "Parameter1",
            Parameter2 = "Parameter2",
            Parameter3 = "Parameter3",
            Parameter4 = "Parameter4",
            Parameter5 = "Parameter5",
            Parameter6 = "Parameter6",
            Parameter7 = "Parameter7",
            Parameter8 = "Parameter8",
            Parameter9 = "Parameter9",
            Parameter10 = "Parameter10",
            ParameterProvider = "ParameterProvider",
            CloudStorageProvidersName = "CloudStorageProvidersName",
            CloudStorageProvidersDescription = "CloudStorageProvidersDescription",
            CloudStorageProvidersNumberOfParameter = "CloudStorageProvidersNumberOfParameter",
            CloudStorageProvidersTenantId = "CloudStorageProvidersTenantId",
            CloudStorageProvidersParameter1Title = "CloudStorageProvidersParameter1Title",
            CloudStorageProvidersParameter2Title = "CloudStorageProvidersParameter2Title",
            CloudStorageProvidersParameter3Title = "CloudStorageProvidersParameter3Title",
            CloudStorageProvidersParameter4Title = "CloudStorageProvidersParameter4Title",
            CloudStorageProvidersParameter5Title = "CloudStorageProvidersParameter5Title",
            CloudStorageProvidersParameter6Title = "CloudStorageProvidersParameter6Title",
            CloudStorageProvidersParameter7Title = "CloudStorageProvidersParameter7Title",
            CloudStorageProvidersParameter8Title = "CloudStorageProvidersParameter8Title",
            CloudStorageProvidersParameter9Title = "CloudStorageProvidersParameter9Title",
            CloudStorageProvidersParameter10Title = "CloudStorageProvidersParameter10Title",
            CloudStorageProvidersParameterProvider = "CloudStorageProvidersParameterProvider",
            TenantTenantName = "TenantTenantName",
            TenantEApprovalStatus = "TenantEApprovalStatus",
            TenantIsActive = "TenantIsActive"
        }
    }
}
