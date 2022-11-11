import { StringEditor, TextAreaEditor, IntegerEditor, DecimalEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamForm {
    Code: StringEditor;
    Name: StringEditor;
    Description: TextAreaEditor;
    TotalQuestions: IntegerEditor;
    TotalMarks: IntegerEditor;
    NegativeMarks: DecimalEditor;
    OptionsAvailable: IntegerEditor;
    ResultCriteria: StringEditor;
}

export class ExamForm extends PrefixedContext {
    static formKey = 'Workspace.Exam';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamForm.init)  {
            ExamForm.init = true;

            var w0 = StringEditor;
            var w1 = TextAreaEditor;
            var w2 = IntegerEditor;
            var w3 = DecimalEditor;

            initFormType(ExamForm, [
                'Code', w0,
                'Name', w0,
                'Description', w1,
                'TotalQuestions', w2,
                'TotalMarks', w2,
                'NegativeMarks', w3,
                'OptionsAvailable', w2,
                'ResultCriteria', w0
            ]);
        }
    }
}
