namespace Rio.Workspace {
    export namespace PermissionKeys {
        export const General = "Workspace:General";
        export const GroupStudents = "Workspace:GroupStudents";
        export const Exams = "Workspace:Exams";
        export const ScannedData = "Workspace:ScannedData";

        namespace SheetType {
            export const Delete = "Workspace:SheetType:Delete";
            export const Modify = "Workspace:SheetType:Modify";
            export const View = "Workspace:SheetType:View";
        }

        namespace SheetTypeTenant {
            export const Delete = "Workspace:SheetTypeTenant:Delete";
            export const Modify = "Workspace:SheetTypeTenant:Modify";
            export const View = "Workspace:SheetTypeTenant:View";
        }
    }
}
