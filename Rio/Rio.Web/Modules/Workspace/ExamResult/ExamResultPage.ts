import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamResultGrid } from './ExamResultGrid';

$(function() {
    initFullHeightGridPage(new ExamResultGrid($('#GridDiv')).element);
});