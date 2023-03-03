namespace Rio.Workspace {
    export interface SheetTypeRow {
        Id?: number;
        Name?: string;
        SheetTypeDisplayName?: string;
        Description?: string;
        TotalQuestions?: number;
        EPaperSize?: Workspace.enums.EPaperSize;
        HeightInPixel?: number;
        WidthInPixel?: number;
        SheetData?: string;
        SheetImage?: string;
        OverlayImage?: string;
        OverlayImageOpenCV?: string;
        Synced?: boolean;
        IsPublic?: boolean;
        IsPrivate?: boolean;
        PdfTemplate?: string;
        SheetNumber?: number;
        IsActive?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace SheetTypeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SheetTypeDisplayName';
        export const localTextPrefix = 'Workspace.SheetType';
        export const lookupKey = 'Workspace.SheetTypes';

        export function getLookup(): Q.Lookup<SheetTypeRow> {
            return Q.getLookup<SheetTypeRow>('Workspace.SheetTypes');
        }
        export const deletePermission = 'Workspace:SheetType:Modify';
        export const insertPermission = 'Workspace:SheetType:Modify';
        export const readPermission = 'Workspace:SheetType:View';
        export const updatePermission = 'Workspace:SheetType:Modify';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            SheetTypeDisplayName = "SheetTypeDisplayName",
            Description = "Description",
            TotalQuestions = "TotalQuestions",
            EPaperSize = "EPaperSize",
            HeightInPixel = "HeightInPixel",
            WidthInPixel = "WidthInPixel",
            SheetData = "SheetData",
            SheetImage = "SheetImage",
            OverlayImage = "OverlayImage",
            OverlayImageOpenCV = "OverlayImageOpenCV",
            Synced = "Synced",
            IsPublic = "IsPublic",
            IsPrivate = "IsPrivate",
            PdfTemplate = "PdfTemplate",
            SheetNumber = "SheetNumber",
            IsActive = "IsActive",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
