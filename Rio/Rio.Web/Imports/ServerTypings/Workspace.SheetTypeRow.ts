namespace Rio.Workspace {
    export interface SheetTypeRow {
        Id?: number;
        Name?: string;
        Description?: string;
        TotalQuestions?: number;
        EPaperSize?: Workspace.enums.EPaperSize;
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

    export namespace SheetTypeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.SheetType';
        export const lookupKey = 'Workspace.SheetTypes';

        export function getLookup(): Q.Lookup<SheetTypeRow> {
            return Q.getLookup<SheetTypeRow>('Workspace.SheetTypes');
        }
        export const deletePermission = 'Workspace:Sheets';
        export const insertPermission = 'Workspace:Sheets';
        export const readPermission = 'Workspace:Sheets';
        export const updatePermission = 'Workspace:Sheets';

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
