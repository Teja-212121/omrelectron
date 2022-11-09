namespace Rio.Workspace {
    export interface ImportedScannedQuestionRow {
        Id?: number;
        ScannedSheetId?: string;
        QuestionIndex?: number;
        ScannedOptions?: number;
        CorrectedOptions?: number;
        IsActive?: number;
        TenantId?: number;
        ScannedSheetSheetTypeId?: number;
        ScannedSheetScannedAt?: string;
        ScannedSheetSheetNumber?: string;
        ScannedSheetScannedRollNo?: number;
        ScannedSheetScannedExamNo?: number;
        ScannedSheetCorrectedRollNo?: number;
        ScannedSheetCorrectedExamNo?: number;
        ScannedSheetExamSetNo?: number;
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
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
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
