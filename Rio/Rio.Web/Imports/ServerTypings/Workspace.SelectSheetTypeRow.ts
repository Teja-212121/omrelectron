namespace Rio.Workspace {
    export interface SelectSheetTypeRow {
        Id?: number;
        Name?: string;
        Description?: string;
        TotalQuestions?: number;
        EPaperSize?: number;
        HeightInPixel?: number;
        WidthInPixel?: number;
        SheetData?: string;
        SheetImage?: string;
        OverlayImage?: string;
        Synced?: boolean;
        IsPrivate?: boolean;
        PdfTemplate?: string;
        SheetNumber?: number;
        IsActive?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace SelectSheetTypeRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.SelectSheetType';
        export const deletePermission = 'Workspace:SheetType:Modify';
        export const insertPermission = 'Workspace:SheetType:Modify';
        export const readPermission = 'Workspace:SheetType:View';
        export const updatePermission = 'Workspace:SheetType:Modify';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            TotalQuestions = "TotalQuestions",
            EPaperSize = "EPaperSize",
            HeightInPixel = "HeightInPixel",
            WidthInPixel = "WidthInPixel",
            SheetData = "SheetData",
            SheetImage = "SheetImage",
            OverlayImage = "OverlayImage",
            Synced = "Synced",
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
