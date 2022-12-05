namespace Rio.Workspace {
    export interface TeachersForm {
        FirstName: Serenity.StringEditor;
        MiddleName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        Mobile: Serenity.StringEditor;
        Dob: Serenity.DateEditor;
        AllowedIps: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        City: Serenity.StringEditor;
    }

    export class TeachersForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.Teachers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TeachersForm.init)  {
                TeachersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EmailEditor;
                var w2 = s.DateEditor;

                Q.initFormType(TeachersForm, [
                    'FirstName', w0,
                    'MiddleName', w0,
                    'LastName', w0,
                    'Email', w1,
                    'Mobile', w0,
                    'Dob', w2,
                    'AllowedIps', w0,
                    'Address', w0,
                    'City', w0
                ]);
            }
        }
    }
}
