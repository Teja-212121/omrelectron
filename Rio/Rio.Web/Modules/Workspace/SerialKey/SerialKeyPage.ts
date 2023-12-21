import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SerialKeyGrid } from './SerialKeyGrid';
import "wwwroot/Scripts/daterangepicker/gridcolor.css";

$(function() {
    initFullHeightGridPage(new SerialKeyGrid($('#GridDiv')).element);
});