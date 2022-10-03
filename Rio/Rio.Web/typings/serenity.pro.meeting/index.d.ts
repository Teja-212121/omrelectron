/// <reference types="serenity.corelib" />
/// <reference types="jquery" />
/// <reference types="serenity.pro.organization" />
/// <reference types="jquery.validation" />
/// <reference types="jqueryui" />
/// <reference types="serenity.extensions" />
declare namespace Serenity.Pro.Meeting {
    enum DecisionResolutionStatus {
        Unknown = 1,
        InProgress = 2,
        Overdue = 3,
        Postponed = 4,
        Unresolved = 5,
        Resolved = 6
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingAgendaForm {
        Title: StringEditor;
        Description: HtmlReportContentEditor;
        AgendaTypeId: LookupEditor;
        RequestedByContactId: LookupEditor;
        AgendaNumber: IntegerEditor;
        Images: MultipleImageUploadEditor;
        Attachments: MultipleImageUploadEditor;
    }
    class MeetingAgendaForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaRelevantColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingAgendaRelevantForm {
        AgendaId: IntegerEditor;
        ContactId: IntegerEditor;
    }
    class MeetingAgendaRelevantForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingAgendaRelevantRow {
        AgendaRelevantId?: number;
        AgendaId?: number;
        ContactId?: number;
        AgendaMeetingId?: number;
        AgendaNumber?: number;
        ContactTitle?: string;
        ContactFirstName?: string;
        ContactLastName?: string;
        ContactEmail?: string;
        ContactIdentityNo?: string;
        ContactUserId?: number;
    }
    namespace MeetingAgendaRelevantRow {
        const idProperty = "AgendaRelevantId";
        const localTextPrefix = "Serenity.Pro.Meeting.MeetingAgendaRelevant";
        const deletePermission = "Meeting:General";
        const insertPermission = "Meeting:General";
        const readPermission = "Meeting:General";
        const updatePermission = "Meeting:General";
        const enum Fields {
            AgendaRelevantId = "AgendaRelevantId",
            AgendaId = "AgendaId",
            ContactId = "ContactId",
            AgendaMeetingId = "AgendaMeetingId",
            AgendaNumber = "AgendaNumber",
            ContactTitle = "ContactTitle",
            ContactFirstName = "ContactFirstName",
            ContactLastName = "ContactLastName",
            ContactEmail = "ContactEmail",
            ContactIdentityNo = "ContactIdentityNo",
            ContactUserId = "ContactUserId"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    namespace MeetingAgendaRelevantService {
        const baseUrl = "Meeting/MeetingAgendaRelevant";
        function Create(request: SaveRequest<MeetingAgendaRelevantRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<MeetingAgendaRelevantRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MeetingAgendaRelevantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<MeetingAgendaRelevantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Meeting/MeetingAgendaRelevant/Create",
            Update = "Meeting/MeetingAgendaRelevant/Update",
            Delete = "Meeting/MeetingAgendaRelevant/Delete",
            Retrieve = "Meeting/MeetingAgendaRelevant/Retrieve",
            List = "Meeting/MeetingAgendaRelevant/List"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingAgendaRow {
        AgendaId?: number;
        MeetingId?: number;
        AgendaNumber?: number;
        Title?: string;
        Description?: string;
        AgendaTypeId?: number;
        RequestedByContactId?: number;
        Images?: string;
        Attachments?: string;
        MeetingMeetingName?: string;
        MeetingMeetingNumber?: string;
        MeetingMeetingGuid?: string;
        MeetingMeetingTypeId?: number;
        MeetingStartDate?: string;
        MeetingEndDate?: string;
        MeetingLocationId?: number;
        MeetingUnitId?: number;
        MeetingOrganizerContactId?: number;
        MeetingReporterContactId?: number;
        MeetingInsertUserId?: number;
        MeetingInsertDate?: string;
        MeetingUpdateUserId?: number;
        MeetingUpdateDate?: string;
        AgendaTypeName?: string;
        RequestedByContactTitle?: string;
        RequestedByContactFirstName?: string;
        RequestedByContactLastName?: string;
        RequestedByContactFullName?: string;
        RequestedByContactEmail?: string;
        RequestedByContactIdentityNo?: string;
        RequestedByContactUserId?: number;
    }
    namespace MeetingAgendaRow {
        const idProperty = "AgendaId";
        const nameProperty = "Title";
        const localTextPrefix = "Serenity.Pro.Meeting.MeetingAgenda";
        const deletePermission = "Meeting:General";
        const insertPermission = "Meeting:General";
        const readPermission = "Meeting:General";
        const updatePermission = "Meeting:General";
        const enum Fields {
            AgendaId = "AgendaId",
            MeetingId = "MeetingId",
            AgendaNumber = "AgendaNumber",
            Title = "Title",
            Description = "Description",
            AgendaTypeId = "AgendaTypeId",
            RequestedByContactId = "RequestedByContactId",
            Images = "Images",
            Attachments = "Attachments",
            MeetingMeetingName = "MeetingMeetingName",
            MeetingMeetingNumber = "MeetingMeetingNumber",
            MeetingMeetingGuid = "MeetingMeetingGuid",
            MeetingMeetingTypeId = "MeetingMeetingTypeId",
            MeetingStartDate = "MeetingStartDate",
            MeetingEndDate = "MeetingEndDate",
            MeetingLocationId = "MeetingLocationId",
            MeetingUnitId = "MeetingUnitId",
            MeetingOrganizerContactId = "MeetingOrganizerContactId",
            MeetingReporterContactId = "MeetingReporterContactId",
            MeetingInsertUserId = "MeetingInsertUserId",
            MeetingInsertDate = "MeetingInsertDate",
            MeetingUpdateUserId = "MeetingUpdateUserId",
            MeetingUpdateDate = "MeetingUpdateDate",
            AgendaTypeName = "AgendaTypeName",
            RequestedByContactTitle = "RequestedByContactTitle",
            RequestedByContactFirstName = "RequestedByContactFirstName",
            RequestedByContactLastName = "RequestedByContactLastName",
            RequestedByContactFullName = "RequestedByContactFullName",
            RequestedByContactEmail = "RequestedByContactEmail",
            RequestedByContactIdentityNo = "RequestedByContactIdentityNo",
            RequestedByContactUserId = "RequestedByContactUserId"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    namespace MeetingAgendaService {
        const baseUrl = "Meeting/MeetingAgenda";
        function Create(request: SaveRequest<MeetingAgendaRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<MeetingAgendaRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MeetingAgendaRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<MeetingAgendaRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Meeting/MeetingAgenda/Create",
            Update = "Meeting/MeetingAgenda/Update",
            Delete = "Meeting/MeetingAgenda/Delete",
            Retrieve = "Meeting/MeetingAgenda/Retrieve",
            List = "Meeting/MeetingAgenda/List"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaTypeColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingAgendaTypeForm {
        Name: StringEditor;
    }
    class MeetingAgendaTypeForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingAgendaTypeRow {
        AgendaTypeId?: number;
        Name?: string;
    }
    namespace MeetingAgendaTypeRow {
        const idProperty = "AgendaTypeId";
        const nameProperty = "Name";
        const localTextPrefix = "Serenity.Pro.Meeting.MeetingAgendaType";
        const lookupKey = "Serenity.Pro.Meeting.MeetingAgendaType";
        function getLookup(): Q.Lookup<MeetingAgendaTypeRow>;
        const deletePermission = "Meeting:Management";
        const insertPermission = "Meeting:Management";
        const readPermission = "Meeting:General";
        const updatePermission = "Meeting:Management";
        const enum Fields {
            AgendaTypeId = "AgendaTypeId",
            Name = "Name"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    namespace MeetingAgendaTypeService {
        const baseUrl = "Meeting/MeetingAgendaType";
        function Create(request: SaveRequest<MeetingAgendaTypeRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<MeetingAgendaTypeRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MeetingAgendaTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<MeetingAgendaTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Meeting/MeetingAgendaType/Create",
            Update = "Meeting/MeetingAgendaType/Update",
            Delete = "Meeting/MeetingAgendaType/Delete",
            Retrieve = "Meeting/MeetingAgendaType/Retrieve",
            List = "Meeting/MeetingAgendaType/List"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    enum MeetingAttendanceStatus {
        NotSet = 0,
        Attended = 1,
        Absent = 2,
        AbsentWithPermission = 3
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAttendeeColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingAttendeeForm {
        MeetingId: IntegerEditor;
        ContactId: IntegerEditor;
        AttendeeType: EnumEditor;
        AttendanceStatus: EnumEditor;
    }
    class MeetingAttendeeForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingAttendeeRow {
        AttendeeId?: number;
        MeetingId?: number;
        ContactId?: number;
        AttendeeType?: MeetingAttendeeType;
        AttendanceStatus?: MeetingAttendanceStatus;
        MeetingMeetingName?: string;
        MeetingMeetingNumber?: string;
        MeetingMeetingGuid?: string;
        MeetingMeetingTypeId?: number;
        MeetingStartDate?: string;
        MeetingEndDate?: string;
        MeetingLocationId?: number;
        MeetingUnitId?: number;
        MeetingOrganizerContactId?: number;
        MeetingReporterContactId?: number;
        MeetingInsertUserId?: number;
        MeetingInsertDate?: string;
        MeetingUpdateUserId?: number;
        MeetingUpdateDate?: string;
        ContactTitle?: string;
        ContactFirstName?: string;
        ContactLastName?: string;
        ContactFullName?: string;
        ContactEmail?: string;
        ContactIdentityNo?: string;
        ContactUserId?: number;
    }
    namespace MeetingAttendeeRow {
        const idProperty = "AttendeeId";
        const localTextPrefix = "Serenity.Pro.Meeting.MeetingAttendee";
        const deletePermission = "Meeting:General";
        const insertPermission = "Meeting:General";
        const readPermission = "Meeting:General";
        const updatePermission = "Meeting:General";
        const enum Fields {
            AttendeeId = "AttendeeId",
            MeetingId = "MeetingId",
            ContactId = "ContactId",
            AttendeeType = "AttendeeType",
            AttendanceStatus = "AttendanceStatus",
            MeetingMeetingName = "MeetingMeetingName",
            MeetingMeetingNumber = "MeetingMeetingNumber",
            MeetingMeetingGuid = "MeetingMeetingGuid",
            MeetingMeetingTypeId = "MeetingMeetingTypeId",
            MeetingStartDate = "MeetingStartDate",
            MeetingEndDate = "MeetingEndDate",
            MeetingLocationId = "MeetingLocationId",
            MeetingUnitId = "MeetingUnitId",
            MeetingOrganizerContactId = "MeetingOrganizerContactId",
            MeetingReporterContactId = "MeetingReporterContactId",
            MeetingInsertUserId = "MeetingInsertUserId",
            MeetingInsertDate = "MeetingInsertDate",
            MeetingUpdateUserId = "MeetingUpdateUserId",
            MeetingUpdateDate = "MeetingUpdateDate",
            ContactTitle = "ContactTitle",
            ContactFirstName = "ContactFirstName",
            ContactLastName = "ContactLastName",
            ContactFullName = "ContactFullName",
            ContactEmail = "ContactEmail",
            ContactIdentityNo = "ContactIdentityNo",
            ContactUserId = "ContactUserId"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    enum MeetingAttendeeType {
        Attendee = 1,
        Guest = 2
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingDecisionColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingDecisionForm {
        Description: HtmlReportContentEditor;
        DueDate: DateEditor;
        ResponsibleContactId: LookupEditor;
        DecisionNumber: IntegerEditor;
        AgendaId: MeetingAgendaEditor;
        ResolutionStatus: EnumEditor;
        Images: MultipleImageUploadEditor;
        Attachments: MultipleImageUploadEditor;
    }
    class MeetingDecisionForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingDecisionRelevantColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingDecisionRelevantForm {
        DecisionId: IntegerEditor;
        ContactId: IntegerEditor;
    }
    class MeetingDecisionRelevantForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingDecisionRelevantRow {
        DecisionRelevantId?: number;
        DecisionId?: number;
        ContactId?: number;
        DecisionMeetingId?: number;
        DecisionAgendaId?: number;
        DecisionDescription?: string;
        DecisionDecisionNumber?: number;
        DecisionResponsibleContactId?: number;
        DecisionDueDate?: string;
        DecisionResolutionStatus?: number;
        DecisionImages?: string;
        DecisionAttachments?: string;
        ContactTitle?: string;
        ContactFirstName?: string;
        ContactLastName?: string;
        ContactEmail?: string;
        ContactIdentityNo?: string;
        ContactUserId?: number;
    }
    namespace MeetingDecisionRelevantRow {
        const idProperty = "DecisionRelevantId";
        const localTextPrefix = "Serenity.Pro.Meeting.MeetingDecisionRelevant";
        const deletePermission = "Meeting:General";
        const insertPermission = "Meeting:General";
        const readPermission = "Meeting:General";
        const updatePermission = "Meeting:General";
        const enum Fields {
            DecisionRelevantId = "DecisionRelevantId",
            DecisionId = "DecisionId",
            ContactId = "ContactId",
            DecisionMeetingId = "DecisionMeetingId",
            DecisionAgendaId = "DecisionAgendaId",
            DecisionDescription = "DecisionDescription",
            DecisionDecisionNumber = "DecisionDecisionNumber",
            DecisionResponsibleContactId = "DecisionResponsibleContactId",
            DecisionDueDate = "DecisionDueDate",
            DecisionResolutionStatus = "DecisionResolutionStatus",
            DecisionImages = "DecisionImages",
            DecisionAttachments = "DecisionAttachments",
            ContactTitle = "ContactTitle",
            ContactFirstName = "ContactFirstName",
            ContactLastName = "ContactLastName",
            ContactEmail = "ContactEmail",
            ContactIdentityNo = "ContactIdentityNo",
            ContactUserId = "ContactUserId"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    namespace MeetingDecisionRelevantService {
        const baseUrl = "Meeting/MeetingDecisionRelevant";
        function Create(request: SaveRequest<MeetingDecisionRelevantRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<MeetingDecisionRelevantRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MeetingDecisionRelevantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<MeetingDecisionRelevantRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Meeting/MeetingDecisionRelevant/Create",
            Update = "Meeting/MeetingDecisionRelevant/Update",
            Delete = "Meeting/MeetingDecisionRelevant/Delete",
            Retrieve = "Meeting/MeetingDecisionRelevant/Retrieve",
            List = "Meeting/MeetingDecisionRelevant/List"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingDecisionRow {
        DecisionId?: number;
        MeetingId?: number;
        AgendaId?: number;
        Description?: string;
        DecisionNumber?: number;
        ResponsibleContactId?: number;
        DueDate?: string;
        ResolutionStatus?: DecisionResolutionStatus;
        Images?: string;
        Attachments?: string;
        MeetingMeetingName?: string;
        MeetingMeetingNumber?: string;
        MeetingMeetingGuid?: string;
        MeetingMeetingTypeId?: number;
        MeetingStartDate?: string;
        MeetingEndDate?: string;
        MeetingLocationId?: number;
        MeetingUnitId?: number;
        MeetingOrganizerContactId?: number;
        MeetingReporterContactId?: number;
        MeetingInsertUserId?: number;
        MeetingInsertDate?: string;
        MeetingUpdateUserId?: number;
        MeetingUpdateDate?: string;
        AgendaMeetingId?: number;
        AgendaNumber?: number;
        AgendaTitle?: string;
        AgendaDescription?: string;
        AgendaTypeId?: number;
        AgendaRequestedByContactId?: number;
        AgendaImages?: string;
        AgendaAttachments?: string;
        ResponsibleContactTitle?: string;
        ResponsibleContactFirstName?: string;
        ResponsibleContactLastName?: string;
        ResponsibleContactFullName?: string;
        ResponsibleContactEmail?: string;
        ResponsibleContactIdentityNo?: string;
        ResponsibleContactUserId?: number;
    }
    namespace MeetingDecisionRow {
        const idProperty = "DecisionId";
        const nameProperty = "Description";
        const localTextPrefix = "Serenity.Pro.Meeting.MeetingDecision";
        const deletePermission = "Meeting:General";
        const insertPermission = "Meeting:General";
        const readPermission = "Meeting:General";
        const updatePermission = "Meeting:General";
        const enum Fields {
            DecisionId = "DecisionId",
            MeetingId = "MeetingId",
            AgendaId = "AgendaId",
            Description = "Description",
            DecisionNumber = "DecisionNumber",
            ResponsibleContactId = "ResponsibleContactId",
            DueDate = "DueDate",
            ResolutionStatus = "ResolutionStatus",
            Images = "Images",
            Attachments = "Attachments",
            MeetingMeetingName = "MeetingMeetingName",
            MeetingMeetingNumber = "MeetingMeetingNumber",
            MeetingMeetingGuid = "MeetingMeetingGuid",
            MeetingMeetingTypeId = "MeetingMeetingTypeId",
            MeetingStartDate = "MeetingStartDate",
            MeetingEndDate = "MeetingEndDate",
            MeetingLocationId = "MeetingLocationId",
            MeetingUnitId = "MeetingUnitId",
            MeetingOrganizerContactId = "MeetingOrganizerContactId",
            MeetingReporterContactId = "MeetingReporterContactId",
            MeetingInsertUserId = "MeetingInsertUserId",
            MeetingInsertDate = "MeetingInsertDate",
            MeetingUpdateUserId = "MeetingUpdateUserId",
            MeetingUpdateDate = "MeetingUpdateDate",
            AgendaMeetingId = "AgendaMeetingId",
            AgendaNumber = "AgendaNumber",
            AgendaTitle = "AgendaTitle",
            AgendaDescription = "AgendaDescription",
            AgendaTypeId = "AgendaTypeId",
            AgendaRequestedByContactId = "AgendaRequestedByContactId",
            AgendaImages = "AgendaImages",
            AgendaAttachments = "AgendaAttachments",
            ResponsibleContactTitle = "ResponsibleContactTitle",
            ResponsibleContactFirstName = "ResponsibleContactFirstName",
            ResponsibleContactLastName = "ResponsibleContactLastName",
            ResponsibleContactFullName = "ResponsibleContactFullName",
            ResponsibleContactEmail = "ResponsibleContactEmail",
            ResponsibleContactIdentityNo = "ResponsibleContactIdentityNo",
            ResponsibleContactUserId = "ResponsibleContactUserId"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    namespace MeetingDecisionService {
        const baseUrl = "Meeting/MeetingDecision";
        function Create(request: SaveRequest<MeetingDecisionRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<MeetingDecisionRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MeetingDecisionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<MeetingDecisionRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Meeting/MeetingDecision/Create",
            Update = "Meeting/MeetingDecision/Update",
            Delete = "Meeting/MeetingDecision/Delete",
            Retrieve = "Meeting/MeetingDecision/Retrieve",
            List = "Meeting/MeetingDecision/List"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingForm {
        MeetingName: StringEditor;
        MeetingTypeId: LookupEditor;
        MeetingNumber: StringEditor;
        StartDate: DateTimeEditor;
        EndDate: DateTimeEditor;
        LocationId: LookupEditor;
        UnitId: Pro.Organization.BusinessUnitEditor;
        OrganizerContactId: LookupEditor;
        ReporterContactId: LookupEditor;
        AttendeeList: MeetingAttendeeEditor;
    }
    class MeetingForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingLocationColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingLocationForm {
        Name: StringEditor;
        Address: StringEditor;
        Latitude: DecimalEditor;
        Longitude: DecimalEditor;
    }
    class MeetingLocationForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingLocationRow {
        LocationId?: number;
        Name?: string;
        Address?: string;
        Latitude?: number;
        Longitude?: number;
    }
    namespace MeetingLocationRow {
        const idProperty = "LocationId";
        const nameProperty = "Name";
        const localTextPrefix = "Serenity.Pro.Meeting.MeetingLocation";
        const lookupKey = "Serenity.Pro.Meeting.MeetingLocation";
        function getLookup(): Q.Lookup<MeetingLocationRow>;
        const deletePermission = "Meeting:Management";
        const insertPermission = "Meeting:Management";
        const readPermission = "Meeting:General";
        const updatePermission = "Meeting:Management";
        const enum Fields {
            LocationId = "LocationId",
            Name = "Name",
            Address = "Address",
            Latitude = "Latitude",
            Longitude = "Longitude"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    namespace MeetingLocationService {
        const baseUrl = "Meeting/MeetingLocation";
        function Create(request: SaveRequest<MeetingLocationRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<MeetingLocationRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MeetingLocationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<MeetingLocationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Meeting/MeetingLocation/Create",
            Update = "Meeting/MeetingLocation/Update",
            Delete = "Meeting/MeetingLocation/Delete",
            Retrieve = "Meeting/MeetingLocation/Retrieve",
            List = "Meeting/MeetingLocation/List"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingRow {
        MeetingId?: number;
        MeetingName?: string;
        MeetingNumber?: string;
        MeetingGuid?: string;
        MeetingTypeId?: number;
        StartDate?: string;
        EndDate?: string;
        LocationId?: number;
        LocationName?: string;
        UnitId?: number;
        OrganizerContactId?: number;
        OrganizerContactFullName?: string;
        ReporterContactId?: number;
        ReporterContactFullName?: string;
        MeetingTypeName?: string;
        UnitName?: string;
        UnitParentUnitId?: number;
        OrganizerContactTitle?: string;
        OrganizerContactFirstName?: string;
        OrganizerContactLastName?: string;
        OrganizerContactEmail?: string;
        OrganizerContactIdentityNo?: string;
        OrganizerContactUserId?: number;
        ReporterContactTitle?: string;
        ReporterContactFirstName?: string;
        ReporterContactLastName?: string;
        ReporterContactEmail?: string;
        ReporterContactIdentityNo?: string;
        ReporterContactUserId?: number;
        AttendeeList?: MeetingAttendeeRow[];
        InsertUserId?: number;
        InsertDate?: string;
        UpdateUserId?: number;
        UpdateDate?: string;
    }
    namespace MeetingRow {
        const idProperty = "MeetingId";
        const nameProperty = "MeetingName";
        const localTextPrefix = "Serenity.Pro.Meeting.Meeting";
        const deletePermission = "Meeting:General";
        const insertPermission = "Meeting:General";
        const readPermission = "Meeting:General";
        const updatePermission = "Meeting:General";
        const enum Fields {
            MeetingId = "MeetingId",
            MeetingName = "MeetingName",
            MeetingNumber = "MeetingNumber",
            MeetingGuid = "MeetingGuid",
            MeetingTypeId = "MeetingTypeId",
            StartDate = "StartDate",
            EndDate = "EndDate",
            LocationId = "LocationId",
            LocationName = "LocationName",
            UnitId = "UnitId",
            OrganizerContactId = "OrganizerContactId",
            OrganizerContactFullName = "OrganizerContactFullName",
            ReporterContactId = "ReporterContactId",
            ReporterContactFullName = "ReporterContactFullName",
            MeetingTypeName = "MeetingTypeName",
            UnitName = "UnitName",
            UnitParentUnitId = "UnitParentUnitId",
            OrganizerContactTitle = "OrganizerContactTitle",
            OrganizerContactFirstName = "OrganizerContactFirstName",
            OrganizerContactLastName = "OrganizerContactLastName",
            OrganizerContactEmail = "OrganizerContactEmail",
            OrganizerContactIdentityNo = "OrganizerContactIdentityNo",
            OrganizerContactUserId = "OrganizerContactUserId",
            ReporterContactTitle = "ReporterContactTitle",
            ReporterContactFirstName = "ReporterContactFirstName",
            ReporterContactLastName = "ReporterContactLastName",
            ReporterContactEmail = "ReporterContactEmail",
            ReporterContactIdentityNo = "ReporterContactIdentityNo",
            ReporterContactUserId = "ReporterContactUserId",
            AttendeeList = "AttendeeList",
            InsertUserId = "InsertUserId",
            InsertDate = "InsertDate",
            UpdateUserId = "UpdateUserId",
            UpdateDate = "UpdateDate"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    namespace MeetingService {
        const baseUrl = "Meeting/Meeting";
        function Create(request: SaveRequest<MeetingRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<MeetingRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MeetingRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<MeetingRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Meeting/Meeting/Create",
            Update = "Meeting/Meeting/Update",
            Delete = "Meeting/Meeting/Delete",
            Retrieve = "Meeting/Meeting/Retrieve",
            List = "Meeting/Meeting/List"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingTypeColumns {
        static columnsKey: string;
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingTypeForm {
        Name: StringEditor;
    }
    class MeetingTypeForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.Meeting {
    interface MeetingTypeRow {
        MeetingTypeId?: number;
        Name?: string;
    }
    namespace MeetingTypeRow {
        const idProperty = "MeetingTypeId";
        const nameProperty = "Name";
        const localTextPrefix = "Serenity.Pro.Meeting.MeetingType";
        const lookupKey = "Serenity.Pro.Meeting.MeetingType";
        function getLookup(): Q.Lookup<MeetingTypeRow>;
        const deletePermission = "Meeting:Management";
        const insertPermission = "Meeting:Management";
        const readPermission = "Meeting:General";
        const updatePermission = "Meeting:Management";
        const enum Fields {
            MeetingTypeId = "MeetingTypeId",
            Name = "Name"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    namespace MeetingTypeService {
        const baseUrl = "Meeting/MeetingType";
        function Create(request: SaveRequest<MeetingTypeRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Update(request: SaveRequest<MeetingTypeRow>, onSuccess?: (response: SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<MeetingTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function List(request: ListRequest, onSuccess?: (response: ListResponse<MeetingTypeRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Create = "Meeting/MeetingType/Create",
            Update = "Meeting/MeetingType/Update",
            Delete = "Meeting/MeetingType/Delete",
            Retrieve = "Meeting/MeetingType/Retrieve",
            List = "Meeting/MeetingType/List"
        }
    }
}
declare namespace Serenity.Pro.Meeting {
    namespace PermissionKeys {
        const General = "Meeting:General";
        const Management = "Meeting:Management";
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingDialog extends Serenity.EntityDialog<MeetingRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingForm;
        private agendaGrid;
        private decisionGrid;
        constructor();
        protected arrange(): void;
        loadEntity(entity: MeetingRow): void;
        getTemplate(): string;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingGrid extends Serenity.EntityGrid<MeetingRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaDialog extends Serenity.EntityDialog<MeetingAgendaRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingAgendaForm;
        protected getSaveEntity(): MeetingAgendaRow;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaEditor extends Serenity.Select2Editor<any, MeetingAgendaRow> {
        constructor(hidden: JQuery);
        private _meetingId;
        get meetingId(): number;
        set meetingId(value: number);
        protected updateItems(): void;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaGrid extends Serenity.EntityGrid<MeetingAgendaRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingAgendaDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected addButtonClick(): void;
        protected getInitialTitle(): any;
        protected getGridCanLoad(): boolean;
        private _meetingId;
        get meetingId(): number;
        set meetingId(value: number);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaRelevantDialog extends Serenity.EntityDialog<MeetingAgendaRelevantRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: MeetingAgendaRelevantForm;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaRelevantGrid extends Serenity.EntityGrid<MeetingAgendaRelevantRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingAgendaRelevantDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaTypeDialog extends Serenity.EntityDialog<MeetingAgendaTypeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingAgendaTypeForm;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAgendaTypeGrid extends Serenity.EntityGrid<MeetingAgendaTypeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingAgendaTypeDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAttendeeDialog extends Serenity.Extensions.GridEditorDialog<MeetingAttendeeRow> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected form: MeetingAttendeeForm;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingAttendeeEditor extends Serenity.Extensions.GridEditorBase<MeetingAttendeeRow> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingAttendeeDialog;
        protected getLocalTextPrefix(): string;
        constructor(container: JQuery);
        protected getButtons(): any[];
        protected createToolbarExtensions(): void;
        protected getColumns(): Slick.Column<any>[];
        protected onClick(e: JQueryEventObject, row: number, cell: number): void;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingDecisionDialog extends Serenity.EntityDialog<MeetingDecisionRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): MeetingDecisionRow.Fields;
        protected getService(): string;
        protected form: MeetingDecisionForm;
        protected loadEntity(entity: MeetingDecisionRow): void;
        protected getSaveEntity(): MeetingDecisionRow;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingDecisionGrid extends Serenity.EntityGrid<MeetingDecisionRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingDecisionDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
        protected addButtonClick(): void;
        protected getInitialTitle(): any;
        protected getGridCanLoad(): boolean;
        private _meetingId;
        get meetingId(): number;
        set meetingId(value: number);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingDecisionRelevantDialog extends Serenity.EntityDialog<MeetingDecisionRelevantRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        protected form: MeetingDecisionRelevantForm;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingDecisionRelevantGrid extends Serenity.EntityGrid<MeetingDecisionRelevantRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingDecisionRelevantDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingLocationDialog extends Serenity.EntityDialog<MeetingLocationRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingLocationForm;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingLocationGrid extends Serenity.EntityGrid<MeetingLocationRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingLocationDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingTypeDialog extends Serenity.EntityDialog<MeetingTypeRow, any> {
        protected getFormKey(): string;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getNameProperty(): string;
        protected getService(): string;
        protected form: MeetingTypeForm;
    }
}
declare namespace Serenity.Pro.Meeting {
    class MeetingTypeGrid extends Serenity.EntityGrid<MeetingTypeRow, any> {
        protected getColumnsKey(): string;
        protected getDialogType(): typeof MeetingTypeDialog;
        protected getIdProperty(): string;
        protected getLocalTextPrefix(): string;
        protected getService(): string;
        constructor(container: JQuery);
    }
}
