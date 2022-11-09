import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { ExcelExportHelper } from '@serenity-is/extensions';
import { StudentColumns, StudentRow, StudentService } from '../../ServerTypes/Workspace';
import { GroupStudentsForStudentsDialog } from '../GroupStudent/GroupStudentsForStudentsDialog';
import { StudentDialog } from './StudentDialog';
import { StudentExcelImportDialog } from './StudentExcelImportDialog';

@Decorators.registerClass()
export class StudentGrid extends EntityGrid<StudentRow, any> {
    protected getColumnsKey() { return StudentColumns.columnsKey; }
    protected getDialogType() { return StudentDialog; }
    protected getIdProperty() { return StudentRow.idProperty; }
    protected getInsertPermission() { return StudentRow.insertPermission; }
    protected getLocalTextPrefix() { return StudentRow.localTextPrefix; }
    protected getService() { return StudentService.baseUrl; }

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
        buttons.splice(1, 3);

        /*buttons.push({
            title: 'Assign to Exam',
            cssClass: 'edit-button',
            onClick: () => {
                var SelectedKeys = this.rowSelection.getSelectedKeys();
                if (SelectedKeys.length == 0) {
                    Q.alert("Please select atleast one Student!");
                    return;
                }
                //new Rio.Workspace.ExamForStudentsDialog(this, true, SelectedKeys).loadNewAndOpenDialog();

            },
            separator: true
        });*/

        buttons.push({
            title: 'Assign to Group',
            cssClass: 'add-button',
            onClick: () => {
                var SelectedKeys = this.rowSelection.getSelectedKeys();
                if (SelectedKeys.length == 0) {
                    Q.alert("Please select atleast one Student!");
                    return;
                }
                new GroupStudentsForStudentsDialog(this, true, SelectedKeys).loadNewAndOpenDialog();
            },
            separator: true
        });
        buttons.push({
            title: 'Import From Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                // open import dialog, let it handle rest
                var dialog = new StudentExcelImportDialog();
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.dialogOpen();
            },
            separator: true
        });

        buttons.push({
            title: 'Download  Sample',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                var url = "~/Workspace/Student/StudentSample";

                Q.postToService({ url: Q.resolveUrl(url), request: '', target: '_blank' });
            },
            separator: true
        });

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            title: 'Export',
            service: StudentService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        buttons.push({
            title: 'Delete Student', cssClass: 'delete-button',
            onClick: () => {

                var rowKeys = this.rowSelection.getSelectedKeys();
                if (rowKeys.length == 0) {
                    Q.alert("Please select record(s)");
                    return;
                }
                else {
                    Q.confirm('Are you sure you want to Delete?', () => {

                        Q.serviceRequest('/Services/Workspace/Student/DeleteStudent', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
                    });

                }
            },
            separator: true
        });

        return buttons;
    }
}