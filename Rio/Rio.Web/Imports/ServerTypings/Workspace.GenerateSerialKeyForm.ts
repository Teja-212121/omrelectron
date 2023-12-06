namespace Rio.Workspace {
    export interface GenerateSerialKeyForm {
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
                var w0 = s.IntegerEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(GenerateSerialKeyForm, [
                    'Quantity', w0,
                    'ExamListId', w1
                ]);
            }
        }
    }
}
