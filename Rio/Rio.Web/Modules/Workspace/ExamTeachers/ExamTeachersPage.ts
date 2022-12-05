import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamTeachersGrid } from './ExamTeachersGrid';

$(function() {
    initFullHeightGridPage(new ExamTeachersGrid($('#GridDiv')).element);
});