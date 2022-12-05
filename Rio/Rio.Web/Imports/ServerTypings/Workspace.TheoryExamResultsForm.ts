namespace Rio.Workspace {
    export interface TheoryExamResultsForm {
        TheoryExamId: Serenity.StringEditor;
        StudentScanId: Serenity.StringEditor;
        TheoryExamQuestionId: Serenity.StringEditor;
        MarksObtained: Serenity.DecimalEditor;
        AttemptStatus: Serenity.IntegerEditor;
        RollNumber: Serenity.StringEditor;
        StudentId: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class TheoryExamResultsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExamResults';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamResultsForm.init)  {
                TheoryExamResultsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;

                Q.initFormType(TheoryExamResultsForm, [
                    'TheoryExamId', w0,
                    'StudentScanId', w0,
                    'TheoryExamQuestionId', w0,
                    'MarksObtained', w1,
                    'AttemptStatus', w2,
                    'RollNumber', w0,
                    'StudentId', w0,
                    'InsertDate', w3,
                    'InsertUserId', w2,
                    'UpdateDate', w3,
                    'UpdateUserId', w2,
                    'IsActive', w2,
                    'TenantId', w2
                ]);
            }
        }
    }
}
