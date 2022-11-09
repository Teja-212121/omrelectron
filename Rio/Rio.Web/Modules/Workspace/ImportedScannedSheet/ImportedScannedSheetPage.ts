import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ImportedScannedSheetGrid } from './ImportedScannedSheetGrid';

$(function() {
    initFullHeightGridPage(new ImportedScannedSheetGrid($('#GridDiv')).element);
});