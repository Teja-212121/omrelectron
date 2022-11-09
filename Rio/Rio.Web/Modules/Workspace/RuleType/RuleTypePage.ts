import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { RuleTypeGrid } from './RuleTypeGrid';

$(function() {
    initFullHeightGridPage(new RuleTypeGrid($('#GridDiv')).element);
});