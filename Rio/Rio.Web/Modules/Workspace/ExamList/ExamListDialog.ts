import { Decorators,  EntityDialog, TabsExtensions } from '@serenity-is/corelib';
import { ExamListForm, ExamListRow, ExamListService } from '../../ServerTypes/Workspace';
import { ExamListExamsGrid } from '../ExamListExams/ExamListExamsGrid';

@Decorators.registerClass()
export class ExamListDialog extends EntityDialog<ExamListRow, any> {
    protected getFormKey() { return ExamListForm.formKey; }
    protected getIdProperty() { return ExamListRow.idProperty; }
    protected getLocalTextPrefix() { return ExamListRow.localTextPrefix; }
    protected getNameProperty() { return ExamListRow.nameProperty; }
    protected getService() { return ExamListService.baseUrl; }
    protected getDeletePermission() { return ExamListRow.deletePermission; }
    protected getInsertPermission() { return ExamListRow.insertPermission; }
    protected getUpdatePermission() { return ExamListRow.updatePermission; }

    protected form = new ExamListForm(this.idPrefix);
    private examListExamsGrid: ExamListExamsGrid;
    private loadedState: string;

    constructor() {
        super();

        this.examListExamsGrid = new ExamListExamsGrid(this.byId('ExamListExamsGrid'));
        // force order dialog to open in Dialog mode instead of Panel mode
        // which is set as default on OrderDialog with @panelAttribute
        this.examListExamsGrid.openDialogsAsPanel = false;

    }

    getSaveState() {
        try {
            return $.toJSON(this.getSaveEntity());
        }
        catch (e) {
            return null;
        }
    }

    loadResponse(data) {
        super.loadResponse(data);
        this.loadedState = this.getSaveState();
    }

    loadEntity(entity: ExamListRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'ExamListExams', this.isNewOrDeleted());

        this.examListExamsGrid.ExamListId = entity.Id;
        
        
    }

    protected afterLoadEntity() {
        super.afterLoadEntity();
        this.examListExamsGrid.ExamListId = this.entityId;
    }

    onSaveSuccess(response) {
        super.onSaveSuccess(response);
        TabsExtensions.setDisabled(this.tabs, 'ExamListExams', this.isNewOrDeleted());
        this.loadedState = this.getSaveState();
    }

    getTemplate() {
        return `<div id="~_Tabs" class="s-DialogContent">
    <ul>
        <li><a href="#~_TabInfo"><span>General</span></a></li>
        <li><a href="#~_TabExamListExams"><span>Exam List Exams</span></a></li>
       
    </ul>
    <div id="~_TabInfo" class="tab-pane s-TabInfo">
        <div id="~_Toolbar" class="s-DialogToolbar">
        </div>
        <div class="s-Form">
            <form id="~_Form" action="">
                <div class="fieldset ui-widget ui-widget-content ui-corner-all">
                    <div id="~_PropertyGrid"></div>
                    <div class="clear"></div>
                </div>
            </form>
        </div>
    </div>
    <div id="~_TabExamListExams" class="tab-pane s-ExamListExams">
        <div id="~_ExamListExamsGrid">

        </div>
    </div>
    
</div>`;
    }
}