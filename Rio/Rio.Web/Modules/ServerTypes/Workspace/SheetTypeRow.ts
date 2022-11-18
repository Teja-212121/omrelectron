import { EPaperSize } from "./enums.EPaperSize";
import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

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
    static readonly lookupKey = 'Workspace.SheetTypes';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<SheetTypeRow>('Workspace.SheetTypes') }
    static async getLookupAsync() { return getLookupAsync<SheetTypeRow>('Workspace.SheetTypes') }

    static readonly deletePermission = 'Workspace:Sheets:SheetType:Modify';
    static readonly insertPermission = 'Workspace:Sheets:SheetType:Modify';
    static readonly readPermission = 'Workspace:Sheets:SheetType:Read';
    static readonly updatePermission = 'Workspace:Sheets:SheetType:Modify';

    static readonly Fields = fieldsProxy<SheetTypeRow>();
}
