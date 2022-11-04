import { StringEditor, IntegerEditor, DecimalEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamForm {
    Code: StringEditor;
    Name: StringEditor;
    Description: StringEditor;
    TotalMarks: IntegerEditor;
    NegativeMarks: DecimalEditor;
    OptionsAvailable: IntegerEditor;
    ResultCriteria: StringEditor;
    InsertDate: DateEditor;
    InsertUserId: IntegerEditor;
    UpdateDate: DateEditor;
    UpdateUserId: IntegerEditor;
    IsActive: IntegerEditor;
    TenantId: IntegerEditor;
}

export class ExamForm extends PrefixedContext {
    static formKey = 'Workspace.Exam';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamForm.init)  {
            ExamForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DecimalEditor;
            var w3 = DateEditor;

            initFormType(ExamForm, [
                'Code', w0,
                'Name', w0,
                'Description', w0,
                'TotalMarks', w1,
                'NegativeMarks', w2,
                'OptionsAvailable', w1,
                'ResultCriteria', w0,
                'InsertDate', w3,
                'InsertUserId', w1,
                'UpdateDate', w3,
                'UpdateUserId', w1,
                'IsActive', w1,
                'TenantId', w1
            ]);
        }
    }
}
