import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TheoryExamSectionsGrid } from './TheoryExamSectionsGrid';

$(function() {
    initFullHeightGridPage(new TheoryExamSectionsGrid($('#GridDiv')).element);
});