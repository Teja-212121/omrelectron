namespace Rio.Web.Enums {
    export enum EValidityType {
        Unlimited = 1,
        FixedDate = 2,
        ValidityInDays = 3
    }
    Serenity.Decorators.registerEnumType(EValidityType, 'Rio.Web.Enums.EValidityType');
}
