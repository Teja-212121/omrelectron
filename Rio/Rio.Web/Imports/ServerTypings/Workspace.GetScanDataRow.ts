namespace Rio.Workspace {
    export interface GetScanDataRow {
        Id?: number;
        StudentId?: number;
        ExamId?: number;
        NegativeMarks?: number;
        QuestionIndex?: number;
        TenantId?: number;
        ScanSheetId?: string;
        ScanBatchId?: string;
        Score?: string;
        CorrectedRollNo?: string;
        SheetNumber?: string;
        RightOptions?: string;
        CorrectedOptions?: string;
        RuleTypeId?: number;
    }

    export namespace GetScanDataRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SheetNumber';
        export const localTextPrefix = 'Workspace.GetScanData';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            StudentId = "StudentId",
            ExamId = "ExamId",
            NegativeMarks = "NegativeMarks",
            QuestionIndex = "QuestionIndex",
            TenantId = "TenantId",
            ScanSheetId = "ScanSheetId",
            ScanBatchId = "ScanBatchId",
            Score = "Score",
            CorrectedRollNo = "CorrectedRollNo",
            SheetNumber = "SheetNumber",
            RightOptions = "RightOptions",
            CorrectedOptions = "CorrectedOptions",
            RuleTypeId = "RuleTypeId"
        }
    }
}
