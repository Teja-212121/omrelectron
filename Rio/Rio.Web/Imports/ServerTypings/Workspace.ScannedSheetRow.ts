﻿namespace Rio.Workspace {
    export interface ScannedSheetRow {
        Id?: string;
        SheetTypeId?: number;
        ScannedAt?: string;
        ScannedSheetDisplayName?: string;
        SheetNumber?: string;
        ScannedRollNo?: string;
        ScannedExamNo?: string;
        CorrectedRollNo?: string;
        CorrectedExamNo?: string;
        ExamSetNo?: string;
        ScannedImageSourcePath?: string;
        ScannedImage?: string;
        ScannedBatchId?: string;
        ScannedStatus?: Workspace.enums.EScannedStatus;
        ScannedSystemErrors?: string;
        ScannedUserErrors?: string;
        ScannedComments?: string;
        ImageBase64?: string;
        ResultProcessed?: boolean;
        IsRectified?: boolean;
        IsActive?: number;
        TenantId?: number;
        OCRData1Key?: string;
        OCRData1Value?: string;
        OCRData2Key?: string;
        OCRData2Value?: string;
        OCRData3Key?: string;
        OCRData3Value?: string;
        ICRData1Key?: string;
        ICRData1Value?: string;
        ICRData2Key?: string;
        ICRData2Value?: string;
        ICRData3Key?: string;
        ICRData3Value?: string;
        ScannedQuestions?: ScannedQuestionRow[];
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

    export namespace ScannedSheetRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'ScannedSheetDisplayName';
        export const localTextPrefix = 'Workspace.ScannedSheet';
        export const lookupKey = 'Workspace.ScannedSheets';

        export function getLookup(): Q.Lookup<ScannedSheetRow> {
            return Q.getLookup<ScannedSheetRow>('Workspace.ScannedSheets');
        }
        export const deletePermission = 'Workspace:ScannedDataManagement:Modify';
        export const insertPermission = 'Workspace:ScannedDataManagement:Modify';
        export const readPermission = 'Workspace:ScannedDataManagement:View';
        export const updatePermission = 'Workspace:ScannedDataManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            SheetTypeId = "SheetTypeId",
            ScannedAt = "ScannedAt",
            ScannedSheetDisplayName = "ScannedSheetDisplayName",
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
            ImageBase64 = "ImageBase64",
            ResultProcessed = "ResultProcessed",
            IsRectified = "IsRectified",
            IsActive = "IsActive",
            TenantId = "TenantId",
            OCRData1Key = "OCRData1Key",
            OCRData1Value = "OCRData1Value",
            OCRData2Key = "OCRData2Key",
            OCRData2Value = "OCRData2Value",
            OCRData3Key = "OCRData3Key",
            OCRData3Value = "OCRData3Value",
            ICRData1Key = "ICRData1Key",
            ICRData1Value = "ICRData1Value",
            ICRData2Key = "ICRData2Key",
            ICRData2Value = "ICRData2Value",
            ICRData3Key = "ICRData3Key",
            ICRData3Value = "ICRData3Value",
            ScannedQuestions = "ScannedQuestions",
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
