namespace Rio.Workspace {
    export interface SelectSheetTypeForm {
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        TotalQuestions: Serenity.IntegerEditor;
        EPaperSize: Serenity.IntegerEditor;
        HeightInPixel: Serenity.IntegerEditor;
        WidthInPixel: Serenity.IntegerEditor;
        SheetData: Serenity.TextAreaEditor;
        SheetImage: Serenity.ImageUploadEditor;
        OverlayImage: Serenity.ImageUploadEditor;
        Synced: Serenity.BooleanEditor;
        IsPrivate: Serenity.BooleanEditor;
        PdfTemplate: Serenity.ImageUploadEditor;
        SheetNumber: Serenity.StringEditor;
    }

    export class SelectSheetTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.SelectSheetType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SelectSheetTypeForm.init)  {
                SelectSheetTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.ImageUploadEditor;
                var w4 = s.BooleanEditor;

                Q.initFormType(SelectSheetTypeForm, [
                    'Name', w0,
                    'Description', w1,
                    'TotalQuestions', w2,
                    'EPaperSize', w2,
                    'HeightInPixel', w2,
                    'WidthInPixel', w2,
                    'SheetData', w1,
                    'SheetImage', w3,
                    'OverlayImage', w3,
                    'Synced', w4,
                    'IsPrivate', w4,
                    'PdfTemplate', w3,
                    'SheetNumber', w0
                ]);
            }
        }
    }
}
