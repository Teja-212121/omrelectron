namespace Rio.Workspace {
    export interface ExamListForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class ExamListForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamList';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamListForm.init)  {
                ExamListForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ExamListForm, [
                    'Name', w0,
                    'Description', w0,
                    'InsertDate', w1,
                    'InsertUserId', w2,
                    'UpdateDate', w1,
                    'UpdateUserId', w2,
                    'IsActive', w2,
                    'TenantId', w2
                ]);
            }
        }
    }
}
