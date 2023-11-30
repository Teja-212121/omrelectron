namespace Rio.Workspace {
    export interface GroupStudentForm {
        GroupId: Serenity.LookupEditor;
        StudentId: Serenity.LookupEditor;
        TeacherId: Serenity.LookupEditor;
    }

    export class GroupStudentForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.GroupStudent';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!GroupStudentForm.init)  {
                GroupStudentForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;

                Q.initFormType(GroupStudentForm, [
                    'GroupId', w0,
                    'StudentId', w0,
                    'TeacherId', w0
                ]);
            }
        }
    }
}
