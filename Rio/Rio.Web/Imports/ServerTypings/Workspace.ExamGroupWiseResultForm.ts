namespace Rio.Workspace {
    export interface ExamGroupWiseResultForm {
        StudentId: Serenity.LookupEditor;
        RollNumber: Serenity.StringEditor;
        SheetNumber: Serenity.StringEditor;
        SheetGuid: Serenity.StringEditor;
        ExamId: Serenity.LookupEditor;
        Rank: Serenity.IntegerEditor;
        GroupId: Serenity.LookupEditor;
    }

    export class ExamGroupWiseResultForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamGroupWiseResult';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamGroupWiseResultForm.init)  {
                ExamGroupWiseResultForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ExamGroupWiseResultForm, [
                    'StudentId', w0,
                    'RollNumber', w1,
                    'SheetNumber', w1,
                    'SheetGuid', w1,
                    'ExamId', w0,
                    'Rank', w2,
                    'GroupId', w0
                ]);
            }
        }
    }
}
