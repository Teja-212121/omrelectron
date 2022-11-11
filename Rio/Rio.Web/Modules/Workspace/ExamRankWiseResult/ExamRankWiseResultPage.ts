import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamRankWiseResultGrid } from './ExamRankWiseResultGrid';

$(function() {
    initFullHeightGridPage(new ExamRankWiseResultGrid($('#GridDiv')).element);
});