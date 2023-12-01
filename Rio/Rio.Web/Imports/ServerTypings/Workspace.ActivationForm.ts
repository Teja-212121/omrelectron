namespace Rio.Workspace {
    export interface ActivationForm {
        ExamListId: Serenity.LookupEditor;
        TeacherId: Serenity.LookupEditor;
        DeviceId: Serenity.StringEditor;
        DeviceDetails: Serenity.StringEditor;
        ActivationDate: Serenity.DateEditor;
        ExpiryDate: Serenity.DateEditor;
        EStatus: Serenity.EnumEditor;
    }

    export class ActivationForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.Activation';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ActivationForm.init)  {
                ActivationForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = s.EnumEditor;

                Q.initFormType(ActivationForm, [
                    'ExamListId', w0,
                    'TeacherId', w0,
                    'DeviceId', w1,
                    'DeviceDetails', w1,
                    'ActivationDate', w2,
                    'ExpiryDate', w2,
                    'EStatus', w3
                ]);
            }
        }
    }
}
