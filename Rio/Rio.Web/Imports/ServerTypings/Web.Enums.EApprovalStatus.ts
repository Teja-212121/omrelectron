namespace Rio.Web.Enums {
    export enum EApprovalStatus {
        Pending = 1,
        Approved = 2,
        Rejected = 3
    }
    Serenity.Decorators.registerEnumType(EApprovalStatus, 'Rio.Web.Enums.EApprovalStatus');
}
