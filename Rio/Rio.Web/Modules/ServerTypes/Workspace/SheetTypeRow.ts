import { EPaperSize } from "./EPaperSize";
import { fieldsProxy } from "@serenity-is/corelib/q";

export interface SheetTypeRow {
    Id?: number;
    Name?: string;
    Description?: string;
    TotalQuestions?: number;
    EPaperSize?: EPaperSize;
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

export abstract class SheetTypeRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Workspace.SheetType';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SheetTypeRow>();
}
