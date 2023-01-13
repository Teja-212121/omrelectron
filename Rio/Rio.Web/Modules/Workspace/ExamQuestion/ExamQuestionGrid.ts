import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { Authorization, postToService, resolveUrl } from '@serenity-is/corelib/q';
import { ExamQuestionColumns, ExamQuestionRow, ExamQuestionService, RuleTypeRow } from '../../ServerTypes/Workspace';
import { attrEncode, deepClone, Dictionary, first, formatNumber, htmlEncode, notifyError, parseDecimal, parseInteger, parseQueryString, serviceRequest, text, toId, trimToNull, tryFirst } from "@serenity-is/corelib/q";
import { Column, FormatterContext, NonDataRow } from "@serenity-is/sleekgrid";
import { ExamQuestionDialog } from './ExamQuestionDialog';
import { ExamQuestionImportDialog } from './ExamQuestionImportDialog';
import { ExamQuestionUpdateDialog } from './ExamQuestionUpdateDialog';

const fld = ExamQuestionRow.Fields;

@Decorators.registerClass()
export class ExamQuestionGrid extends EntityGrid<ExamQuestionRow, any> {
    protected getColumnsKey() { return ExamQuestionColumns.columnsKey; }
    protected getDialogType() { return <any>ExamQuestionDialog; }
    protected getIdProperty() { return ExamQuestionRow.idProperty; }
    protected getInsertPermission() { return ExamQuestionRow.insertPermission; }
    protected getLocalTextPrefix() { return ExamQuestionRow.localTextPrefix; }
    protected getService() { return ExamQuestionService.baseUrl; }

    private pendingChanges: Dictionary<any> = {};
    public rowSelection: GridRowSelectionMixin;

    constructor(container: JQuery) {
        super(container);
        this.rowSelection = new GridRowSelectionMixin(this);
        this.slickContainer.on('change', '.edit:input', (e) => this.inputsChange(e));
    }

    get selectedItems() {
        return this.rowSelection.getSelectedKeys().map(x => this.view.getItemById(x));
    }
    
    protected onViewProcessData(response) {
        this.pendingChanges = {};
        this.setSaveButtonState();
        return super.onViewProcessData(response);
    }

    // PLEASE NOTE! Inline editing in grids is not something Serenity supports nor recommends.
    // SlickGrid has some set of limitations, UI is very hard to use on some devices like mobile, 
    // custom widgets and validations are not possible, and as a bonus the code can become a mess.
    // 
    // This was just a sample how-to after much requests, and is not supported. 
    // This is all we can offer, please don't ask us to Guide you...

    /**
     * It would be nice if we could use autonumeric, Serenity editors etc. here, to control input validation,
     * but it's not supported by SlickGrid as we are only allowed to return a string, and should attach
     * no event handlers to rendered cell contents
     */
    private numericInputFormatter(ctx) {
        if ((ctx.item as NonDataRow).__nonDataRow)
            return htmlEncode(formatNumber(ctx.value, '#0.##'));

        var klass = 'edit numeric';
        var item = ctx.item as ExamQuestionRow;
        var pending = this.pendingChanges[item.Id];

        if (pending && pending[ctx.column.field] !== undefined) {
            klass += ' dirty';
        }

        var value = this.getEffectiveValue(item, ctx.column.field) as number;

        return "<input type='text' class='" + klass +
            "' data-field='" + ctx.column.field +
            "' value='" + formatNumber(value, '0.##') + "'/>";
    }

    private stringInputFormatter(ctx) {
        if ((ctx.item as NonDataRow).__nonDataRow)
            return htmlEncode(ctx.value);

        var klass = 'edit string';
        var item = ctx.item as ExamQuestionRow;
        var pending = this.pendingChanges[item.Id];
        var column = ctx.column as Column;

        if (pending && pending[column.field] !== undefined) {
            klass += ' dirty';
        }

        var value = this.getEffectiveValue(item, column.field) as string;

        return "<input type='text' class='" + klass +
            "' data-field='" + column.field +
            "' value='" + attrEncode(value) +
            "' maxlength='" + column.sourceItem.maxLength + "'/>";
    }

    /**
     * Sorry but you cannot use LookupEditor, e.g. Select2 here, only possible is a SELECT element
     */
    private selectFormatter(ctx: FormatterContext, idField: string, lookup: Q.Lookup<any>) {
        if ((ctx.item as NonDataRow).__nonDataRow)
            return htmlEncode(ctx.value);

        var klass = 'edit';
        var item = ctx.item as ExamQuestionRow;
        var pending = this.pendingChanges[item.Id];
        var column = ctx.column as Column;

        if (pending && pending[idField] !== undefined) {
            klass += ' dirty';
        }

        var value = this.getEffectiveValue(item, idField);
        var markup = "<select class='" + klass +
            "' data-field='" + idField +
            "' style='width: 100%; max-width: 100%'>" +
            "<option value=''>--</option>";
        for (var c of lookup.items) {
            let id = c[lookup.idField];
            markup += "<option value='" + attrEncode(id) + "'"
            if (id == value) {
                markup += " selected";
            }
            markup += ">" + htmlEncode(c[lookup.textField]) + "</option>";
        }
        return markup + "</select>";
    }

