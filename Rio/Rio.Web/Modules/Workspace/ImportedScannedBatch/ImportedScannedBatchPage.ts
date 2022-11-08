import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ImportedScannedBatchGrid } from './ImportedScannedBatchGrid';

$(function() {
    initFullHeightGridPage(new ImportedScannedBatchGrid($('#GridDiv')).element);
});