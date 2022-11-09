namespace Rio.Workspace.enums {
    export enum EScannedStatus {
        SuccessfulSheet = 1,
        UnsuccessfulSheet = 2,
        WarningSheet = 3
    }
    Serenity.Decorators.registerEnumType(EScannedStatus, 'Rio.Workspace.enums.EScannedStatus', 'Workspace.EScannedStatus');
}
