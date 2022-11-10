namespace Rio.Workspace {
    export interface GroupStudentsForStudentsForm {
        RowIds: Serenity.StringEditor;
        Id: Serenity.StringEditor;
        GroupId: Serenity.LookupEditor;
        StudentId: Serenity.StringEditor;
    }

    export class GroupStudentsForStudentsForm extends Serenity.PrefixedContext {
        static formKey = 'Rio.GroupStudentsForStudentsForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!GroupStudentsForStudentsForm.init)  {
                GroupStudentsForStudentsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(GroupStudentsForStudentsForm, [
                    'RowIds', w0,
                    'Id', w0,
                    'GroupId', w1,
                    'StudentId', w0
                ]);
            }
        }
    }
}
