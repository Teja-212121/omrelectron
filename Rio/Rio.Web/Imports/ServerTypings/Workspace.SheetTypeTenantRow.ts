namespace Rio.Workspace {
    export interface SheetTypeTenantRow {
        Id?: number;
        SheetTypeId?: number;
        TenantId?: number;
        IsDefault?: boolean;
        DisplayOrder?: number;
        SheetDesignPdf?: string;
        IsActive?: number;
        SheetTypeDisplayName?: string;
        SheetTypeName?: string;
        SheetTypeDescription?: string;
        SheetTypeTotalQuestions?: number;
        SheetTypeEPaperSize?: number;
        SheetTypeHeightInPixel?: number;
        SheetTypeWidthInPixel?: number;
        SheetTypeSheetData?: string;
        SheetTypeSheetImage?: string;
        SheetTypeOverlayImage?: string;
        SheetTypeSynced?: boolean;
        SheetTypeIsPrivate?: boolean;
        SheetTypePdfTemplate?: string;
        SheetTypeSheetNumber?: number;
        SheetTypeInsertDate?: string;
        SheetTypeInsertUserId?: number;
        SheetTypeUpdateDate?: string;
        SheetTypeUpdateUserId?: number;
        SheetTypeIsActive?: number;
        TenantTenantName?: string;
        RowIds?: string;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace SheetTypeTenantRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'SheetTypeDisplayName';
        export const localTextPrefix = 'Workspace.SheetTypeTenant';
        export const lookupKey = 'Workspace.SheetTypesTenants';

        export function getLookup(): Q.Lookup<SheetTypeTenantRow> {
            return Q.getLookup<SheetTypeTenantRow>('Workspace.SheetTypesTenants');
        }
        export const deletePermission = 'Workspace:SheetTypeTenant:Modify';
        export const insertPermission = 'Workspace:SheetTypeTenant:Modify';
        export const readPermission = 'Workspace:SheetTypeTenant:View';
        export const updatePermission = 'Workspace:SheetTypeTenant:Modify';

        export declare const enum Fields {
            Id = "Id",
            SheetTypeId = "SheetTypeId",
            TenantId = "TenantId",
            IsDefault = "IsDefault",
            DisplayOrder = "DisplayOrder",
            SheetDesignPdf = "SheetDesignPdf",
            IsActive = "IsActive",
            SheetTypeDisplayName = "SheetTypeDisplayName",
            SheetTypeName = "SheetTypeName",
            SheetTypeDescription = "SheetTypeDescription",
            SheetTypeTotalQuestions = "SheetTypeTotalQuestions",
            SheetTypeEPaperSize = "SheetTypeEPaperSize",
            SheetTypeHeightInPixel = "SheetTypeHeightInPixel",
            SheetTypeWidthInPixel = "SheetTypeWidthInPixel",
            SheetTypeSheetData = "SheetTypeSheetData",
            SheetTypeSheetImage = "SheetTypeSheetImage",
            SheetTypeOverlayImage = "SheetTypeOverlayImage",
            SheetTypeSynced = "SheetTypeSynced",
            SheetTypeIsPrivate = "SheetTypeIsPrivate",
            SheetTypePdfTemplate = "SheetTypePdfTemplate",
            SheetTypeSheetNumber = "SheetTypeSheetNumber",
            SheetTypeInsertDate = "SheetTypeInsertDate",
            SheetTypeInsertUserId = "SheetTypeInsertUserId",
            SheetTypeUpdateDate = "SheetTypeUpdateDate",
            SheetTypeUpdateUserId = "SheetTypeUpdateUserId",
            SheetTypeIsActive = "SheetTypeIsActive",
            TenantTenantName = "TenantTenantName",
            RowIds = "RowIds",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
