import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamSectionGrid } from './ExamSectionGrid';

$(function() {
    initFullHeightGridPage(new ExamSectionGrid($('#GridDiv')).element);
});