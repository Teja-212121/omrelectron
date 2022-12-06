import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TheoryExamResultQuestionsGrid } from './TheoryExamResultQuestionsGrid';

$(function() {
    initFullHeightGridPage(new TheoryExamResultQuestionsGrid($('#GridDiv')).element);
});