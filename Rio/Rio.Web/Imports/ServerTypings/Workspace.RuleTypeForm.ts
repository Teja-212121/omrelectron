namespace Rio.Workspace {
    export interface RuleTypeForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
    }

    export class RuleTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.RuleType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RuleTypeForm.init)  {
                RuleTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(RuleTypeForm, [
                    'Name', w0,
                    'Description', w0
                ]);
            }
        }
    }
}
