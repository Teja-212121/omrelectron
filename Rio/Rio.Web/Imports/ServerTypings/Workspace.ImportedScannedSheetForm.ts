namespace Rio.Workspace {
    export interface ImportedScannedSheetForm {
        SheetTypeId: Serenity.LookupEditor;
        ScannedAt: Serenity.DateEditor;
        SheetNumber: Serenity.StringEditor;
        ScannedRollNo: Serenity.StringEditor;
        ScannedExamNo: Serenity.StringEditor;
        CorrectedRollNo: Serenity.StringEditor;
        CorrectedExamNo: Serenity.StringEditor;
        ExamSetNo: Serenity.IntegerEditor;
        ScannedImageSourcePath: Serenity.TextAreaEditor;
        ScannedImage: Serenity.StringEditor;
        ScannedBatchId: Serenity.LookupEditor;
        ScannedStatus: Serenity.IntegerEditor;
        ScannedSystemErrors: Serenity.TextAreaEditor;
        ScannedUserErrors: Serenity.TextAreaEditor;
        ScannedComments: Serenity.TextAreaEditor;
        ResultProcessed: Serenity.BooleanEditor;
    }

    export class ImportedScannedSheetForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ImportedScannedSheet';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ImportedScannedSheetForm.init)  {
                ImportedScannedSheetForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = s.StringEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.TextAreaEditor;
                var w5 = s.BooleanEditor;

                Q.initFormType(ImportedScannedSheetForm, [
                    'SheetTypeId', w0,
                    'ScannedAt', w1,
                    'SheetNumber', w2,
                    'ScannedRollNo', w2,
                    'ScannedExamNo', w2,
                    'CorrectedRollNo', w2,
                    'CorrectedExamNo', w2,
                    'ExamSetNo', w3,
                    'ScannedImageSourcePath', w4,
                    'ScannedImage', w2,
                    'ScannedBatchId', w0,
                    'ScannedStatus', w3,
                    'ScannedSystemErrors', w4,
                    'ScannedUserErrors', w4,
                    'ScannedComments', w4,
                    'ResultProcessed', w5
                ]);
            }
        }
    }
}
