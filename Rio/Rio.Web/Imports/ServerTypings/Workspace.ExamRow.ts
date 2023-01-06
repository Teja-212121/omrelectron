namespace Rio.Workspace {
    export interface ExamRow {
        Id?: number;
        Code?: string;
        Name?: string;
        ExamDisplayName?: string;
        Description?: string;
        TotalQuestions?: number;
        TotalMarks?: number;
        NegativeMarks?: number;
        OptionsAvailable?: number;
        ResultCriteria?: string;
        QuestionPaper?: string;
        ModelAnswer?: string;
        IsActive?: number;
        TenantId?: number;
        SelectedTenant?: number;
        SheetTypeId?: number;
        SheetTypeDisplayName?: string;
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
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ExamRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'ExamDisplayName';
        export const localTextPrefix = 'Workspace.Exam';
        export const lookupKey = 'Workspace.Exam';

        export function getLookup(): Q.Lookup<ExamRow> {
            return Q.getLookup<ExamRow>('Workspace.Exam');
        }
        export const deletePermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const insertPermission = 'Workspace:ExamsAndSectionManagement:Modify';
        export const readPermission = 'Workspace:ExamsAndSectionManagement:View';
        export const updatePermission = 'Workspace:ExamsAndSectionManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            Code = "Code",
            Name = "Name",
            ExamDisplayName = "ExamDisplayName",
            Description = "Description",
            TotalQuestions = "TotalQuestions",
            TotalMarks = "TotalMarks",
            NegativeMarks = "NegativeMarks",
            OptionsAvailable = "OptionsAvailable",
            ResultCriteria = "ResultCriteria",
            QuestionPaper = "QuestionPaper",
            ModelAnswer = "ModelAnswer",
            IsActive = "IsActive",
            TenantId = "TenantId",
            SelectedTenant = "SelectedTenant",
            SheetTypeId = "SheetTypeId",
            SheetTypeDisplayName = "SheetTypeDisplayName",
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
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
