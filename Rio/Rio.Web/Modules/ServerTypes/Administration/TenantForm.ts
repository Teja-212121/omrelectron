import { StringEditor, EnumEditor, PrefixedContext } from "@serenity-is/corelib";
import { EApprovalStatus } from "../Web/Enums.EApprovalStatus";
import { initFormType } from "@serenity-is/corelib/q";

export interface TenantForm {
    TenantName: StringEditor;
    EApprovalStatus: EnumEditor;
}

export class TenantForm extends PrefixedContext {
    static formKey = 'Administration.Tenant';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TenantForm.init)  {
            TenantForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;

            initFormType(TenantForm, [
                'TenantName', w0,
                'EApprovalStatus', w1
            ]);
        }
    }
}

[EApprovalStatus]; // referenced types
