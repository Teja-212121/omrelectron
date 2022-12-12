import { Decorators, EntityDialog, TabsExtensions } from '@serenity-is/corelib';
import { Authorization, first, isEmptyOrNull } from '@serenity-is/corelib/q';
import { ExamForm, ExamRow, ExamService } from '../../ServerTypes/Workspace';
import { ExamQuestionGrid } from '../ExamQuestion/ExamQuestionGrid';
import { ExamSectionGrid } from '../ExamSection/ExamSectionGrid';

@Decorators.registerClass()
@Decorators.panel()
export class ExamDialog extends EntityDialog<ExamRow, any> {
    protected getFormKey() { return ExamForm.formKey; }
    protected getIdProperty() { return ExamRow.idProperty; }
    protected getLocalTextPrefix() { return ExamRow.localTextPrefix; }
    protected getNameProperty() { return ExamRow.nameProperty; }
    protected getService() { return ExamService.baseUrl; }
    protected getDeletePermission() { return ExamRow.deletePermission; }
    protected getInsertPermission() { return ExamRow.insertPermission; }
    protected getUpdatePermission() { return ExamRow.updatePermission; }

    protected form = new ExamForm(this.idPrefix);

    private examSectionGrid: ExamSectionGrid;
    private examQuestionGrid: ExamQuestionGrid;
    private loadedState: string;

    constructor() {
        super();

        if (!Authorization.hasPermission("Administration:Security")) {
            this.form.SelectedTenant.getGridField().toggle(false);
        }

        this.examSectionGrid = new ExamSectionGrid(this.byId('ExamSectionGrid'));
        this.examSectionGrid.openDialogsAsPanel = false;
        this.examQuestionGrid = new ExamQuestionGrid(this.byId('ExamQuestionGrid'));
        this.examQuestionGrid.openDialogsAsPanel = false;
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

    loadEntity(entity: ExamRow) {
        super.loadEntity(entity);

        TabsExtensions.setDisabled(this.tabs, 'ExamSection', this.isNewOrDeleted());
        TabsExtensions.setDisabled(this.tabs, 'ExamQuestion', this.isNewOrDeleted());
        this.examSectionGrid.ExamId = entity.Id;
        this.examQuestionGrid.ExamId = entity.Id;
    }

    protected afterLoadEntity() {
        super.afterLoadEntity();
        this.entity.TenantId = this.entity.TenantId;
        this.examSectionGrid.ExamId = this.entityId;
        this.examQuestionGrid.ExamId = this.entityId;
    }

    onSaveSuccess(response) {
        super.onSaveSuccess(response);
        TabsExtensions.setDisabled(this.tabs, 'ExamSection', this.isNewOrDeleted());
        this.loadedState = this.getSaveState();
    }

    getTemplate() {
        return `<div id="~_Tabs" class="s-DialogContent">
    <ul>
        <li><a href="#~_TabInfo"><span>General</span></a></li>
        <li><a href="#~_TabExamSection"><span>Exam Section </span></a></li>
        <li><a href="#~_TabExamQuestion"><span>Exam Question </span></a></li>
       
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
    <div id="~_TabExamSection" class="tab-pane s-ExamSection">
        <div id="~_ExamSectionGrid">

        </div>
    </div>
    <div id="~_TabExamQuestion" class="tab-pane s-ExamQuestion">
        <div id="~_ExamQuestionGrid">

        </div>
    </div>
</div>`;
    }

}