import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamQuestionResultGrid } from './ExamQuestionResultGrid';

$(function() {
    initFullHeightGridPage(new ExamQuestionResultGrid($('#GridDiv')).element);
});