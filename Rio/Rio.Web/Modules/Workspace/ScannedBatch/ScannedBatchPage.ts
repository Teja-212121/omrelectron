import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ScannedBatchGrid } from './ScannedBatchGrid';

$(function() {
    initFullHeightGridPage(new ScannedBatchGrid($('#GridDiv')).element);
});