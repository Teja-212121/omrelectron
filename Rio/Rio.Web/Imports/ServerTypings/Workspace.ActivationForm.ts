namespace Rio.Workspace {
    export interface ActivationForm {
        ExamListId: Serenity.IntegerEditor;
        TeacherId: Serenity.IntegerEditor;
        DeviceId: Serenity.StringEditor;
        DeviceDetails: Serenity.StringEditor;
        ActivationDate: Serenity.DateEditor;
        ExpiryDate: Serenity.DateEditor;
        EStatus: Serenity.IntegerEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
    }

    export class ActivationForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.Activation';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ActivationForm.init)  {
                ActivationForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;

                Q.initFormType(ActivationForm, [
                    'ExamListId', w0,
                    'TeacherId', w0,
                    'DeviceId', w1,
                    'DeviceDetails', w1,
                    'ActivationDate', w2,
                    'ExpiryDate', w2,
                    'EStatus', w0,
                    'InsertDate', w2,
                    'InsertUserId', w0,
                    'UpdateDate', w2,
                    'UpdateUserId', w0,
                    'IsActive', w0
                ]);
            }
        }
    }
}
