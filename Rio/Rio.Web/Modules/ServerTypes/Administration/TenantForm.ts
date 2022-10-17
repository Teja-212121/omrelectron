import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TenantForm {
    TenantName: StringEditor;
}

export class TenantForm extends PrefixedContext {
    static formKey = 'Administration.Tenant';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TenantForm.init)  {
            TenantForm.init = true;

            var w0 = StringEditor;

            initFormType(TenantForm, [
                'TenantName', w0
            ]);
        }
    }
}
