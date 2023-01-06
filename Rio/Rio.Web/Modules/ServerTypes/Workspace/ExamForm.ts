import { StringEditor, TextAreaEditor, LookupEditor, IntegerEditor, DecimalEditor, ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamForm {
    Code: StringEditor;
    Name: StringEditor;
    Description: TextAreaEditor;
    SheetTypeId: LookupEditor;
    TotalQuestions: IntegerEditor;
    TotalMarks: IntegerEditor;
    NegativeMarks: DecimalEditor;
    OptionsAvailable: IntegerEditor;
    ResultCriteria: StringEditor;
    QuestionPaper: ImageUploadEditor;
    ModelAnswer: ImageUploadEditor;
    SelectedTenant: LookupEditor;
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
            var w2 = LookupEditor;
            var w3 = IntegerEditor;
            var w4 = DecimalEditor;
            var w5 = ImageUploadEditor;

            initFormType(ExamForm, [
                'Code', w0,
                'Name', w0,
                'Description', w1,
                'SheetTypeId', w2,
                'TotalQuestions', w3,
                'TotalMarks', w3,
                'NegativeMarks', w4,
                'OptionsAvailable', w3,
                'ResultCriteria', w0,
                'QuestionPaper', w5,
                'ModelAnswer', w5,
                'SelectedTenant', w2
            ]);
        }
    }
}
