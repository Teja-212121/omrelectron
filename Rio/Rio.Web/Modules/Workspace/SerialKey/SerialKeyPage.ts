import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SerialKeyGrid } from './SerialKeyGrid';

$(function() {
    initFullHeightGridPage(new SerialKeyGrid($('#GridDiv')).element);
});