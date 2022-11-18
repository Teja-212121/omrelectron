namespace Rio.Workspace {
    export interface AssignSheetTypesForm {
        Tenants: Serenity.LookupEditor;
        RowIds: Serenity.StringEditor;
    }

    export class AssignSheetTypesForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.AssignSheetTypesForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!AssignSheetTypesForm.init)  {
                AssignSheetTypesForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;

                Q.initFormType(AssignSheetTypesForm, [
                    'Tenants', w0,
                    'RowIds', w1
                ]);
            }
        }
    }
}
