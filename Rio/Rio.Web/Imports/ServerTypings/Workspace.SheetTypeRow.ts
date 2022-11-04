namespace Rio.Workspace {
    export interface SheetTypeRow {
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
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsActive?: number;
    }

    export namespace SheetTypeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.SheetType';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

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
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsActive = "IsActive"
        }
    }
}
