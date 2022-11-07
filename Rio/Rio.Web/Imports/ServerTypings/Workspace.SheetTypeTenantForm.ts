namespace Rio.Workspace {
    export interface SheetTypeTenantForm {
        SheetTypeId: Serenity.LookupEditor;
        IsDefault: Serenity.BooleanEditor;
        SheetDesignPdf: Serenity.ImageUploadEditor;
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
                var w1 = s.BooleanEditor;
                var w2 = s.ImageUploadEditor;

                Q.initFormType(SheetTypeTenantForm, [
                    'SheetTypeId', w0,
                    'IsDefault', w1,
                    'SheetDesignPdf', w2
                ]);
            }
        }
    }
}
