namespace Rio.Workspace {
    export interface ActivationLogRow {
        Id?: number;
        Code?: string;
        SerialKey?: string;
        TeacherId?: number;
        ExamListId?: number;
        DeviceId?: string;
        DeviceDetails?: string;
        EStatus?: Web.Enums.KeyStatus;
        Note?: string;
        SerialKeyId?: number;
        IsActive?: number;
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
        TeacherSchoolOrInstitute?: string;
        ActivationId?: number;
        ExamListName?: string;
        ExamListDescription?: string;
        ExamListInsertDate?: string;
        ExamListInsertUserId?: number;
        ExamListUpdateDate?: string;
        ExamListUpdateUserId?: number;
        ExamListIsActive?: number;
        ExamListTenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ActivationLogRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Workspace.ActivationLog';
        export const lookupKey = 'Workspace.ActivationLog';

        export function getLookup(): Q.Lookup<ActivationLogRow> {
            return Q.getLookup<ActivationLogRow>('Workspace.ActivationLog');
        }
        export const deletePermission = 'Workspace:ActivationManagement:Modify';
        export const insertPermission = 'Workspace:ActivationManagement:Modify';
        export const readPermission = 'Workspace:ActivationManagement:View';
        export const updatePermission = 'Workspace:ActivationManagement:Modify';

        export declare const enum Fields {
            Id = "Id",
            Code = "Code",
            SerialKey = "SerialKey",
            TeacherId = "TeacherId",
            ExamListId = "ExamListId",
            DeviceId = "DeviceId",
            DeviceDetails = "DeviceDetails",
            EStatus = "EStatus",
            Note = "Note",
            SerialKeyId = "SerialKeyId",
            IsActive = "IsActive",
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
            TeacherSchoolOrInstitute = "TeacherSchoolOrInstitute",
            ActivationId = "ActivationId",
            ExamListName = "ExamListName",
            ExamListDescription = "ExamListDescription",
            ExamListInsertDate = "ExamListInsertDate",
            ExamListInsertUserId = "ExamListInsertUserId",
            ExamListUpdateDate = "ExamListUpdateDate",
            ExamListUpdateUserId = "ExamListUpdateUserId",
            ExamListIsActive = "ExamListIsActive",
            ExamListTenantId = "ExamListTenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
