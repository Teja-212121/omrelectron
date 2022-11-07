namespace Rio.Workspace {
    export interface StudentForm {
        RollNo: Serenity.StringEditor;
        FullName: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        Mobile: Serenity.StringEditor;
        Dob: Serenity.DateEditor;
        Gender: Serenity.IntegerEditor;
        Note: Serenity.TextAreaEditor;
    }

    export class StudentForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.Student';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StudentForm.init)  {
                StudentForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EmailEditor;
                var w2 = s.DateEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.TextAreaEditor;

                Q.initFormType(StudentForm, [
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
}
