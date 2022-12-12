namespace Rio.Workspace.enums {
    export enum EScannedStatus {
        OpenSheet = 0,
        FailedSheet = 1,
        WarningSheet = 2,
        SuccessSheet = 3
    }
    Serenity.Decorators.registerEnumType(EScannedStatus, 'Rio.Workspace.enums.EScannedStatus', 'Workspace.EScannedStatus');
}
