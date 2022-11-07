import { LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface GroupStudentForm {
    GroupId: LookupEditor;
    StudentId: LookupEditor;
}

export class GroupStudentForm extends PrefixedContext {
    static formKey = 'Workspace.GroupStudent';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!GroupStudentForm.init)  {
            GroupStudentForm.init = true;

            var w0 = LookupEditor;

            initFormType(GroupStudentForm, [
                'GroupId', w0,
                'StudentId', w0
            ]);
        }
    }
}
