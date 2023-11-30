namespace Rio.Workspace {
    export interface CouponCodeForm {
        Code: Serenity.StringEditor;
        ExamListId: Serenity.IntegerEditor;
        ValidityType: Serenity.IntegerEditor;
        CountType: Serenity.IntegerEditor;
        Count: Serenity.IntegerEditor;
        ValidityInDays: Serenity.IntegerEditor;
        ValidDate: Serenity.DateEditor;
        ConsumedCount: Serenity.IntegerEditor;
        CouponValidityDate: Serenity.DateEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        IsActive: Serenity.IntegerEditor;
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
                var w2 = s.DateEditor;

                Q.initFormType(CouponCodeForm, [
                    'Code', w0,
                    'ExamListId', w1,
                    'ValidityType', w1,
                    'CountType', w1,
                    'Count', w1,
                    'ValidityInDays', w1,
                    'ValidDate', w2,
                    'ConsumedCount', w1,
                    'CouponValidityDate', w2,
                    'InsertDate', w2,
                    'InsertUserId', w1,
                    'UpdateDate', w2,
                    'UpdateUserId', w1,
                    'IsActive', w1
                ]);
            }
        }
    }
}
