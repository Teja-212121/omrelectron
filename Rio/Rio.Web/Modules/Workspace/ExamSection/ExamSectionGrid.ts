import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { serviceRequest } from '@serenity-is/corelib/q';
import { ExamSectionColumns, ExamSectionRow, ExamSectionService } from '../../ServerTypes/Workspace';
import { ExamSectionDialog } from './ExamSectionDialog';

@Decorators.registerClass()
export class ExamSectionGrid extends EntityGrid<ExamSectionRow, any> {
    protected getColumnsKey() { return ExamSectionColumns.columnsKey; }
    protected getDialogType() { return <any>ExamSectionDialog; }
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
                    alert("Please select record(s)");
                    return;
                }
                else {
                    Q.confirm('Are you sure you want to Delete?', () => {

                        serviceRequest('/Services/Workspace/ExamSection/DeleteExamSection', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
                    });

                }
            }
        });

        return buttons;
    }

    protected addButtonClick() {
        this.editItem({ ExamId: this.ExamId });
    }

    protected usePager() {
        return false;
    }

    protected getGridCanLoad() {
        return this.ExamId != null;
    }

    private _ExamId: number;

    get ExamId() {
        return this._ExamId;
    }

    set ExamId(value: number) {
        //debugger;
        if (this._ExamId != value) {
            this._ExamId = value;
            this.setEquality(ExamSectionRow.Fields.ExamId, value);
            this.refresh();
        }
    }
}