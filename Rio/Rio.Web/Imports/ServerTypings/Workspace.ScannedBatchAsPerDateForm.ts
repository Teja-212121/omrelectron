namespace Rio.Workspace {
    export interface ScannedBatchAsPerDateForm {
        Name: Serenity.StringEditor;
        ScanBatchid: Serenity.LookupEditor;
        InsertDate: Serenity.DateEditor;
        IsActive: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class ScannedBatchAsPerDateForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ScannedBatchAsPerDate';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ScannedBatchAsPerDateForm.init)  {
                ScannedBatchAsPerDateForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DateEditor;
                var w3 = s.IntegerEditor;

                Q.initFormType(ScannedBatchAsPerDateForm, [
                    'Name', w0,
                    'ScanBatchid', w1,
                    'InsertDate', w2,
                    'IsActive', w3,
                    'TenantId', w3
                ]);
            }
        }
    }
}
