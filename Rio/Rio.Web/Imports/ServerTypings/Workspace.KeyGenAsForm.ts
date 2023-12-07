namespace Rio.Workspace {
    export interface KeyGenAsForm {
        Quantity: Serenity.IntegerEditor;
        ExamListId: Serenity.LookupEditor;
        ValidityType: Serenity.EnumEditor;
        ValidityInDays: Serenity.IntegerEditor;
        ValidDate: Serenity.DateEditor;
        Note: Serenity.StringEditor;
    }

    export class KeyGenAsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.KeyGenAs';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!KeyGenAsForm.init)  {
                KeyGenAsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.LookupEditor;
                var w2 = s.EnumEditor;
                var w3 = s.DateEditor;
                var w4 = s.StringEditor;

                Q.initFormType(KeyGenAsForm, [
                    'Quantity', w0,
                    'ExamListId', w1,
                    'ValidityType', w2,
                    'ValidityInDays', w0,
                    'ValidDate', w3,
                    'Note', w4
                ]);
            }
        }
    }
}
