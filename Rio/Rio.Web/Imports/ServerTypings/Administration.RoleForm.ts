﻿namespace Rio.Administration {
    export interface RoleForm {
        RoleName: Serenity.StringEditor;
        RoleKey: Serenity.StringEditor;
    }

    export class RoleForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.Role';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RoleForm.init)  {
                RoleForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(RoleForm, [
                    'RoleName', w0,
                    'RoleKey', w0
                ]);
            }
        }
    }
}
