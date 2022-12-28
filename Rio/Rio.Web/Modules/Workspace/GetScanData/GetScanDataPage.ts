import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { GetScanDataGrid } from './GetScanDataGrid';

$(function() {
    initFullHeightGridPage(new GetScanDataGrid($('#GridDiv')).element);
});