namespace Rio.Workspace {
    export enum EScannedStatus {
        SuccessfulSheet = 1,
        UnsuccessfulSheet = 2,
        WarningSheet = 3
    }
    Serenity.Decorators.registerEnumType(EScannedStatus, 'Rio.Workspace.EScannedStatus', 'Workspace.EPaperSize');
}
