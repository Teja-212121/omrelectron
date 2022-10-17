import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TenantGrid } from './TenantGrid';

$(function() {
    initFullHeightGridPage(new TenantGrid($('#GridDiv')).element);
});