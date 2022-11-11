import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamGroupWiseResultGrid } from './ExamGroupWiseResultGrid';

$(function() {
    initFullHeightGridPage(new ExamGroupWiseResultGrid($('#GridDiv')).element);
});