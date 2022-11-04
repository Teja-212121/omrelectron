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
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        IsActive?: number;
        TenantId?: number;
    }

    export namespace ExamRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Workspace.Exam';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Code = "Code",
            Name = "Name",
            Description = "Description",
            TotalMarks = "TotalMarks",
            NegativeMarks = "NegativeMarks",
            OptionsAvailable = "OptionsAvailable",
            ResultCriteria = "ResultCriteria",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            IsActive = "IsActive",
            TenantId = "TenantId"
        }
    }
}
