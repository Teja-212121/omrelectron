import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ScannedSheetGrid } from './ScannedSheetGrid';

$(function() {
    initFullHeightGridPage(new ScannedSheetGrid($('#GridDiv')).element);
});