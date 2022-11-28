import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface ExamSectionRow {
    Id?: number;
    Name?: string;
    Description?: string;
    ExamId?: number;
    ParentId?: number;
    IsActive?: number;
    TenantId?: number;
    ExamCode?: string;
    ExamName?: string;
    ExamDescription?: string;
    ExamTotalMarks?: number;
    ExamNegativeMarks?: number;
    ExamOptionsAvailable?: number;
    ExamResultCriteria?: string;
    ExamInsertDate?: string;
    ExamInsertUserId?: number;
    ExamUpdateDate?: string;
    ExamUpdateUserId?: number;
    ExamIsActive?: number;
    ExamTenantId?: number;
    ParentName?: string;
    ParentDescription?: string;
    ParentExamId?: number;
    ParentParentId?: number;
    ParentInsertDate?: string;
    ParentInsertUserId?: number;
    ParentUpdateDate?: string;
    ParentUpdateUserId?: number;
    ParentIsActive?: number;
    ParentTenantId?: number;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ExamSectionRow {
    static readonly idProperty = 'Id';
    static readonly isActiveProperty = 'IsActive';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Workspace.ExamSection';
    static readonly lookupKey = 'Workspace.ExamSection';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ExamSectionRow>('Workspace.ExamSection') }
    static async getLookupAsync() { return getLookupAsync<ExamSectionRow>('Workspace.ExamSection') }

    static readonly deletePermission = 'Workspace:Exams:Modify';
    static readonly insertPermission = 'Workspace:Exams:Modify';
    static readonly readPermission = 'Workspace:Exams:View';
    static readonly updatePermission = 'Workspace:Exams:Modify';

    static readonly Fields = fieldsProxy<ExamSectionRow>();
}
