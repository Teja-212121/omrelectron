namespace Rio.Workspace {
    export interface ExamListExamsForm {
        ExamListId: Serenity.LookupEditor;
        ExamId: Serenity.LookupEditor;
        TenantId: Serenity.LookupEditor;
        Priority: Serenity.IntegerEditor;
        StartDate: Serenity.DateEditor;
        EndDate: Serenity.DateEditor;
        ModelAnswerPaperStartDate: Serenity.DateEditor;
    }

    export class ExamListExamsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamListExams';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamListExamsForm.init)  {
                ExamListExamsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(ExamListExamsForm, [
                    'ExamListId', w0,
                    'ExamId', w0,
                    'TenantId', w0,
                    'Priority', w1,
                    'StartDate', w2,
                    'EndDate', w2,
                    'ModelAnswerPaperStartDate', w2
                ]);
            }
        }
    }
}
