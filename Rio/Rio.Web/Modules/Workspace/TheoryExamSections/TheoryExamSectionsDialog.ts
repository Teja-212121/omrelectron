import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TheoryExamSectionsForm, TheoryExamSectionsRow, TheoryExamSectionsService } from '../../ServerTypes/Workspace';

@Decorators.registerClass()
export class TheoryExamSectionsDialog extends EntityDialog<TheoryExamSectionsRow, any> {
    protected getFormKey() { return TheoryExamSectionsForm.formKey; }
    protected getIdProperty() { return TheoryExamSectionsRow.idProperty; }
    protected getLocalTextPrefix() { return TheoryExamSectionsRow.localTextPrefix; }
    protected getNameProperty() { return TheoryExamSectionsRow.nameProperty; }
    protected getService() { return TheoryExamSectionsService.baseUrl; }
    protected getDeletePermission() { return TheoryExamSectionsRow.deletePermission; }
    protected getInsertPermission() { return TheoryExamSectionsRow.insertPermission; }
    protected getUpdatePermission() { return TheoryExamSectionsRow.updatePermission; }

    protected form = new TheoryExamSectionsForm(this.idPrefix);

}