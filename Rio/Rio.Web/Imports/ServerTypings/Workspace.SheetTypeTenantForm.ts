namespace Rio.Workspace {
    export interface SheetTypeTenantForm {
        SheetTypeId: Serenity.LookupEditor;
        TenantId: Serenity.IntegerEditor;
        SheetDesignPdf: Serenity.ImageUploadEditor;
        IsDefault: Serenity.BooleanEditor;
    }

    export class SheetTypeTenantForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.SheetTypeTenant';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SheetTypeTenantForm.init)  {
                SheetTypeTenantForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.ImageUploadEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(SheetTypeTenantForm, [
                    'SheetTypeId', w0,
                    'TenantId', w1,
                    'SheetDesignPdf', w2,
                    'IsDefault', w3
                ]);
            }
        }
    }
}
