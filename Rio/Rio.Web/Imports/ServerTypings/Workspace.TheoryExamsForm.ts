namespace Rio.Workspace {
    export interface TheoryExamsForm {
        Code: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        TotalMarks: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class TheoryExamsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExams';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamsForm.init)  {
                TheoryExamsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(TheoryExamsForm, [
                    'Code', w0,
                    'Name', w0,
                    'Description', w0,
                    'TotalMarks', w1,
                    'InsertDate', w2,
                    'InsertUserId', w1,
                    'UpdateDate', w2,
                    'UpdateUserId', w1,
                    'IsActive', w1,
                    'TenantId', w1
                ]);
            }
        }
    }
}
