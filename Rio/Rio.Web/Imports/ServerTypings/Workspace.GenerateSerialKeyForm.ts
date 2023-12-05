namespace Rio.Workspace {
    export interface GenerateSerialKeyForm {
        SerialKey: Serenity.LookupEditor;
        Quantity: Serenity.IntegerEditor;
        ExamListId: Serenity.LookupEditor;
    }

    export class GenerateSerialKeyForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.GenerateSerialKeyForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!GenerateSerialKeyForm.init)  {
                GenerateSerialKeyForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(GenerateSerialKeyForm, [
                    'SerialKey', w0,
                    'Quantity', w1,
                    'ExamListId', w0
                ]);
            }
        }
    }
}
