﻿namespace Rio.Workspace {
    export interface StudentRow {
        Id?: number;
        RollNo?: number;
        FirstName?: string;
        MiddleName?: string;
        LastName?: string;
        FullName?: string;
        Email?: string;
        Mobile?: string;
        Dob?: string;
        Gender?: number;
        Note?: string;
        IsActive?: number;
        TenantId?: number;
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }

    export namespace StudentRow {
        export const idProperty = 'Id';
        export const isActiveProperty = 'IsActive';
        export const nameProperty = 'FullName';
        export const localTextPrefix = 'Workspace.Student';
        export const lookupKey = 'Workspace.Student';

        export function getLookup(): Q.Lookup<StudentRow> {
            return Q.getLookup<StudentRow>('Workspace.Student');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            RollNo = "RollNo",
            FirstName = "FirstName",
            MiddleName = "MiddleName",
            LastName = "LastName",
            FullName = "FullName",
            Email = "Email",
            Mobile = "Mobile",
            Dob = "Dob",
            Gender = "Gender",
            Note = "Note",
            IsActive = "IsActive",
            TenantId = "TenantId",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}