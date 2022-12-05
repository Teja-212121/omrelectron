import { StringEditor, TextAreaEditor, IntegerEditor, EnumEditor, ImageUploadEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { EPaperSize } from "./enums.EPaperSize";
import { initFormType } from "@serenity-is/corelib/q";

export interface SheetTypeForm {
    Name: StringEditor;
    Description: TextAreaEditor;
    TotalQuestions: IntegerEditor;
    EPaperSize: EnumEditor;
    HeightInPixel: IntegerEditor;
    WidthInPixel: IntegerEditor;
    SheetData: TextAreaEditor;
    SheetImage: ImageUploadEditor;
    OverlayImage: ImageUploadEditor;
    Synced: BooleanEditor;
    IsPrivate: BooleanEditor;
    SheetNumber: StringEditor;
    PdfTemplate: ImageUploadEditor;
}

export class SheetTypeForm extends PrefixedContext {
    static formKey = 'Workspace.SheetType';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SheetTypeForm.init)  {
            SheetTypeForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = IntegerEditor;
            var w3 = EnumEditor;
            var w4 = ImageUploadEditor;
            var w5 = BooleanEditor;

            initFormType(SheetTypeForm, [
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

[EPaperSize]; // referenced types
