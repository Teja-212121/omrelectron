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
        IsActive?: number;
        TenantId?: number;
        SelectedTenant?: number;
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
            IsActive = "IsActive",
            TenantId = "TenantId",
            SelectedTenant = "SelectedTenant",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