    private getEffectiveValue(item, field): any {
        var pending = this.pendingChanges[item.Id];
        if (pending && pending[field] !== undefined) {
            return pending[field];
        }

        return item[field];
    }

    private inputsChange(e: JQueryEventObject) {
        var cell = this.slickGrid.getCellFromEvent(e);
        var item = this.itemAt(cell.row);
        var input = $(e.target);
        var field = input.data('field');
        var txt = trimToNull(input.val());
        var pending = this.pendingChanges[item.Id];

        var effective = this.getEffectiveValue(item, field);
        var oldText: string;
        if (input.hasClass("numeric"))
            oldText = formatNumber(effective, '0.##');
        else
            oldText = effective as string;

        var value;
        if (field === 'UnitPrice') {
            value = parseDecimal(txt ?? '');
            if (value == null || isNaN(value)) {
                notifyError(text('Validation.Decimal'), '', null);
                input.val(oldText);
                input.focus();
                return;
            }
        }
        else if (input.hasClass("numeric")) {
            var i = parseInteger(txt ?? '');
            if (isNaN(i) || i > 32767 || i < 0) {
                notifyError(text('Validation.Integer'), '', null);
                input.val(oldText);
                input.focus();
                return;
            }
            value = i;
        }
        else if (input.is('select'))
            value = toId(input.val());
        else
            value = txt;

        if (!pending) {
            this.pendingChanges[item.Id] = pending = {};
        }

        pending[field] = value;
        item[field] = value;
        this.view.refresh();

        if (input.hasClass("numeric"))
            value = formatNumber(value, '0.##');

        input.val(value).addClass('dirty');

        this.setSaveButtonState();
    }

    private setSaveButtonState() {
        this.toolbar.findButton('apply-changes-button').toggleClass('disabled',
            Object.keys(this.pendingChanges).length === 0);
    }

    private saveClick() {
        if (Object.keys(this.pendingChanges).length === 0) {
            return;
        }

        // this calls save service for all modified rows, one by one
        // you could write a batch update service
        var keys = Object.keys(this.pendingChanges);
        var current = -1;
        var self = this;

        (function saveNext() {
            if (++current >= keys.length) {
                self.refresh();
                return;
            }

            var key = keys[current];
            var entity = deepClone(self.pendingChanges[key]);
            entity.Id = key;
            serviceRequest("Workspace/ExamQuestion/Update", {
                EntityId: key,
                Entity: entity
            }, (response) => {
                delete self.pendingChanges[key];
                saveNext();
            });
        })();
    }

    protected getColumns() {
        var columns = super.getColumns();
        var num = ctx => this.numericInputFormatter(ctx);
        var str = ctx => this.stringInputFormatter(ctx);
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        first(columns, x => x.field === fld.Score).format = str;

        var category = first(columns, x => x.field === fld.RuleTypeName);
        category.referencedFields = [fld.RuleTypeId];
        category.format = ctx => this.selectFormatter(ctx, fld.RuleTypeId, RuleTypeRow.getLookup());

        first(columns, x => x.field === fld.RightOptions).format = str;

        if (!Authorization.hasPermission("Administration:Security")) {
            columns = columns.filter(f => f.field != ExamQuestionRow.Fields.TenantId);
        }
        return columns;

    }

    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(1, 4);

        buttons.push({
            title: 'Save Changes',
            cssClass: 'apply-changes-button disabled',
            onClick: e => this.saveClick()
        });

        buttons.push({
            title: 'Assign to ExamSection',
            cssClass: 'edit-button',
            onClick: () => {
                var SelectedKeys = this.rowSelection.getSelectedKeys();
                if (SelectedKeys.length == 0) {
                    alert("Please select atleast one Exam Question!");
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
            }
        });

        buttons.push({
            title: 'Download Sample',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                /*  debugger;*/
                var url = "~/Workspace/ExamQuestion/ExamQuestionSample";
                /*var url = "~/Uploads/ProductsImportSample.xlsx";*/

                postToService({ url: resolveUrl(url), request: '', target: '_blank' });
            }
        });

        buttons.push({
            title: 'Delete Exam Question', cssClass: 'delete-button',
            onClick: () => {

                var rowKeys = this.rowSelection.getSelectedKeys();
                if (rowKeys.length == 0) {
                    alert("Please select record(s)");
                    return;
                }
                else {
                    Q.confirm('Are you sure you want to Delete?', () => {

                        serviceRequest('/Services/Workspace/ExamQuestion/DeleteExamQuestion', rowKeys, (response) => { this.rowSelection.resetCheckedAndRefresh(), this.refresh() });
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
            this.setEquality(ExamQuestionRow.Fields.ExamId, value);
            this.refresh();
        }
    }
}
