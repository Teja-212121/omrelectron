import { StringEditor, IntegerEditor, BooleanEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SheetTypeForm {
    Name: StringEditor;
    Description: StringEditor;
    TotalQuestions: IntegerEditor;
    EPaperSize: IntegerEditor;
    HeightInPixel: IntegerEditor;
    WidthInPixel: IntegerEditor;
    SheetData: StringEditor;
    SheetImage: StringEditor;
    OverlayImage: StringEditor;
    Synced: BooleanEditor;
    IsPrivate: BooleanEditor;
    PdfTemplate: StringEditor;
    SheetNumber: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
}

export class SheetTypeForm extends PrefixedContext {
    static formKey = 'Workspace.SheetType';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SheetTypeForm.init)  {
            SheetTypeForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = BooleanEditor;
            var w3 = DateEditor;

            initFormType(SheetTypeForm, [
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
