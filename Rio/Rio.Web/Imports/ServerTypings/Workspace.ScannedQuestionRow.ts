namespace Rio.Workspace {
    export interface ScannedQuestionRow {
        Id?: number;
        ScannedBatchId?: string;
        ScannedSheetId?: string;
        QuestionIndex?: number;
        ScannedOptions?: string;
        CorrectedOptions?: string;
        IsActive?: number;
        TenantId?: number;
        ScannedSheetSheetTypeId?: number;
        ScannedSheetScannedAt?: string;
        ScannedSheetSheetNumber?: string;
        ScannedSheetScannedRollNo?: string;
        ScannedSheetScannedExamNo?: string;
        ScannedSheetCorrectedRollNo?: string;
        ScannedSheetCorrectedExamNo?: string;
        ScannedSheetExamSetNo?: string;
        ScannedSheetScannedImageSourcePath?: string;
        ScannedSheetScannedImage?: string;
        ScannedSheetImageBase64?: string;
        ScannedSheetScannedBatchId?: string;
        ScannedSheetScannedStatus?: number;
        ScannedSheetScannedSystemErrors?: string;
        ScannedSheetScannedUserErrors?: string;
        ScannedSheetScannedComments?: string;
        ScannedSheetResultProcessed?: boolean;
        ScannedSheetInsertDate?: string;
        ScannedSheetInsertUserId?: number;
        ScannedSheetUpdateDate?: string;
        ScannedSheetUpdateUserId?: number;
        ScannedSheetIsActive?: number;
        ScannedSheetOCRData1Key?: string;
        ScannedSheetOCRData1Value?: string;
        ScannedSheetTenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ScannedQuestionRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const localTextPrefix = 'Workspace.ScannedQuestion';
        export const deletePermission = 'Workspace:ScannedDataManagement:Modify';
        export const insertPermission = 'Workspace:ScannedDataManagement:Modify';
        export const readPermission = 'Workspace:ScannedDataManagement:View';
        export const updatePermission = 'Workspace:ScannedDataManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            ScannedBatchId = "ScannedBatchId",
            ScannedSheetId = "ScannedSheetId",
            QuestionIndex = "QuestionIndex",
            ScannedOptions = "ScannedOptions",
            CorrectedOptions = "CorrectedOptions",
            IsActive = "IsActive",
            TenantId = "TenantId",
            ScannedSheetSheetTypeId = "ScannedSheetSheetTypeId",
            ScannedSheetScannedAt = "ScannedSheetScannedAt",
            ScannedSheetSheetNumber = "ScannedSheetSheetNumber",
            ScannedSheetScannedRollNo = "ScannedSheetScannedRollNo",
            ScannedSheetScannedExamNo = "ScannedSheetScannedExamNo",
            ScannedSheetCorrectedRollNo = "ScannedSheetCorrectedRollNo",
            ScannedSheetCorrectedExamNo = "ScannedSheetCorrectedExamNo",
            ScannedSheetExamSetNo = "ScannedSheetExamSetNo",
            ScannedSheetScannedImageSourcePath = "ScannedSheetScannedImageSourcePath",
            ScannedSheetScannedImage = "ScannedSheetScannedImage",
            ScannedSheetImageBase64 = "ScannedSheetImageBase64",
            ScannedSheetScannedBatchId = "ScannedSheetScannedBatchId",
            ScannedSheetScannedStatus = "ScannedSheetScannedStatus",
            ScannedSheetScannedSystemErrors = "ScannedSheetScannedSystemErrors",
            ScannedSheetScannedUserErrors = "ScannedSheetScannedUserErrors",
            ScannedSheetScannedComments = "ScannedSheetScannedComments",
            ScannedSheetResultProcessed = "ScannedSheetResultProcessed",
            ScannedSheetInsertDate = "ScannedSheetInsertDate",
            ScannedSheetInsertUserId = "ScannedSheetInsertUserId",
            ScannedSheetUpdateDate = "ScannedSheetUpdateDate",
            ScannedSheetUpdateUserId = "ScannedSheetUpdateUserId",
            ScannedSheetIsActive = "ScannedSheetIsActive",
            ScannedSheetOCRData1Key = "ScannedSheetOCRData1Key",
            ScannedSheetOCRData1Value = "ScannedSheetOCRData1Value",
            ScannedSheetTenantId = "ScannedSheetTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
