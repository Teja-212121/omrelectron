namespace Rio.Workspace {
    export interface ActivationLogForm {
        Code: Serenity.StringEditor;
        SerialKey: Serenity.StringEditor;
        TeacherId: Serenity.IntegerEditor;
        ExamListId: Serenity.IntegerEditor;
        DeviceId: Serenity.StringEditor;
        DeviceDetails: Serenity.StringEditor;
        EStatus: Serenity.IntegerEditor;
        Note: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
    }

    export class ActivationLogForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ActivationLog';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ActivationLogForm.init)  {
                ActivationLogForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(ActivationLogForm, [
                    'Code', w0,
                    'SerialKey', w0,
                    'TeacherId', w1,
                    'ExamListId', w1,
                    'DeviceId', w0,
                    'DeviceDetails', w0,
                    'EStatus', w1,
                    'Note', w0,
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
