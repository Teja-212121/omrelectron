import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamQuestionGrid } from './ExamQuestionGrid';

$(function() {
    initFullHeightGridPage(new ExamQuestionGrid($('#GridDiv')).element);
});