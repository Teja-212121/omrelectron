namespace Rio.Workspace {
    export interface CouponCodeForm {
        Code: Serenity.StringEditor;
        ExamListId: Serenity.IntegerEditor;
        ValidityType: Serenity.EnumEditor;
        CountType: Serenity.EnumEditor;
        Count: Serenity.IntegerEditor;
        ValidityInDays: Serenity.IntegerEditor;
        ValidDate: Serenity.DateEditor;
        ConsumedCount: Serenity.IntegerEditor;
        CouponValidityDate: Serenity.DateEditor;
    }

    export class CouponCodeForm extends Serenity.PrefixedContext {
        static formKey = 'Workspace.CouponCode';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CouponCodeForm.init)  {
                CouponCodeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.EnumEditor;
                var w3 = s.DateEditor;

                Q.initFormType(CouponCodeForm, [
                    'Code', w0,
                    'ExamListId', w1,
                    'ValidityType', w2,
                    'CountType', w2,
                    'Count', w1,
                    'ValidityInDays', w1,
                    'ValidDate', w3,
                    'ConsumedCount', w1,
                    'CouponValidityDate', w3
                ]);
            }
        }
    }
}
