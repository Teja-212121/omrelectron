import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamGrid } from './ExamGrid';

$(function() {
    initFullHeightGridPage(new ExamGrid($('#GridDiv')).element);
});