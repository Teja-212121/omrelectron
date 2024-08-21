import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CloudStorageProviderGrid } from './CloudStorageProviderGrid';

$(function() {
    initFullHeightGridPage(new CloudStorageProviderGrid($('#GridDiv')).element);
});