import { StringEditor, DateEditor, IntegerEditor, TextAreaEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface StudentForm {
    RollNo: StringEditor;
    FullName: StringEditor;
    Email: StringEditor;
    Mobile: StringEditor;
    Dob: DateEditor;
    Gender: IntegerEditor;
    Note: TextAreaEditor;
}

export class StudentForm extends PrefixedContext {
    static formKey = 'Workspace.Student';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StudentForm.init)  {
            StudentForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = IntegerEditor;
            var w3 = TextAreaEditor;

            initFormType(StudentForm, [
                'RollNo', w0,
                'FullName', w0,
                'Email', w0,
                'Mobile', w0,
                'Dob', w1,
                'Gender', w2,
                'Note', w3
            ]);
        }
    }
}
