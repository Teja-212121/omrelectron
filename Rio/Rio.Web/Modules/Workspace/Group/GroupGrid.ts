import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { GroupColumns, GroupRow, GroupService } from '../../ServerTypes/Workspace';
import { GroupDialog } from './GroupDialog';

@Decorators.registerClass()
export class GroupGrid extends EntityGrid<GroupRow, any> {
    protected getColumnsKey() { return GroupColumns.columnsKey; }
    protected getDialogType() { return GroupDialog; }
    protected getIdProperty() { return GroupRow.idProperty; }
    protected getInsertPermission() { return GroupRow.insertPermission; }
    protected getLocalTextPrefix() { return GroupRow.localTextPrefix; }
    protected getService() { return GroupService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(1, 3);

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            title: 'Export',
            service: GroupService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));
        return buttons;
    }
}