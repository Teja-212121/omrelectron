import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamListExamsGrid } from './ExamListExamsGrid';

$(function() {
    initFullHeightGridPage(new ExamListExamsGrid($('#GridDiv')).element);
});