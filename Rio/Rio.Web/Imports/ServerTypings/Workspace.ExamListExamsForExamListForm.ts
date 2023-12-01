namespace Rio.Workspace {
    export interface ExamListExamsForExamListForm {
        RowIds: Serenity.StringEditor;
        ExamListId: Serenity.LookupEditor;
        StartDate: Serenity.DateEditor;
        EndDate: Serenity.DateEditor;
        ModelAnswerPaperStartDate: Serenity.DateEditor;
    }

    export class ExamListExamsForExamListForm extends Serenity.PrefixedContext {
        static formKey = 'Rio.ExamListExamsForExamListForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamListExamsForExamListForm.init)  {
                ExamListExamsForExamListForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DateEditor;

                Q.initFormType(ExamListExamsForExamListForm, [
                    'RowIds', w0,
                    'ExamListId', w1,
                    'StartDate', w2,
                    'EndDate', w2,
                    'ModelAnswerPaperStartDate', w2
                ]);
            }
        }
    }
}
