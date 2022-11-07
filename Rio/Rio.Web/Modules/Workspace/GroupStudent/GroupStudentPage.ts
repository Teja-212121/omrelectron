import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { GroupStudentGrid } from './GroupStudentGrid';

$(function() {
    initFullHeightGridPage(new GroupStudentGrid($('#GridDiv')).element);
});