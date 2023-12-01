namespace Rio.Workspace {
    export interface ActivationLogForm {
        Code: Serenity.StringEditor;
        SerialKey: Serenity.StringEditor;
        TeacherId: Serenity.LookupEditor;
        ExamListId: Serenity.LookupEditor;
        DeviceId: Serenity.StringEditor;
        DeviceDetails: Serenity.StringEditor;
        EStatus: Serenity.EnumEditor;
        Note: Serenity.TextAreaEditor;
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
                var w1 = s.LookupEditor;
                var w2 = s.EnumEditor;
                var w3 = s.TextAreaEditor;

                Q.initFormType(ActivationLogForm, [
                    'Code', w0,
                    'SerialKey', w0,
                    'TeacherId', w1,
                    'ExamListId', w1,
                    'DeviceId', w0,
                    'DeviceDetails', w0,
                    'EStatus', w2,
                    'Note', w3
                ]);
            }
        }
    }
}
