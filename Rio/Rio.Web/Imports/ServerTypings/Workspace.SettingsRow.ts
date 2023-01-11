namespace Rio.Workspace {
    export interface SettingsRow {
        Id?: number;
        Host?: string;
        Port?: number;
        UseSsl?: number;
        From?: string;
        UserName?: string;
        Password?: string;
        ApiKey?: string;
        Sender?: string;
        GatewayUrl?: string;
        IsActive?: number;
        TenantId?: number;
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
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

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
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
