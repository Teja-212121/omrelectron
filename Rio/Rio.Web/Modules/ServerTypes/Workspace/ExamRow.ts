import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ExamRow {
    Id?: number;
    Code?: string;
    Name?: string;
    Description?: string;
    TotalMarks?: number;
    NegativeMarks?: number;
    OptionsAvailable?: number;
    ResultCriteria?: string;
    InsertDate?: string;
    InsertUserId?: number;
    UpdateDate?: string;
    UpdateUserId?: number;
    IsActive?: number;
    TenantId?: number;
}

export abstract class ExamRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Code';
    static readonly localTextPrefix = 'Workspace.Exam';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamRow>();
}
