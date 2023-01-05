namespace Rio.ResultReportView {
    export interface ResultReportRow {
        Id?: number;
        ScannedSheetId?: string;
        RollNumber?: string;
        ExamId?: number;
        ExamCode?: string;
        QuestionIndex?: number;
        IsAttempted?: number;
        IsCorrect?: number;
        RightOptions?: string;
        CorrectedOptions?: string;
        Score?: string;
        ObtainedMarks?: string;
    }

    export namespace ResultReportRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ExamCode';
        export const localTextPrefix = 'ResultReportView.ResultReport';
        export const deletePermission = 'Workspace:General';
        export const insertPermission = 'Workspace:General';
        export const readPermission = 'Workspace:General';
        export const updatePermission = 'Workspace:General';

        export declare const enum Fields {
            Id = "Id",
            ScannedSheetId = "ScannedSheetId",
            RollNumber = "RollNumber",
            ExamId = "ExamId",
            ExamCode = "ExamCode",
            QuestionIndex = "QuestionIndex",
            IsAttempted = "IsAttempted",
            IsCorrect = "IsCorrect",
            RightOptions = "RightOptions",
            CorrectedOptions = "CorrectedOptions",
            Score = "Score",
            ObtainedMarks = "ObtainedMarks"
        }
    }
}
