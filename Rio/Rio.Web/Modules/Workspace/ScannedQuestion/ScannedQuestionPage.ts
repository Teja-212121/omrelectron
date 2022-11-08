import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ScannedQuestionGrid } from './ScannedQuestionGrid';

$(function() {
    initFullHeightGridPage(new ScannedQuestionGrid($('#GridDiv')).element);
});