import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SheetTypeTenantGrid } from './SheetTypeTenantGrid';

$(function() {
    initFullHeightGridPage(new SheetTypeTenantGrid($('#GridDiv')).element);
});