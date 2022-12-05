namespace Rio.Workspace {
    export interface TheoryExamSectionsForm {
        Name: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        TheoryExamId: Serenity.LookupEditor;
        ParentId: Serenity.IntegerEditor;
        SortOrder: Serenity.DecimalEditor;
    }

    export class TheoryExamSectionsForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.TheoryExamSections';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TheoryExamSectionsForm.init)  {
                TheoryExamSectionsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DecimalEditor;

                Q.initFormType(TheoryExamSectionsForm, [
                    'Name', w0,
                    'Description', w0,
                    'TheoryExamId', w1,
                    'ParentId', w2,
                    'SortOrder', w3
                ]);
            }
        }
    }
}
