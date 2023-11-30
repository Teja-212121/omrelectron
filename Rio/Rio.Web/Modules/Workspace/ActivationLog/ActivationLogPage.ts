import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ActivationLogGrid } from './ActivationLogGrid';

$(function() {
    initFullHeightGridPage(new ActivationLogGrid($('#GridDiv')).element);
});