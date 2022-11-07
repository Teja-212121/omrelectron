import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { StudentGrid } from './StudentGrid';

$(function() {
    initFullHeightGridPage(new StudentGrid($('#GridDiv')).element);
});