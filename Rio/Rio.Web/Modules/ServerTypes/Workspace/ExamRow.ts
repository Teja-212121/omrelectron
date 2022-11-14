import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface ExamRow {
    Id?: number;
    Code?: string;
    Name?: string;
    Description?: string;
    TotalQuestions?: number;
    TotalMarks?: number;
    NegativeMarks?: number;
    OptionsAvailable?: number;
    ResultCriteria?: string;
    IsActive?: number;
    TenantId?: number;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ExamRow {
    static readonly idProperty = 'Id';
    static readonly isActiveProperty = 'IsActive';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Workspace.Exam';
    static readonly lookupKey = 'Workspace.Exam';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ExamRow>('Workspace.Exam') }
    static async getLookupAsync() { return getLookupAsync<ExamRow>('Workspace.Exam') }

    static readonly deletePermission = 'Workspace:Exams';
    static readonly insertPermission = 'Workspace:Exams';
    static readonly readPermission = 'Workspace:Exams';
    static readonly updatePermission = 'Workspace:Exams';

    static readonly Fields = fieldsProxy<ExamRow>();
}
