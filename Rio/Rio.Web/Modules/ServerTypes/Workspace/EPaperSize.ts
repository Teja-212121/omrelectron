import { Decorators } from "@serenity-is/corelib";

export enum EPaperSize {
    A4 = 4,
    A5 = 5
}
Decorators.registerEnumType(EPaperSize, 'Rio.Workspace.EPaperSize', 'Workspace.EPaperSize');
