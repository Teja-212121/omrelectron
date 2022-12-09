import { LookupEditor, StringEditor, TextAreaEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamSectionForm {
    ExamId: LookupEditor;
    Name: StringEditor;
    Description: TextAreaEditor;
    ParentId: LookupEditor;
}

export class ExamSectionForm extends PrefixedContext {
    static formKey = 'Workspace.ExamSection';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamSectionForm.init)  {
            ExamSectionForm.init = true;

            var w0 = LookupEditor;
            var w1 = StringEditor;
            var w2 = TextAreaEditor;

            initFormType(ExamSectionForm, [
                'ExamId', w0,
                'Name', w1,
                'Description', w2,
                'ParentId', w0
            ]);
        }
    }
}
