import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ImportedScannedQuestionGrid } from './ImportedScannedQuestionGrid';

$(function() {
    initFullHeightGridPage(new ImportedScannedQuestionGrid($('#GridDiv')).element);
});