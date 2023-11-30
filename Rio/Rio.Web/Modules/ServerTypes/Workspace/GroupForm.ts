import { StringEditor, LookupEditor, TextAreaEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface GroupForm {
    Name: StringEditor;
    ParentId: LookupEditor;
    Description: TextAreaEditor;
    SelectedTenant: LookupEditor;
    TeacherId: LookupEditor;
}

export class GroupForm extends PrefixedContext {
    static formKey = 'Workspace.Group';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!GroupForm.init)  {
            GroupForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = TextAreaEditor;

            initFormType(GroupForm, [
                'Name', w0,
                'ParentId', w1,
                'Description', w2,
                'SelectedTenant', w1,
                'TeacherId', w1
            ]);
        }
    }
}
