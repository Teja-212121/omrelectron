﻿namespace Rio.Workspace {
    export interface ExamListForm {
        Name: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        Thumbnail: Serenity.ImageUploadEditor;
        TenantId: Serenity.LookupEditor;
    }

    export class ExamListForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.ExamList';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamListForm.init)  {
                ExamListForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.ImageUploadEditor;
                var w3 = s.LookupEditor;

                Q.initFormType(ExamListForm, [
                    'Name', w0,
                    'Description', w1,
                    'Thumbnail', w2,
                    'TenantId', w3
                ]);
            }
        }
    }
}
