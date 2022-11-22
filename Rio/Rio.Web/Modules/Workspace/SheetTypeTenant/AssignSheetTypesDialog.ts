import { Decorators, EntityDialog, ToolButton } from '@serenity-is/corelib'
import { AssignSheetTypesForm, SheetTypeTenantRow, SheetTypeTenantService } from '../../ServerTypes/Workspace';

    @Decorators.registerClass()
    /* @Decorators.responsive()*/
    export class AssignSheetTypesDialog extends EntityDialog<SheetTypeTenantRow, any> {
        protected getFormKey() { return AssignSheetTypesForm.formKey; }
        protected getService() { return SheetTypeTenantService.baseUrl; }

        protected form = new AssignSheetTypesForm(this.idPrefix);

        /*private Studentgrid: Workspace.InlineImageInGrid;*/
        private IsEditMode: boolean;
        private rowids: string;

        constructor(gridToRefresh, FormMode, selectedids) {
            super();
            /*this.Studentgrid = gridToRefresh;*/
            this.IsEditMode = FormMode;
            this.rowids = selectedids;
            this.dialogTitle = "Assign Sheet to Tenant";
        }
        protected getToolbarButtons(): ToolButton[] {
            let buttons = super.getToolbarButtons();
            //debugger;
            buttons.splice(0, 6);
            buttons.push({
                title: "Assign",
                cssClass: 'edit-permissions-button ',
                icon: 'icon-lock-open text-green',
                onClick: () => {

                    if (!this.validateBeforeSave())
                        return;
                    //debugger;
                    this.entity.TenantId = Number(this.form.Tenants.value);
                    this.entity.RowIds = this.rowids.toString();


                    SheetTypeTenantService.Assign({
                        EntityId: 1,
                        Entity: this.entity

                    }, response => {

                        this.dialogClose();
                        /*this.Studentgrid.refresh();*/
                    });
                }
            });
            buttons.push({
                title: "Cancel",
                onClick: () => { this.dialogClose() }
            });

            return buttons;
        }
    }