import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { MailColumns, MailRow, MailService } from '../../ServerTypes/Common';
import { MailDialog } from './MailDialog';

@Decorators.registerClass()
export class MailGrid extends EntityGrid<MailRow, any> {
    protected getColumnsKey() { return MailColumns.columnsKey; }
    protected getDialogType() { return MailDialog; }
    protected getIdProperty() { return MailRow.idProperty; }
    protected getInsertPermission() { return MailRow.insertPermission; }
    protected getLocalTextPrefix() { return MailRow.localTextPrefix; }
    protected getService() { return MailService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}