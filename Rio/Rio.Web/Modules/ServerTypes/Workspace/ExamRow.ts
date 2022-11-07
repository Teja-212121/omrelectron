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
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamRow>();
}
