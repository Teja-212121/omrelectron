import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { TheoryExamsColumns, TheoryExamsRow, TheoryExamsService } from '../../ServerTypes/Workspace';
import { AssignExamTeachersDialog } from '../ExamTeachers/AssignExamTeachersDialog';
import { TheoryExamsDialog } from './TheoryExamsDialog';

@Decorators.registerClass()
export class TheoryExamsGrid extends EntityGrid<TheoryExamsRow, any> {
    protected getColumnsKey() { return TheoryExamsColumns.columnsKey; }
    protected getDialogType() { return TheoryExamsDialog; }
    protected getIdProperty() { return TheoryExamsRow.idProperty; }
    protected getInsertPermission() { return TheoryExamsRow.insertPermission; }
    protected getLocalTextPrefix() { return TheoryExamsRow.localTextPrefix; }
    protected getService() { return TheoryExamsService.baseUrl; }

    private rowSelection: GridRowSelectionMixin;

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
    }

    protected getColumns() {
        var columns = super.getColumns();
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        return columns;
    }
    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }

    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(1, 2);

        
            buttons.push({
                title: 'Assign to Teacher',
                cssClass: 'send-button',
                onClick: () => {
                    var rowKeys = this.rowSelection.getSelectedKeys();
                    if (rowKeys.length == 0) {
                        Q.alert("Select Exams To Assign");
                        return;
                    }                  
                    else {
                        new AssignExamTeachersDialog(this, true, rowKeys).loadNewAndOpenDialog();
                    }
                },
                separator: true
            });

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            title: 'Export',
            service: TheoryExamsService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        return buttons;
    }
}