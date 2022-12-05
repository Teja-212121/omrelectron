namespace Rio.Workspace {
    export interface AssignExamTeachersForm {
        TeacherId: Serenity.LookupEditor;
        RowIds: Serenity.StringEditor;
    }

    export class AssignExamTeachersForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.AssignExamTeachers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AssignExamTeachersForm.init)  {
                AssignExamTeachersForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(AssignExamTeachersForm, [
                    'TeacherId', w0,
                    'RowIds', w1
                ]);
            }
        }
    }
}
