namespace Rio.Workspace {
    export interface ExamForm {
        Code: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        TotalMarks: Serenity.IntegerEditor;
        NegativeMarks: Serenity.DecimalEditor;
        OptionsAvailable: Serenity.IntegerEditor;
        ResultCriteria: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class ExamForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.Exam';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamForm.init)  {
                ExamForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.DateEditor;

                Q.initFormType(ExamForm, [
                    'Code', w0,
                    'Name', w0,
                    'Description', w0,
                    'TotalMarks', w1,
                    'NegativeMarks', w2,
                    'OptionsAvailable', w1,
                    'ResultCriteria', w0,
                    'InsertDate', w3,
                    'InsertUserId', w1,
                    'UpdateDate', w3,
                    'UpdateUserId', w1,
                    'IsActive', w1,
                    'TenantId', w1
                ]);
            }
        }
    }
}
