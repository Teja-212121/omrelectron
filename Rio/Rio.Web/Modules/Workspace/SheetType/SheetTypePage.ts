import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SheetTypeGrid } from './SheetTypeGrid';

$(function() {
    initFullHeightGridPage(new SheetTypeGrid($('#GridDiv')).element);
});