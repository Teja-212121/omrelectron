import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GroupStudentRow, GroupStudentService, GroupStudentsForStudentsForm, StudentRow } from '../../ServerTypes/Workspace';
import { StudentGrid } from '../Student/StudentGrid';

@Decorators.registerClass()
export class GroupStudentsForStudentsDialog extends EntityDialog<GroupStudentRow, any> {
    protected getFormKey() { return GroupStudentsForStudentsForm.formKey; }
    protected getService() { return GroupStudentService.baseUrl; }

    protected form = new GroupStudentsForStudentsForm(this.idPrefix);
        public rowids: string;

        private checkGrid: StudentGrid;
        constructor(gridToRefresh, FormMode, selectedids) {
            super();
            this.form = new GroupStudentsForStudentsForm(this.idPrefix);
            this.rowids = selectedids;
        }

        loadEntity(entity: StudentRow) {
            super.loadEntity(entity);
            this.form.RowIds.value = this.rowids;
        }

        onSaveSuccess(response) {
            super.onSaveSuccess(response);
            if (this.form.RowIds.value != "") {
                Q.notifySuccess("Added sucessfully");
            }
        }
    }