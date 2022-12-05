namespace Rio.Workspace {
    export interface ExamTeachersRow {
        Id?: number;
        RowIds?: string;
        TheoryExamId?: number;
        TeacherId?: number;
        IsActive?: number;
        TenantId?: number;
        TheoryExamCode?: string;
        TheoryExamName?: string;
        TheoryExamDescription?: string;
        TheoryExamTotalMarks?: number;
        TheoryExamInsertDate?: string;
        TheoryExamInsertUserId?: number;
        TheoryExamUpdateDate?: string;
        TheoryExamUpdateUserId?: number;
        TheoryExamIsActive?: number;
        TheoryExamTenantId?: number;
        TeacherFirstName?: string;
        TeacherMiddleName?: string;
        TeacherLastName?: string;
        TeacherFullName?: string;
        TeacherEmail?: string;
        TeacherMobile?: string;
        TeacherDob?: string;
        TeacherAllowedIps?: string;
        TeacherAddress?: string;
        TeacherCity?: string;
        TeacherUserId?: number;
        TeacherInsertDate?: string;
        TeacherInsertUserId?: number;
        TeacherUpdateDate?: string;
        TeacherUpdateUserId?: number;
        TeacherIsActive?: number;
        TeacherTenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ExamTeachersRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'Workspace.ExamTeachers';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            RowIds = "RowIds",
            TheoryExamId = "TheoryExamId",
            TeacherId = "TeacherId",
            IsActive = "IsActive",
            TenantId = "TenantId",
            TheoryExamCode = "TheoryExamCode",
            TheoryExamName = "TheoryExamName",
            TheoryExamDescription = "TheoryExamDescription",
            TheoryExamTotalMarks = "TheoryExamTotalMarks",
            TheoryExamInsertDate = "TheoryExamInsertDate",
            TheoryExamInsertUserId = "TheoryExamInsertUserId",
            TheoryExamUpdateDate = "TheoryExamUpdateDate",
            TheoryExamUpdateUserId = "TheoryExamUpdateUserId",
            TheoryExamIsActive = "TheoryExamIsActive",
            TheoryExamTenantId = "TheoryExamTenantId",
            TeacherFirstName = "TeacherFirstName",
            TeacherMiddleName = "TeacherMiddleName",
            TeacherLastName = "TeacherLastName",
            TeacherFullName = "TeacherFullName",
            TeacherEmail = "TeacherEmail",
            TeacherMobile = "TeacherMobile",
            TeacherDob = "TeacherDob",
            TeacherAllowedIps = "TeacherAllowedIps",
            TeacherAddress = "TeacherAddress",
            TeacherCity = "TeacherCity",
            TeacherUserId = "TeacherUserId",
            TeacherInsertDate = "TeacherInsertDate",
            TeacherInsertUserId = "TeacherInsertUserId",
            TeacherUpdateDate = "TeacherUpdateDate",
            TeacherUpdateUserId = "TeacherUpdateUserId",
            TeacherIsActive = "TeacherIsActive",
            TeacherTenantId = "TeacherTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
