import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamQuestionRow, ExamQuestionService, ExamQuestionUpdateForm } from '../../ServerTypes/Workspace';
import { ExamQuestionGrid } from './ExamQuestionGrid';

    @Decorators.registerClass()
    export class ExamQuestionUpdateDialog extends EntityDialog<ExamQuestionRow, any> {
        protected getFormKey() { return ExamQuestionUpdateForm.formKey; }
        protected getIdProperty() { return ExamQuestionRow.idProperty; }
        protected getLocalTextPrefix() { return ExamQuestionRow.localTextPrefix; }
        protected getService() { return ExamQuestionService.baseUrl; }

        protected form = new ExamQuestionUpdateForm(this.idPrefix);
        public rowids: string;

        private checkGrid: ExamQuestionGrid;
        constructor(gridToRefresh, FormMode, selectedids) {
            super();
            this.checkGrid = gridToRefresh;
            this.form = new ExamQuestionUpdateForm(this.idPrefix);
            this.rowids = selectedids;            
        }
        
        loadEntity(entity:ExamQuestionRow) {
            super.loadEntity(entity);
            this.form.RowIds.value = this.rowids;
        }

        onSaveSuccess(response) {
            super.onSaveSuccess(response);
            if (this.form.RowIds.value != "") {
                Q.notifySuccess("Updated sucessfully");
                this.checkGrid.rowSelection.resetCheckedAndRefresh();
                this.checkGrid.refresh();
            }
        }
    }