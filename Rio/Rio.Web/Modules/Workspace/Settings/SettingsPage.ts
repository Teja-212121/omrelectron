import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SettingsGrid } from './SettingsGrid';

$(function() {
    initFullHeightGridPage(new SettingsGrid($('#GridDiv')).element);
});