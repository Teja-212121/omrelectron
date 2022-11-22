namespace Rio.Administration {
    export interface TenantForm {
        TenantName: Serenity.StringEditor;
        EApprovalStatus: Serenity.EnumEditor;
    }

    export class TenantForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.Tenant';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TenantForm.init)  {
                TenantForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EnumEditor;

                Q.initFormType(TenantForm, [
                    'TenantName', w0,
                    'EApprovalStatus', w1
                ]);
            }
        }
    }
}
