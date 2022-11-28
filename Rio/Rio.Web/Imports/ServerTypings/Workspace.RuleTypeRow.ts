﻿namespace Rio.Workspace {
    export interface RuleTypeRow {
        Id?: number;
        Name?: string;
        Description?: string;
    }

    export namespace RuleTypeRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Workspace.RuleType';
        export const lookupKey = 'Workspace.RuleType';

        export function getLookup(): Q.Lookup<RuleTypeRow> {
            return Q.getLookup<RuleTypeRow>('Workspace.RuleType');
        }
        export const deletePermission = 'Workspace:Exams:Modify';
        export const insertPermission = 'Workspace:Exams:Modify';
        export const readPermission = 'Workspace:Exams:View';
        export const updatePermission = 'Workspace:Exams:Modify';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description"
        }
    }
}
