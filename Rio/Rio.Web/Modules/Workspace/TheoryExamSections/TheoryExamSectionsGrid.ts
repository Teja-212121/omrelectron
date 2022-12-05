import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TheoryExamSectionsColumns, TheoryExamSectionsRow, TheoryExamSectionsService } from '../../ServerTypes/Workspace';
import { TheoryExamSectionsDialog } from './TheoryExamSectionsDialog';

@Decorators.registerClass()
export class TheoryExamSectionsGrid extends EntityGrid<TheoryExamSectionsRow, any> {
    protected getColumnsKey() { return TheoryExamSectionsColumns.columnsKey; }
    protected getDialogType() { return TheoryExamSectionsDialog; }
    protected getIdProperty() { return TheoryExamSectionsRow.idProperty; }
    protected getInsertPermission() { return TheoryExamSectionsRow.insertPermission; }
    protected getLocalTextPrefix() { return TheoryExamSectionsRow.localTextPrefix; }
    protected getService() { return TheoryExamSectionsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}