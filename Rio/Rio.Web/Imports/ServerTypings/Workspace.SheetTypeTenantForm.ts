namespace Rio.Workspace {
    export interface SheetTypeTenantForm {
        SheetTypeId: Serenity.LookupEditor;
        IsDefault: Serenity.BooleanEditor;
        SheetDesignPdf: Serenity.ImageUploadEditor;
        SheetTypeDescription: Serenity.TextAreaEditor;
        SheetTypeTotalQuestions: Serenity.IntegerEditor;
        SheetTypeEPaperSize: Serenity.EnumEditor;
        SheetTypeHeightInPixel: Serenity.IntegerEditor;
        SheetTypeWidthInPixel: Serenity.IntegerEditor;
        SheetTypeSheetData: Serenity.TextAreaEditor;
        SheetTypeSheetImage: Serenity.StringEditor;
        SheetTypeOverlayImage: Serenity.StringEditor;
        SheetTypeSynced: Serenity.BooleanEditor;
        SheetTypeIsPrivate: Serenity.BooleanEditor;
        SheetTypePdfTemplate: Serenity.StringEditor;
        SheetTypeSheetNumber: Serenity.StringEditor;
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
                var w3 = s.TextAreaEditor;
                var w4 = s.IntegerEditor;
                var w5 = s.EnumEditor;
                var w6 = s.StringEditor;

                Q.initFormType(SheetTypeTenantForm, [
                    'SheetTypeId', w0,
                    'IsDefault', w1,
                    'SheetDesignPdf', w2,
                    'SheetTypeDescription', w3,
                    'SheetTypeTotalQuestions', w4,
                    'SheetTypeEPaperSize', w5,
                    'SheetTypeHeightInPixel', w4,
                    'SheetTypeWidthInPixel', w4,
                    'SheetTypeSheetData', w3,
                    'SheetTypeSheetImage', w6,
                    'SheetTypeOverlayImage', w6,
                    'SheetTypeSynced', w1,
                    'SheetTypeIsPrivate', w1,
                    'SheetTypePdfTemplate', w6,
                    'SheetTypeSheetNumber', w6
                ]);
            }
        }
    }
}
