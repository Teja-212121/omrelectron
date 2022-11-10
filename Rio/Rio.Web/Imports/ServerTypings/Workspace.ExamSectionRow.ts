namespace Rio.Workspace {
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

    export namespace ExamSectionRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.ExamSection';
        export const lookupKey = 'Workspace.ExamSection';

        export function getLookup(): Q.Lookup<ExamSectionRow> {
            return Q.getLookup<ExamSectionRow>('Workspace.ExamSection');
        }
        export const deletePermission = 'Workspace:Exams';
        export const insertPermission = 'Workspace:Exams';
        export const readPermission = 'Workspace:Exams';
        export const updatePermission = 'Workspace:Exams';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            ExamId = "ExamId",
            ParentId = "ParentId",
            IsActive = "IsActive",
            TenantId = "TenantId",
            ExamCode = "ExamCode",
            ExamName = "ExamName",
            ExamDescription = "ExamDescription",
            ExamTotalMarks = "ExamTotalMarks",
            ExamNegativeMarks = "ExamNegativeMarks",
            ExamOptionsAvailable = "ExamOptionsAvailable",
            ExamResultCriteria = "ExamResultCriteria",
            ExamInsertDate = "ExamInsertDate",
            ExamInsertUserId = "ExamInsertUserId",
            ExamUpdateDate = "ExamUpdateDate",
            ExamUpdateUserId = "ExamUpdateUserId",
            ExamIsActive = "ExamIsActive",
            ExamTenantId = "ExamTenantId",
            ParentName = "ParentName",
            ParentDescription = "ParentDescription",
            ParentExamId = "ParentExamId",
            ParentParentId = "ParentParentId",
            ParentInsertDate = "ParentInsertDate",
            ParentInsertUserId = "ParentInsertUserId",
            ParentUpdateDate = "ParentUpdateDate",
            ParentUpdateUserId = "ParentUpdateUserId",
            ParentIsActive = "ParentIsActive",
            ParentTenantId = "ParentTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
