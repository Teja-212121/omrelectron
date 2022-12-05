import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TeachersGrid } from './TeachersGrid';

$(function() {
    initFullHeightGridPage(new TeachersGrid($('#GridDiv')).element);
});