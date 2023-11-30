import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ActivationGrid } from './ActivationGrid';

$(function() {
    initFullHeightGridPage(new ActivationGrid($('#GridDiv')).element);
});