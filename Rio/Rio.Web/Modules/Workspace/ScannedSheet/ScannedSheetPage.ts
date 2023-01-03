import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ScannedSheetGrid } from './ScannedSheetGrid';
import "wwwroot/Scripts/daterangepicker/gridcolor.css";



$(function() {
    initFullHeightGridPage(new ScannedSheetGrid($('#GridDiv')).element);
});