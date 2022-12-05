import { StringEditor, EmailEditor, DateEditor, EnumEditor, TextAreaEditor, PrefixedContext } from "@serenity-is/corelib";
import { Gender } from "../Web/Enums.Gender";
import { initFormType } from "@serenity-is/corelib/q";

export interface StudentForm {
    RollNo: StringEditor;
    FullName: StringEditor;
    Email: EmailEditor;
    Mobile: StringEditor;
    Dob: DateEditor;
    Gender: EnumEditor;
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
            var w1 = EmailEditor;
            var w2 = DateEditor;
            var w3 = EnumEditor;
            var w4 = TextAreaEditor;

            initFormType(StudentForm, [
                'RollNo', w0,
                'FullName', w0,
                'Email', w1,
                'Mobile', w0,
                'Dob', w2,
                'Gender', w3,
                'Note', w4
            ]);
        }
    }
}

[Gender]; // referenced types
