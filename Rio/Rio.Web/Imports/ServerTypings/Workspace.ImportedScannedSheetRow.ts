namespace Rio.Workspace {
    export interface ImportedScannedSheetRow {
        Id?: string;
        SheetTypeId?: number;
        ScannedAt?: string;
        SheetNumber?: string;
        ScannedRollNo?: number;
        ScannedExamNo?: number;
        CorrectedRollNo?: number;
        CorrectedExamNo?: number;
        ExamSetNo?: number;
        ScannedImageSourcePath?: string;
        ScannedImage?: string;
        ScannedBatchId?: string;
        ScannedStatus?: number;
        ScannedSystemErrors?: string;
        ScannedUserErrors?: string;
        ScannedComments?: string;
        ResultProcessed?: boolean;
        IsActive?: number;
        TenantId?: number;
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
        ScannedBatchName?: string;
        ScannedBatchDescription?: string;
        ScannedBatchInsertDate?: string;
        ScannedBatchInsertUserId?: number;
        ScannedBatchUpdateDate?: string;
        ScannedBatchUpdateUserId?: number;
        ScannedBatchIsActive?: number;
        ScannedBatchTenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ImportedScannedSheetRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'SheetNumber';
        export const localTextPrefix = 'Workspace.ImportedScannedSheet';
        export const lookupKey = 'Workspace.ImportedScannedSheets';

        export function getLookup(): Q.Lookup<ImportedScannedSheetRow> {
            return Q.getLookup<ImportedScannedSheetRow>('Workspace.ImportedScannedSheets');
        }
        export const deletePermission = 'Workspace:ScannedData';
        export const insertPermission = 'Workspace:ScannedData';
        export const readPermission = 'Workspace:ScannedData';
        export const updatePermission = 'Workspace:ScannedData';

        export declare const enum Fields {
            Id = "Id",
            SheetTypeId = "SheetTypeId",
            ScannedAt = "ScannedAt",
            SheetNumber = "SheetNumber",
            ScannedRollNo = "ScannedRollNo",
            ScannedExamNo = "ScannedExamNo",
            CorrectedRollNo = "CorrectedRollNo",
            CorrectedExamNo = "CorrectedExamNo",
            ExamSetNo = "ExamSetNo",
            ScannedImageSourcePath = "ScannedImageSourcePath",
            ScannedImage = "ScannedImage",
            ScannedBatchId = "ScannedBatchId",
            ScannedStatus = "ScannedStatus",
            ScannedSystemErrors = "ScannedSystemErrors",
            ScannedUserErrors = "ScannedUserErrors",
            ScannedComments = "ScannedComments",
            ResultProcessed = "ResultProcessed",
            IsActive = "IsActive",
            TenantId = "TenantId",
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
            ScannedBatchName = "ScannedBatchName",
            ScannedBatchDescription = "ScannedBatchDescription",
            ScannedBatchInsertDate = "ScannedBatchInsertDate",
            ScannedBatchInsertUserId = "ScannedBatchInsertUserId",
            ScannedBatchUpdateDate = "ScannedBatchUpdateDate",
            ScannedBatchUpdateUserId = "ScannedBatchUpdateUserId",
            ScannedBatchIsActive = "ScannedBatchIsActive",
            ScannedBatchTenantId = "ScannedBatchTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
