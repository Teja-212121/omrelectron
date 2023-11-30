import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamListGrid } from './ExamListGrid';

$(function() {
    initFullHeightGridPage(new ExamListGrid($('#GridDiv')).element);
});