import { Decorators, PropertyDialog } from "@serenity-is/corelib";
import { DialogButton, notifySuccess } from "@serenity-is/corelib/q";
import { GenerateSerialKeyForm, SerialKeyRow, SerialKeyService } from "../../ServerTypes/Workspace";

@Decorators.registerClass('Rio.Workspace.GenerateSerialKeyDialog')
export class GenerateSerialKeyDialog extends PropertyDialog<SerialKeyRow, any> {
    protected getFormKey() { return GenerateSerialKeyForm.formKey; }
    protected getRowDefinition() { return SerialKeyRow }
    protected getService() { return SerialKeyService.baseUrl; }

    protected form = new GenerateSerialKeyForm(this.idPrefix);

    protected getDialogButtons(): DialogButton[] {
        return [

            {
                text: 'Generate SerialKey',
                click: () => {
                    
                    SerialKeyService.GenerateSerialKey({
                       
                        Quantity: this.form.Quantity.value,
                        ExamListId: Number(this.form.ExamListId.value),
                    }, response => {
                        //debugger;
                        notifySuccess("Codes Generated Successfully");

                        this.dialogClose();
                    });
                },
            },
            {
                text: 'Cancel',
                click: () => this.dialogClose()
            }
        ];
    }

    protected getDialogTitle(): string {
        return "Generate Codes";
    }
}