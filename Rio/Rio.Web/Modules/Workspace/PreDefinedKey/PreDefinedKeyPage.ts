import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PreDefinedKeyGrid } from './PreDefinedKeyGrid';

$(function() {
    initFullHeightGridPage(new PreDefinedKeyGrid($('#GridDiv')).element);
});