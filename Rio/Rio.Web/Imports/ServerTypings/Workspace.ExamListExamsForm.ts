namespace Rio.Workspace {
    export interface ExamListExamsForm {
        ExamListId: Serenity.IntegerEditor;
        ExamId: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
        Priority: Serenity.IntegerEditor;
        StartDate: Serenity.DateEditor;
        EndDate: Serenity.DateEditor;
        ModelAnswerPaperStartDate: Serenity.DateEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
    }

    export class ExamListExamsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamListExams';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamListExamsForm.init)  {
                ExamListExamsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DateEditor;

                Q.initFormType(ExamListExamsForm, [
                    'ExamListId', w0,
                    'ExamId', w0,
                    'TenantId', w0,
                    'Priority', w0,
                    'StartDate', w1,
                    'EndDate', w1,
                    'ModelAnswerPaperStartDate', w1,
                    'InsertDate', w1,
                    'InsertUserId', w0,
                    'UpdateDate', w1,
                    'UpdateUserId', w0,
                    'IsActive', w0
                ]);
            }
        }
    }
}
