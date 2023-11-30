namespace Rio.Workspace {
    export interface SerialKeyForm {
        SerialKey: Serenity.StringEditor;
        ExamListId: Serenity.IntegerEditor;
        ValidityType: Serenity.IntegerEditor;
        ValidityInDays: Serenity.IntegerEditor;
        ValidDate: Serenity.DateEditor;
        Note: Serenity.StringEditor;
        EStatus: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
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
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(SerialKeyForm, [
                    'SerialKey', w0,
                    'ExamListId', w1,
                    'ValidityType', w1,
                    'ValidityInDays', w1,
                    'ValidDate', w2,
                    'Note', w0,
                    'EStatus', w1,
                    'InsertDate', w2,
                    'InsertUserId', w1,
                    'UpdateDate', w2,
                    'UpdateUserId', w1,
                    'IsActive', w1
                ]);
            }
        }
    }
}
