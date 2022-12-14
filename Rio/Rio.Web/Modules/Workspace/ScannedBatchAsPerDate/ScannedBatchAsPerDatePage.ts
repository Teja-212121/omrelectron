import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ScannedBatchAsPerDateGrid } from './ScannedBatchAsPerDateGrid';

$(function() {
    initFullHeightGridPage(new ScannedBatchAsPerDateGrid($('#GridDiv')).element);
});