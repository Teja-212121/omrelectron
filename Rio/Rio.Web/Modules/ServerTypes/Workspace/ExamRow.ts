import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

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
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ExamRow {
    static readonly idProperty = 'Id';
    static readonly isActiveProperty = 'IsActive';
    static readonly nameProperty = 'ExamDisplayName';
    static readonly localTextPrefix = 'Workspace.Exam';
    static readonly lookupKey = 'Workspace.Exam';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ExamRow>('Workspace.Exam') }
    static async getLookupAsync() { return getLookupAsync<ExamRow>('Workspace.Exam') }

    static readonly deletePermission = 'Workspace:ExamsAndSectionManagement:Modify';
    static readonly insertPermission = 'Workspace:ExamsAndSectionManagement:Modify';
    static readonly readPermission = 'Workspace:ExamsAndSectionManagement:View';
    static readonly updatePermission = 'Workspace:ExamsAndSectionManagement:Modify';

    static readonly Fields = fieldsProxy<ExamRow>();
}
