import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SelectSheetTypeGrid } from './SelectSheetTypeGrid';

$(function() {
    initFullHeightGridPage(new SelectSheetTypeGrid($('#GridDiv')).element);
});