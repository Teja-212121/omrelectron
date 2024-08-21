import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CloudStorageSettingGrid } from './CloudStorageSettingGrid';

$(function() {
    initFullHeightGridPage(new CloudStorageSettingGrid($('#GridDiv')).element);
});