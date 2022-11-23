import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { MailGrid } from './MailGrid';

$(function() {
    initFullHeightGridPage(new MailGrid($('#GridDiv')).element);
});