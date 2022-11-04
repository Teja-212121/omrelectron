namespace Rio.Workspace {
    export interface GroupForm {
        Name: Serenity.StringEditor;
        ParentId: Serenity.LookupEditor;
        Description: Serenity.TextAreaEditor;
    }

    export class GroupForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.Group';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!GroupForm.init)  {
                GroupForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.TextAreaEditor;

                Q.initFormType(GroupForm, [
                    'Name', w0,
                    'ParentId', w1,
                    'Description', w2
                ]);
            }
        }
    }
}
