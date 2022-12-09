namespace Rio.Workspace {
    export interface ScannedSheetForm {
        SheetTypeId: Serenity.LookupEditor;
        ScannedAt: Serenity.DateEditor;
        SheetNumber: Serenity.StringEditor;
        ScannedRollNo: Serenity.StringEditor;
        ScannedExamNo: Serenity.StringEditor;
        CorrectedRollNo: Serenity.StringEditor;
        CorrectedExamNo: Serenity.StringEditor;
        ExamSetNo: Serenity.StringEditor;
        ScannedImageSourcePath: Serenity.TextAreaEditor;
        ScannedImage: Serenity.ImageUploadEditor;
        ScannedBatchId: Serenity.LookupEditor;
        ScannedStatus: Serenity.EnumEditor;
        ScannedSystemErrors: Serenity.TextAreaEditor;
        ScannedUserErrors: Serenity.TextAreaEditor;
        ScannedComments: Serenity.TextAreaEditor;
        ResultProcessed: Serenity.BooleanEditor;
        OCRData1Key: Serenity.StringEditor;
        OCRData1Value: Serenity.StringEditor;
        OCRData2Key: Serenity.StringEditor;
        OCRData2Value: Serenity.StringEditor;
        OCRData3Key: Serenity.StringEditor;
        OCRData3Value: Serenity.StringEditor;
        ICRData1Key: Serenity.StringEditor;
        ICRData1Value: Serenity.StringEditor;
        ICRData2Key: Serenity.StringEditor;
        ICRData2Value: Serenity.StringEditor;
        ICRData3Key: Serenity.StringEditor;
        ICRData3Value: Serenity.StringEditor;
    }

    export class ScannedSheetForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ScannedSheet';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ScannedSheetForm.init)  {
                ScannedSheetForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = s.StringEditor;
                var w3 = s.TextAreaEditor;
                var w4 = s.ImageUploadEditor;
                var w5 = s.EnumEditor;
                var w6 = s.BooleanEditor;

                Q.initFormType(ScannedSheetForm, [
                    'SheetTypeId', w0,
                    'ScannedAt', w1,
                    'SheetNumber', w2,
                    'ScannedRollNo', w2,
                    'ScannedExamNo', w2,
                    'CorrectedRollNo', w2,
                    'CorrectedExamNo', w2,
                    'ExamSetNo', w2,
                    'ScannedImageSourcePath', w3,
                    'ScannedImage', w4,
                    'ScannedBatchId', w0,
                    'ScannedStatus', w5,
                    'ScannedSystemErrors', w3,
                    'ScannedUserErrors', w3,
                    'ScannedComments', w3,
                    'ResultProcessed', w6,
                    'OCRData1Key', w2,
                    'OCRData1Value', w2,
                    'OCRData2Key', w2,
                    'OCRData2Value', w2,
                    'OCRData3Key', w2,
                    'OCRData3Value', w2,
                    'ICRData1Key', w2,
                    'ICRData1Value', w2,
                    'ICRData2Key', w2,
                    'ICRData2Value', w2,
                    'ICRData3Key', w2,
                    'ICRData3Value', w2
                ]);
            }
        }
    }
}
