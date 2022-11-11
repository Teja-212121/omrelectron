namespace Rio.Workspace {
    export interface ExamRankWiseResultForm {
        StudentId: Serenity.LookupEditor;
        RollNumber: Serenity.StringEditor;
        SheetNumber: Serenity.StringEditor;
        SheetGuid: Serenity.StringEditor;
        ExamId: Serenity.LookupEditor;
        Rank: Serenity.IntegerEditor;
    }

    export class ExamRankWiseResultForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamRankWiseResult';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamRankWiseResultForm.init)  {
                ExamRankWiseResultForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ExamRankWiseResultForm, [
                    'StudentId', w0,
                    'RollNumber', w1,
                    'SheetNumber', w1,
                    'SheetGuid', w1,
                    'ExamId', w0,
                    'Rank', w2
                ]);
            }
        }
    }
}
