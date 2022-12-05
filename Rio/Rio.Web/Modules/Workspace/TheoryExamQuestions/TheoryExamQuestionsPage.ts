import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TheoryExamQuestionsGrid } from './TheoryExamQuestionsGrid';

$(function() {
    initFullHeightGridPage(new TheoryExamQuestionsGrid($('#GridDiv')).element);
});