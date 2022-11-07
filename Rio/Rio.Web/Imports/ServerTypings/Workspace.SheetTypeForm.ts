namespace Rio.Workspace {
    export interface SheetTypeForm {
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        TotalQuestions: Serenity.IntegerEditor;
        EPaperSize: Serenity.EnumEditor;
        HeightInPixel: Serenity.IntegerEditor;
        WidthInPixel: Serenity.IntegerEditor;
        SheetData: Serenity.TextAreaEditor;
        SheetImage: Serenity.ImageUploadEditor;
        OverlayImage: Serenity.ImageUploadEditor;
        Synced: Serenity.BooleanEditor;
        IsPrivate: Serenity.BooleanEditor;
        SheetNumber: Serenity.StringEditor;
        PdfTemplate: Serenity.ImageUploadEditor;
    }

    export class SheetTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.SheetType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SheetTypeForm.init)  {
                SheetTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.EnumEditor;
                var w4 = s.ImageUploadEditor;
                var w5 = s.BooleanEditor;

                Q.initFormType(SheetTypeForm, [
                    'Name', w0,
                    'Description', w1,
                    'TotalQuestions', w2,
                    'EPaperSize', w3,
                    'HeightInPixel', w2,
                    'WidthInPixel', w2,
                    'SheetData', w1,
                    'SheetImage', w4,
                    'OverlayImage', w4,
                    'Synced', w5,
                    'IsPrivate', w5,
                    'SheetNumber', w0,
                    'PdfTemplate', w4
                ]);
            }
        }
    }
}
