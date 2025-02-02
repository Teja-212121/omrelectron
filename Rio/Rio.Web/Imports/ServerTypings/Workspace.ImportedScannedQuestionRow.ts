﻿namespace Rio.Workspace {
    export interface ImportedScannedQuestionRow {
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
        ScannedSheetTenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ImportedScannedQuestionRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const localTextPrefix = 'Workspace.ImportedScannedQuestion';
        export const deletePermission = 'Workspace:ImportedDataManagement:Modify';
        export const insertPermission = 'Workspace:ImportedDataManagement:Modify';
        export const readPermission = 'Workspace:ImportedDataManagement:View';
        export const updatePermission = 'Workspace:ImportedDataManagement:Modify';

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
            ScannedSheetTenantId = "ScannedSheetTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
