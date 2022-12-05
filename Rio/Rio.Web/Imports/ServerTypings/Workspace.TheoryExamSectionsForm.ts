namespace Rio.Workspace {
    export interface TheoryExamSectionsForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        TheoryExamId: Serenity.StringEditor;
        ParentId: Serenity.IntegerEditor;
        SortOrder: Serenity.DecimalEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class TheoryExamSectionsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExamSections';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamSectionsForm.init)  {
                TheoryExamSectionsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.DateEditor;

                Q.initFormType(TheoryExamSectionsForm, [
                    'Name', w0,
                    'Description', w0,
                    'TheoryExamId', w0,
                    'ParentId', w1,
                    'SortOrder', w2,
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
