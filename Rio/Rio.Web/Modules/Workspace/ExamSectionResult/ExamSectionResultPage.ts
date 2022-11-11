import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamSectionResultGrid } from './ExamSectionResultGrid';

$(function() {
    initFullHeightGridPage(new ExamSectionResultGrid($('#GridDiv')).element);
});