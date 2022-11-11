import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExamQuestionColumns, ExamQuestionRow, ExamQuestionService } from '../../ServerTypes/Workspace';
import { ExamQuestionDialog } from './ExamQuestionDialog';
import { ExamQuestionImportDialog } from './ExamQuestionImportDialog';
import { ExamQuestionUpdateDialog } from './ExamQuestionUpdateDialog';

@Decorators.registerClass()
export class ExamQuestionGrid extends EntityGrid<ExamQuestionRow, any> {
    protected getColumnsKey() { return ExamQuestionColumns.columnsKey; }
    protected getDialogType() { return ExamQuestionDialog; }
    protected getIdProperty() { return ExamQuestionRow.idProperty; }
    protected getInsertPermission() { return ExamQuestionRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamQuestionRow.localTextPrefix; }
    protected getService() { return ExamQuestionService.baseUrl; }

    public rowSelection: GridRowSelectionMixin;


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
        buttons.splice(1, 3);
        buttons.push({
            title: 'Assign to ExamSection',
            cssClass: 'edit-button',
            onClick: () => {
                var SelectedKeys = this.rowSelection.getSelectedKeys();
                if (SelectedKeys.length == 0) {
                    Q.alert("Please select atleast one Exam Question!");
                    return;
                }
                new ExamQuestionUpdateDialog(this, true, SelectedKeys).loadNewAndOpenDialog();

            }
        });

        buttons.push({
            title: 'Import From Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                // open import dialog, let it handle rest
                var dialog = new ExamQuestionImportDialog();
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.dialogOpen();
            },
            separator: true
        });


        buttons.push({
            title: 'Download Sample',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                /*  debugger;*/
                var url = "~/Workspace/ExamQuestion/ExamQuestionSample";
                /*var url = "~/Uploads/ProductsImportSample.xlsx";*/

                Q.postToService({ url: Q.resolveUrl(url), request: '', target: '_blank' });
            }
        });

        buttons.push({
            title: 'Delete Exam Question', cssClass: 'delete-button',
            onClick: () => {

                var rowKeys = this.rowSelection.getSelectedKeys();
                if (rowKeys.length == 0) {
                    Q.alert("Please select record(s)");
                    return;
                }
                else {
                    Q.confirm('Are you sure you want to Delete?', () => {

                        Q.serviceRequest('/Services/Workspace/ExamQuestion/DeleteExamQuestion', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
                    });

                }
            }
        });
        return buttons;
    }
}
