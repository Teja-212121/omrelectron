namespace Rio.Workspace {
    export interface ActivationRow {
        Id?: number;
        SerialKeyId?: number;
        ExamListId?: number;
        TeacherId?: number;
        DeviceId?: string;
        DeviceDetails?: string;
        ActivationDate?: string;
        ExpiryDate?: string;
        EStatus?: Web.Enums.KeyStatus;
        IsActive?: number;
        ExamListName?: string;
        ExamListDescription?: string;
        ExamListInsertDate?: string;
        ExamListInsertUserId?: number;
        ExamListUpdateDate?: string;
        ExamListUpdateUserId?: number;
        ExamListIsActive?: number;
        ExamListTenantId?: number;
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
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace ActivationRow {
        export const idProperty = 'Id';
        export const nameProperty = 'DeviceId';
        export const localTextPrefix = 'Workspace.Activation';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            SerialKeyId = "SerialKeyId",
            ExamListId = "ExamListId",
            TeacherId = "TeacherId",
            DeviceId = "DeviceId",
            DeviceDetails = "DeviceDetails",
            ActivationDate = "ActivationDate",
            ExpiryDate = "ExpiryDate",
            EStatus = "EStatus",
            IsActive = "IsActive",
            ExamListName = "ExamListName",
            ExamListDescription = "ExamListDescription",
            ExamListInsertDate = "ExamListInsertDate",
            ExamListInsertUserId = "ExamListInsertUserId",
            ExamListUpdateDate = "ExamListUpdateDate",
            ExamListUpdateUserId = "ExamListUpdateUserId",
            ExamListIsActive = "ExamListIsActive",
            ExamListTenantId = "ExamListTenantId",
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
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
