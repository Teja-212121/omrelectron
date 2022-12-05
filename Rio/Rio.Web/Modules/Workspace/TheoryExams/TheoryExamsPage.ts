import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TheoryExamsGrid } from './TheoryExamsGrid';

$(function() {
    initFullHeightGridPage(new TheoryExamsGrid($('#GridDiv')).element);
});