import { Decorators, EntityGrid, GridRowSelectionMixin } from '@serenity-is/corelib';
import { attrEncode, deepClone, Dictionary, first, formatNumber, htmlEncode, notifyError, parseDecimal, parseInteger, parseQueryString, serviceRequest, text, toId, trimToNull, tryFirst } from "@serenity-is/corelib/q";
import { Column, FormatterContext, NonDataRow } from "@serenity-is/sleekgrid";
import { ImportedScannedSheetColumns, ImportedScannedSheetRow, ImportedScannedSheetService } from '../../ServerTypes/Workspace';
import { ImportedScannedSheetDialog } from './ImportedScannedSheetDialog';

const fld = ImportedScannedSheetRow.Fields;

@Decorators.registerClass()
@Decorators.filterable()
@Decorators.registerClass()
export class ImportedScannedSheetGrid extends EntityGrid<ImportedScannedSheetRow, any> {
    protected getColumnsKey() { return ImportedScannedSheetColumns.columnsKey; }
    protected getDialogType() { return ImportedScannedSheetDialog; }
    protected getIdProperty() { return ImportedScannedSheetRow.idProperty; }
    protected getInsertPermission() { return ImportedScannedSheetRow.insertPermission; }
    protected getLocalTextPrefix() { return ImportedScannedSheetRow.localTextPrefix; }
    protected getService() { return ImportedScannedSheetService.baseUrl; }

    private pendingChanges: Dictionary<any> = {};
    private rowSelection: GridRowSelectionMixin;

    private ScannedBatchInsertDate;
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
        var item = ctx.item as ImportedScannedSheetRow;
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
        var item = ctx.item as ImportedScannedSheetRow;
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
        var item = ctx.item as ImportedScannedSheetRow;
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
            serviceRequest("Workspace/ImportedScannedSheet/Update", {
                EntityId: key,
                Entity: entity
            }, (response) => {
                delete self.pendingChanges[key];
                saveNext();
            });
        })();
    }

    protected getColumns(): Column[] {
        var columns = super.getColumns();
        var num = ctx => this.numericInputFormatter(ctx);
        var str = ctx => this.stringInputFormatter(ctx);
        columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
        first(columns, x => x.field === fld.CorrectedRollNo).format = str;
        first(columns, x => x.field === fld.CorrectedExamNo).format = str;
        first(columns, x => x.field == fld.ScannedStatus).cssClass += " col-scanned-status";

        columns.splice(2, 0, {
            field: 'View Sheet Question',
            name: '',
            format: ctx => `<a class="inline-action view-sheet-question" title="view sheet question">
                    <i class="fa fa-pencil-square-o"></i></a>`,
            width: 24,
            minWidth: 24,
            maxWidth: 24
        });
        return columns;
    }

    protected getButtons() {
        var buttons = super.getButtons();
        buttons.splice(0, 2);

        buttons.push({
            title: 'Save Changes',
            cssClass: 'apply-changes-button disabled',
            onClick: e => this.saveClick(),
            separator: true
        });

        return buttons;
    }
    protected onClick(e: JQueryEventObject, row: number, cell: number) {
        super.onClick(e, row, cell);

        if (e.isDefaultPrevented())
            return;

        var item = this.itemAt(row);
        var target = $(e.target);

        // if user clicks "i" element, e.g. icon
        if (target.parent().hasClass('inline-action'))
            target = target.parent();

        if (target.hasClass('inline-action')) {
            e.preventDefault();

            if (target.hasClass('view-sheet-question')) {
                var param = {
                    'ScannedSheetId': item.Id
                };
                var url = "/Rectify/ScanQuestions";
                //this.OpenWindowWithPostData(url, "", "ScanQuestions", param);
                Q.postToService({ url: Q.resolveUrl('~/Rectify/ScanQuestions?ScannedSheetId=' + item.Id), request: '', target: '_blank' });
            }
        }
    }

    protected getItemCssClass(item: ImportedScannedSheetRow, index: number): string {
        let klass: string = "";

        if (item.ScannedStatus == 1)
            klass += " failed-sheet";
        else if (item.ScannedStatus == 2)
            klass += " warning-sheet";
        else
            klass += " success-sheet";

        return trimToNull(klass);
    }

    protected OpenWindowWithPostData(url, windowoption, name, params) {
        var form = document.createElement("form");
        form.setAttribute("method", "post");
        form.setAttribute("action", url);
        form.setAttribute("target", name);
        for (var i in params) {
            if (params.hasOwnProperty(i)) {
                var input = document.createElement('input');
                input.type = 'hidden';
                input.name = i;
                input.value = params[i];
                form.appendChild(input);
            }
        }
        document.body.appendChild(form);
        // window.open(url, name, windowoption);
        form.submit();
        document.body.removeChild(form);
    }
}