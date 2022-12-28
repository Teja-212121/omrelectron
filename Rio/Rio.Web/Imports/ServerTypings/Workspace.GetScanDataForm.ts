namespace Rio.Workspace {
    export interface GetScanDataForm {
        StudentId: Serenity.IntegerEditor;
        ExamId: Serenity.IntegerEditor;
        NegativeMarks: Serenity.DecimalEditor;
        QuestionIndex: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
        ScanSheetId: Serenity.StringEditor;
        ScanBatchId: Serenity.StringEditor;
        Score: Serenity.DecimalEditor;
        CorrectedRollNo: Serenity.IntegerEditor;
        SheetNumber: Serenity.StringEditor;
        RightOptions: Serenity.IntegerEditor;
        CorrectedOptions: Serenity.IntegerEditor;
        RuleTypeId: Serenity.IntegerEditor;
    }

    export class GetScanDataForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.GetScanData';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!GetScanDataForm.init)  {
                GetScanDataForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.StringEditor;

                Q.initFormType(GetScanDataForm, [
                    'StudentId', w0,
                    'ExamId', w0,
                    'NegativeMarks', w1,
                    'QuestionIndex', w0,
                    'TenantId', w0,
                    'ScanSheetId', w2,
                    'ScanBatchId', w2,
                    'Score', w1,
                    'CorrectedRollNo', w0,
                    'SheetNumber', w2,
                    'RightOptions', w0,
                    'CorrectedOptions', w0,
                    'RuleTypeId', w0
                ]);
            }
        }
    }
}
