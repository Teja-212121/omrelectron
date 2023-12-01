namespace Rio.Web.Enums {
    export enum KeyStatus {
        Created = 1,
        Open = 2,
        Activated = 3,
        Disabled = 4,
        Expired = 5,
        OfflineActivated = 6
    }
    Serenity.Decorators.registerEnumType(KeyStatus, 'Rio.Web.Enums.KeyStatus');
}
