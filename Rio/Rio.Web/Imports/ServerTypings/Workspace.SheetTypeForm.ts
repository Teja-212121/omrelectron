namespace Rio.Workspace {
    export interface SheetTypeForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        TotalQuestions: Serenity.IntegerEditor;
        EPaperSize: Serenity.IntegerEditor;
        HeightInPixel: Serenity.IntegerEditor;
        WidthInPixel: Serenity.IntegerEditor;
        SheetData: Serenity.StringEditor;
        SheetImage: Serenity.StringEditor;
        OverlayImage: Serenity.StringEditor;
        Synced: Serenity.BooleanEditor;
        IsPrivate: Serenity.BooleanEditor;
        PdfTemplate: Serenity.StringEditor;
        SheetNumber: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
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
                var w1 = s.IntegerEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.DateEditor;

                Q.initFormType(SheetTypeForm, [
                    'Name', w0,
                    'Description', w0,
                    'TotalQuestions', w1,
                    'EPaperSize', w1,
                    'HeightInPixel', w1,
                    'WidthInPixel', w1,
                    'SheetData', w0,
                    'SheetImage', w0,
                    'OverlayImage', w0,
                    'Synced', w2,
                    'IsPrivate', w2,
                    'PdfTemplate', w0,
                    'SheetNumber', w0,
                    'InsertDate', w3,
                    'InsertUserId', w1,
                    'UpdateDate', w3,
                    'UpdateUserId', w1,
                    'IsActive', w1
                ]);
            }
        }
    }
}
