import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TheoryExamResultsGrid } from './TheoryExamResultsGrid';

$(function() {
    initFullHeightGridPage(new TheoryExamResultsGrid($('#GridDiv')).element);
});