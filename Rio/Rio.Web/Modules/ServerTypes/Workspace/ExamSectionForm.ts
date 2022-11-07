import { StringEditor, TextAreaEditor, LookupEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamSectionForm {
    Name: StringEditor;
    Description: TextAreaEditor;
    ExamId: LookupEditor;
    ParentId: LookupEditor;
    TenantId: IntegerEditor;
}

export class ExamSectionForm extends PrefixedContext {
    static formKey = 'Workspace.ExamSection';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamSectionForm.init)  {
            ExamSectionForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = LookupEditor;
            var w3 = IntegerEditor;

            initFormType(ExamSectionForm, [
                'Name', w0,
                'Description', w1,
                'ExamId', w2,
                'ParentId', w2,
                'TenantId', w3
            ]);
        }
    }
}
