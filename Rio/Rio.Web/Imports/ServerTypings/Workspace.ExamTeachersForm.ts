namespace Rio.Workspace {
    export interface ExamTeachersForm {
        TheoryExamId: Serenity.StringEditor;
        TeacherId: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class ExamTeachersForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamTeachers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamTeachersForm.init)  {
                ExamTeachersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ExamTeachersForm, [
                    'TheoryExamId', w0,
                    'TeacherId', w0,
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
