namespace Rio {
    export interface ExcelImportRequest extends Serenity.ServiceRequest {
        FileName?: string;
        ExamId?: number;
        ScannedSheetId?: number;
        TenantId?: number;
    }
}
