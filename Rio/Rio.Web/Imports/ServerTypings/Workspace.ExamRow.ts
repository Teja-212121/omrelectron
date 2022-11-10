namespace Rio.Workspace {
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

    export namespace ExamRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.Exam';
        export const lookupKey = 'Workspace.Exam';

        export function getLookup(): Q.Lookup<ExamRow> {
            return Q.getLookup<ExamRow>('Workspace.Exam');
        }
        export const deletePermission = 'Workspace:Exams';
        export const insertPermission = 'Workspace:Exams';
        export const readPermission = 'Workspace:Exams';
        export const updatePermission = 'Workspace:Exams';

        export declare const enum Fields {
            Id = "Id",
            Code = "Code",
            Name = "Name",
            Description = "Description",
            TotalMarks = "TotalMarks",
            NegativeMarks = "NegativeMarks",
            OptionsAvailable = "OptionsAvailable",
            ResultCriteria = "ResultCriteria",
            IsActive = "IsActive",
            TenantId = "TenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
