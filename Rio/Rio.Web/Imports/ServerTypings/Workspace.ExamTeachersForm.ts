﻿namespace Rio.Workspace {
    export interface ExamTeachersForm {
        TheoryExamId: Serenity.StringEditor;
        TeacherId: Serenity.StringEditor;
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

                Q.initFormType(ExamTeachersForm, [
                    'TheoryExamId', w0,
                    'TeacherId', w0
                ]);
            }
        }
    }
}
