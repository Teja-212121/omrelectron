namespace Rio.Workspace {
    export interface SettingsRow {
        Id?: number;
        Host?: string;
        Port?: number;
        UseSsl?: boolean;
        From?: string;
        UserName?: string;
        Password?: string;
        ApiKey?: string;
        Sender?: string;
        GatewayUrl?: string;
        IsActive?: number;
        TenantId?: number;
        UseXOAUTH2?: boolean;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace SettingsRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Host';
        export const localTextPrefix = 'Workspace.Settings';
        export const deletePermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const insertPermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const readPermission = 'Workspace:ExamsAndSectionManagement:View';
        export const updatePermission = 'Workspace:ExamsAndSectionManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            Host = "Host",
            Port = "Port",
            UseSsl = "UseSsl",
            From = "From",
            UserName = "UserName",
            Password = "Password",
            ApiKey = "ApiKey",
            Sender = "Sender",
            GatewayUrl = "GatewayUrl",
            IsActive = "IsActive",
            TenantId = "TenantId",
            UseXOAUTH2 = "UseXOAUTH2",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
