namespace Rio.Workspace {
    export interface TheoryExamsRow {
        Id?: number;
        RowIds?: string;
        Code?: string;
        Name?: string;
        Description?: string;
        TotalMarks?: number;
        IsActive?: number;
        TenantId?: number;
        ExamSections?: TheoryExamSectionsRow[];
        ExamQuestions?: TheoryExamQuestionsRow[];
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace TheoryExamsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Workspace.TheoryExams';
        export const lookupKey = 'Workspace.TheoryExams';

        export function getLookup(): Q.Lookup<TheoryExamsRow> {
            return Q.getLookup<TheoryExamsRow>('Workspace.TheoryExams');
        }
        export const deletePermission = 'Workspace:TheoryExamManagement:Modify';
        export const insertPermission = 'Workspace:TheoryExamManagement:Modify';
        export const readPermission = 'Workspace:TheoryExamManagement:View';
        export const updatePermission = 'Workspace:TheoryExamManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            RowIds = "RowIds",
            Code = "Code",
            Name = "Name",
            Description = "Description",
            TotalMarks = "TotalMarks",
            IsActive = "IsActive",
            TenantId = "TenantId",
            ExamSections = "ExamSections",
            ExamQuestions = "ExamQuestions",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
