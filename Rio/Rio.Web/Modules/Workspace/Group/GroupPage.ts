import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { GroupGrid } from './GroupGrid';

$(function() {
    initFullHeightGridPage(new GroupGrid($('#GridDiv')).element);
});