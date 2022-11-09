import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { RuleTypeColumns, RuleTypeRow, RuleTypeService } from '../../ServerTypes/Workspace';
import { RuleTypeDialog } from './RuleTypeDialog';

@Decorators.registerClass()
export class RuleTypeGrid extends EntityGrid<RuleTypeRow, any> {
    protected getColumnsKey() { return RuleTypeColumns.columnsKey; }
    protected getDialogType() { return RuleTypeDialog; }
    protected getIdProperty() { return RuleTypeRow.idProperty; }
    protected getInsertPermission() { return RuleTypeRow.insertPermission; }
    protected getLocalTextPrefix() { return RuleTypeRow.localTextPrefix; }
    protected getService() { return RuleTypeService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}