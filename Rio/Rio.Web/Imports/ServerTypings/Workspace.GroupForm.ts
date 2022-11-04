namespace Rio.Workspace {
    export interface GroupForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ParentId: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
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
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(GroupForm, [
                    'Name', w0,
                    'Description', w0,
                    'ParentId', w1,
                    'InsertDate', w2,
                    'InsertUserId', w1,
                    'UpdateDate', w2,
                    'UpdateUserId', w1,
                    'IsActive', w1,
                    'TenantId', w1
                ]);
            }
        }
    }
}
