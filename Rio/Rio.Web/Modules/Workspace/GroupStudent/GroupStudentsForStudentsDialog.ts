import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GroupStudentRow, GroupStudentService, GroupStudentsForStudentsForm, StudentRow } from '../../ServerTypes/Workspace';
import { StudentGrid } from '../Student/StudentGrid';

@Decorators.registerClass()
export class GroupStudentsForStudentsDialog extends EntityDialog<GroupStudentRow, any> {
    protected getFormKey() { return GroupStudentsForStudentsForm.formKey; }
    protected getService() { return GroupStudentService.baseUrl; }
        /*protected getDeletePermission() { return GroupRow.deletePermission; }
        protected getInsertPermission() { return GroupRow.insertPermission; }
        protected getUpdatePermission() { return GroupRow.updatePermission; }*/

    protected form = new GroupStudentsForStudentsForm(this.idPrefix);
        public rowids: string;

        private checkGrid: StudentGrid;
        constructor(gridToRefresh, FormMode, selectedids) {

            super();

            this.form = new GroupStudentsForStudentsForm(this.idPrefix);
            //debugger;
            this.rowids = selectedids;

            /*this.form.Id.changeSelect2(e => {
                var groupId = Q.toId(this.form.Id.value);
                if (groupId != null) {
                    this.form.Name.value = Workspace.GroupRow.getLookup().itemById[groupId].Name;
                }
            });*/
        }

        loadEntity(entity: StudentRow) {
            //debugger;
            super.loadEntity(entity);
            //debugger;
            this.form.RowIds.value = this.rowids;
            this.form.RowIds.getGridField().toggle(false);

        }

        onSaveSuccess(response) {
            super.onSaveSuccess(response);
            //debugger;
            if (this.form.RowIds.value != "") {
                Q.notifySuccess("Added sucessfully");
                //this.Questionsgrid.rowSelection.resetCheckedAndRefresh();
                //this.Questionsgrid.refresh();
            }
        }
    }