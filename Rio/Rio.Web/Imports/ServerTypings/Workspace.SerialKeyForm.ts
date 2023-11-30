namespace Rio.Workspace {
    export interface SerialKeyForm {
        SerialKey: Serenity.StringEditor;
        ExamListId: Serenity.LookupEditor;
        ValidityType: Serenity.IntegerEditor;
        ValidityInDays: Serenity.IntegerEditor;
        ValidDate: Serenity.DateEditor;
        Note: Serenity.TextAreaEditor;
        EStatus: Serenity.IntegerEditor;
    }

    export class SerialKeyForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.SerialKey';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SerialKeyForm.init)  {
                SerialKeyForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;
                var w4 = s.TextAreaEditor;

                Q.initFormType(SerialKeyForm, [
                    'SerialKey', w0,
                    'ExamListId', w1,
                    'ValidityType', w2,
                    'ValidityInDays', w2,
                    'ValidDate', w3,
                    'Note', w4,
                    'EStatus', w2
                ]);
            }
        }
    }
}
