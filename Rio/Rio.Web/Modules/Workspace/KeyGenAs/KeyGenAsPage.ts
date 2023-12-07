import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { KeyGenAsGrid } from './KeyGenAsGrid';

$(function() {
    initFullHeightGridPage(new KeyGenAsGrid($('#GridDiv')).element);
});