import { StringEditor, IntegerEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface GroupForm {
    Name: StringEditor;
    Description: StringEditor;
    ParentId: IntegerEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
    TenantId: IntegerEditor;
}

export class GroupForm extends PrefixedContext {
    static formKey = 'Workspace.Group';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!GroupForm.init)  {
            GroupForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;

            initFormType(GroupForm, [
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
