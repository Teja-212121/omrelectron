import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExamSectionColumns, ExamSectionRow, ExamSectionService } from '../../ServerTypes/Workspace';
import { ExamSectionDialog } from './ExamSectionDialog';

@Decorators.registerClass()
export class ExamSectionGrid extends EntityGrid<ExamSectionRow, any> {
    protected getColumnsKey() { return ExamSectionColumns.columnsKey; }
    protected getDialogType() { return ExamSectionDialog; }
    protected getIdProperty() { return ExamSectionRow.idProperty; }
    protected getInsertPermission() { return ExamSectionRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamSectionRow.localTextPrefix; }
    protected getService() { return ExamSectionService.baseUrl; }

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
    protected createToolbarExtensions() {
        super.createToolbarExtensions();
        this.rowSelection = new GridRowSelectionMixin(this);
    }
    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(1, 3);

        buttons.push({
            title: 'Delete Exam Section', cssClass: 'delete-button',
            onClick: () => {

                var rowKeys = this.rowSelection.getSelectedKeys();
                if (rowKeys.length == 0) {
                    Q.alert("Please select record(s)");
                    return;
                }
                else {
                    Q.confirm('Are you sure you want to Delete?', () => {

                        Q.serviceRequest('/Services/Workspace/ExamSection/DeleteExamSection', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
                    });

                }
            }
        });

        return buttons;
    }
}