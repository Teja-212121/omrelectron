import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CouponCodeGrid } from './CouponCodeGrid';

$(function() {
    initFullHeightGridPage(new CouponCodeGrid($('#GridDiv')).element);
});