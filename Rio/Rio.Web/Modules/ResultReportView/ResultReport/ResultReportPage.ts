import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ResultReportGrid } from './ResultReportGrid';

$(function() {
    initFullHeightGridPage(new ResultReportGrid($('#GridDiv')).element);
});