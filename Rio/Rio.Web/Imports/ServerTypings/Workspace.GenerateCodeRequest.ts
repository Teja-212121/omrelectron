namespace Rio.Workspace {
    export interface GenerateCodeRequest extends Serenity.ServiceRequest {
        Estatus?: string;
        ExamListId?: number;
        Quantity?: number;
        SerialKey?: number;
    }
}
