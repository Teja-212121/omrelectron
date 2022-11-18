namespace Rio.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleKey: string;
                export const RoleName: string;
                export const TenantId: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RolePermissionId: string;
                export const RoleRoleName: string;
            }

            namespace Tenant {
                export const TenantId: string;
                export const TenantName: string;
            }

            namespace Translation {
                export const CustomText: string;
                export const EntityPlural: string;
                export const Key: string;
                export const OverrideConfirmation: string;
                export const SaveChangesButton: string;
                export const SourceLanguage: string;
                export const SourceText: string;
                export const TargetLanguage: string;
                export const TargetText: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const ImpersonationToken: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const MobilePhoneNumber: string;
                export const MobilePhoneVerified: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const TenantId: string;
                export const TenantName: string;
                export const TwoFactorAuth: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Workspace {

            namespace Exam {
                export const Code: string;
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const NegativeMarks: string;
                export const OptionsAvailable: string;
                export const ResultCriteria: string;
                export const TenantId: string;
                export const TotalMarks: string;
                export const TotalQuestions: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ExamGroupWiseResult {
                export const ExamCode: string;
                export const ExamDescription: string;
                export const ExamId: string;
                export const ExamInsertDate: string;
                export const ExamInsertUserId: string;
                export const ExamIsActive: string;
                export const ExamName: string;
                export const ExamNegativeMarks: string;
                export const ExamOptionsAvailable: string;
                export const ExamResultCriteria: string;
                export const ExamTenantId: string;
                export const ExamTotalMarks: string;
                export const ExamUpdateDate: string;
                export const ExamUpdateUserId: string;
                export const GroupDescription: string;
                export const GroupId: string;
                export const GroupInsertDate: string;
                export const GroupInsertUserId: string;
                export const GroupIsActive: string;
                export const GroupName: string;
                export const GroupParentId: string;
                export const GroupTenantId: string;
                export const GroupUpdateDate: string;
                export const GroupUpdateUserId: string;
                export const Id: string;
                export const Rank: string;
                export const RollNumber: string;
                export const SheetGuid: string;
                export const SheetNumber: string;
                export const StudentDob: string;
                export const StudentEmail: string;
                export const StudentFirstName: string;
                export const StudentFullName: string;
                export const StudentGender: string;
                export const StudentId: string;
                export const StudentInsertDate: string;
                export const StudentInsertUserId: string;
                export const StudentIsActive: string;
                export const StudentLastName: string;
                export const StudentMiddleName: string;
                export const StudentMobile: string;
                export const StudentNote: string;
                export const StudentRollNo: string;
                export const StudentTenantId: string;
                export const StudentUpdateDate: string;
                export const StudentUpdateUserId: string;
                export const TenantId: string;
            }

            namespace ExamQuestion {
                export const ExamCode: string;
                export const ExamDescription: string;
                export const ExamId: string;
                export const ExamInsertDate: string;
                export const ExamInsertUserId: string;
                export const ExamIsActive: string;
                export const ExamName: string;
                export const ExamNegativeMarks: string;
                export const ExamOptionsAvailable: string;
                export const ExamResultCriteria: string;
                export const ExamSectionDescription: string;
                export const ExamSectionExamId: string;
                export const ExamSectionId: string;
                export const ExamSectionInsertDate: string;
                export const ExamSectionInsertUserId: string;
                export const ExamSectionIsActive: string;
                export const ExamSectionName: string;
                export const ExamSectionParentId: string;
                export const ExamSectionTenantId: string;
                export const ExamSectionUpdateDate: string;
                export const ExamSectionUpdateUserId: string;
                export const ExamTenantId: string;
                export const ExamTotalMarks: string;
                export const ExamUpdateDate: string;
                export const ExamUpdateUserId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const QuestionIndex: string;
                export const RightOptions: string;
                export const RowIds: string;
                export const RuleTypeDescription: string;
                export const RuleTypeId: string;
                export const RuleTypeName: string;
                export const Score: string;
                export const Tags: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ExamQuestionResult {
                export const ExamCode: string;
                export const ExamDescription: string;
                export const ExamId: string;
                export const ExamInsertDate: string;
                export const ExamInsertUserId: string;
                export const ExamIsActive: string;
                export const ExamName: string;
                export const ExamNegativeMarks: string;
                export const ExamOptionsAvailable: string;
                export const ExamResultCriteria: string;
                export const ExamTenantId: string;
                export const ExamTotalMarks: string;
                export const ExamUpdateDate: string;
                export const ExamUpdateUserId: string;
                export const Id: string;
                export const IsAttempted: string;
                export const IsCorrect: string;
                export const ObtainedMarks: string;
                export const QuestionIndex: string;
                export const RollNumber: string;
                export const SheetGuid: string;
                export const SheetNumber: string;
                export const StudentDob: string;
                export const StudentEmail: string;
                export const StudentFirstName: string;
                export const StudentFullName: string;
                export const StudentGender: string;
                export const StudentId: string;
                export const StudentInsertDate: string;
                export const StudentInsertUserId: string;
                export const StudentIsActive: string;
                export const StudentLastName: string;
                export const StudentMiddleName: string;
                export const StudentMobile: string;
                export const StudentNote: string;
                export const StudentRollNo: string;
                export const StudentTenantId: string;
                export const StudentUpdateDate: string;
                export const StudentUpdateUserId: string;
                export const TenantId: string;
            }

            namespace ExamRankWiseResult {
                export const ExamCode: string;
                export const ExamDescription: string;
                export const ExamId: string;
                export const ExamInsertDate: string;
                export const ExamInsertUserId: string;
                export const ExamIsActive: string;
                export const ExamName: string;
                export const ExamNegativeMarks: string;
                export const ExamOptionsAvailable: string;
                export const ExamResultCriteria: string;
                export const ExamTenantId: string;
                export const ExamTotalMarks: string;
                export const ExamUpdateDate: string;
                export const ExamUpdateUserId: string;
                export const Id: string;
                export const Rank: string;
                export const RollNumber: string;
                export const SheetGuid: string;
                export const SheetNumber: string;
                export const StudentDob: string;
                export const StudentEmail: string;
                export const StudentFirstName: string;
                export const StudentFullName: string;
                export const StudentGender: string;
                export const StudentId: string;
                export const StudentInsertDate: string;
                export const StudentInsertUserId: string;
                export const StudentIsActive: string;
                export const StudentLastName: string;
                export const StudentMiddleName: string;
                export const StudentMobile: string;
                export const StudentNote: string;
                export const StudentRollNo: string;
                export const StudentTenantId: string;
                export const StudentUpdateDate: string;
                export const StudentUpdateUserId: string;
                export const TenantId: string;
            }

            namespace ExamResult {
                export const ExamCode: string;
                export const ExamDescription: string;
                export const ExamId: string;
                export const ExamInsertDate: string;
                export const ExamInsertUserId: string;
                export const ExamIsActive: string;
                export const ExamName: string;
                export const ExamNegativeMarks: string;
                export const ExamOptionsAvailable: string;
                export const ExamResultCriteria: string;
                export const ExamTenantId: string;
                export const ExamTotalMarks: string;
                export const ExamUpdateDate: string;
                export const ExamUpdateUserId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ObtainedMarks: string;
                export const Percentage: string;
                export const RollNumber: string;
                export const SheetGuid: string;
                export const SheetNumber: string;
                export const StudentDob: string;
                export const StudentEmail: string;
                export const StudentFirstName: string;
                export const StudentFullName: string;
                export const StudentGender: string;
                export const StudentId: string;
                export const StudentInsertDate: string;
                export const StudentInsertUserId: string;
                export const StudentIsActive: string;
                export const StudentLastName: string;
                export const StudentMiddleName: string;
                export const StudentMobile: string;
                export const StudentNote: string;
                export const StudentRollNo: string;
                export const StudentTenantId: string;
                export const StudentUpdateDate: string;
                export const StudentUpdateUserId: string;
                export const TenantId: string;
                export const TotalAttempted: string;
                export const TotalMarks: string;
                export const TotalNotAttempted: string;
                export const TotalQuestions: string;
                export const TotalRightAnswers: string;
                export const TotalWrongAnswers: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ExamSection {
                export const Description: string;
                export const ExamCode: string;
                export const ExamDescription: string;
                export const ExamId: string;
                export const ExamInsertDate: string;
                export const ExamInsertUserId: string;
                export const ExamIsActive: string;
                export const ExamName: string;
                export const ExamNegativeMarks: string;
                export const ExamOptionsAvailable: string;
                export const ExamResultCriteria: string;
                export const ExamTenantId: string;
                export const ExamTotalMarks: string;
                export const ExamUpdateDate: string;
                export const ExamUpdateUserId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const ParentDescription: string;
                export const ParentExamId: string;
                export const ParentId: string;
                export const ParentInsertDate: string;
                export const ParentInsertUserId: string;
                export const ParentIsActive: string;
                export const ParentName: string;
                export const ParentParentId: string;
                export const ParentTenantId: string;
                export const ParentUpdateDate: string;
                export const ParentUpdateUserId: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ExamSectionResult {
                export const ExamCode: string;
                export const ExamDescription: string;
                export const ExamId: string;
                export const ExamInsertDate: string;
                export const ExamInsertUserId: string;
                export const ExamIsActive: string;
                export const ExamName: string;
                export const ExamNegativeMarks: string;
                export const ExamOptionsAvailable: string;
                export const ExamResultCriteria: string;
                export const ExamSectionDescription: string;
                export const ExamSectionExamId: string;
                export const ExamSectionId: string;
                export const ExamSectionInsertDate: string;
                export const ExamSectionInsertUserId: string;
                export const ExamSectionIsActive: string;
                export const ExamSectionName: string;
                export const ExamSectionParentId: string;
                export const ExamSectionTenantId: string;
                export const ExamSectionUpdateDate: string;
                export const ExamSectionUpdateUserId: string;
                export const ExamTenantId: string;
                export const ExamTotalMarks: string;
                export const ExamUpdateDate: string;
                export const ExamUpdateUserId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ObtainedMarks: string;
                export const Percentage: string;
                export const RollNumber: string;
                export const SheetGuid: string;
                export const SheetNumber: string;
                export const StudentDob: string;
                export const StudentEmail: string;
                export const StudentFirstName: string;
                export const StudentFullName: string;
                export const StudentGender: string;
                export const StudentId: string;
                export const StudentInsertDate: string;
                export const StudentInsertUserId: string;
                export const StudentIsActive: string;
                export const StudentLastName: string;
                export const StudentMiddleName: string;
                export const StudentMobile: string;
                export const StudentNote: string;
                export const StudentRollNo: string;
                export const StudentTenantId: string;
                export const StudentUpdateDate: string;
                export const StudentUpdateUserId: string;
                export const TenantId: string;
                export const TotalAttempted: string;
                export const TotalMarks: string;
                export const TotalNotAttempted: string;
                export const TotalQuestions: string;
                export const TotalRightAnswers: string;
                export const TotalWrongAnswers: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Group {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const ParentDescription: string;
                export const ParentId: string;
                export const ParentInsertDate: string;
                export const ParentInsertUserId: string;
                export const ParentIsActive: string;
                export const ParentName: string;
                export const ParentParentId: string;
                export const ParentTenantId: string;
                export const ParentUpdateDate: string;
                export const ParentUpdateUserId: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace GroupStudent {
                export const GroupDescription: string;
                export const GroupId: string;
                export const GroupInsertDate: string;
                export const GroupInsertUserId: string;
                export const GroupIsActive: string;
                export const GroupName: string;
                export const GroupParentId: string;
                export const GroupTenantId: string;
                export const GroupUpdateDate: string;
                export const GroupUpdateUserId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const RowIds: string;
                export const StudentDob: string;
                export const StudentEmail: string;
                export const StudentFirstName: string;
                export const StudentFullName: string;
                export const StudentGender: string;
                export const StudentId: string;
                export const StudentInsertDate: string;
                export const StudentInsertUserId: string;
                export const StudentIsActive: string;
                export const StudentLastName: string;
                export const StudentMiddleName: string;
                export const StudentMobile: string;
                export const StudentNote: string;
                export const StudentRollNo: string;
                export const StudentTenantId: string;
                export const StudentUpdateDate: string;
                export const StudentUpdateUserId: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ImportedScannedBatch {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ImportedScannedQuestion {
                export const CorrectedOptions: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const QuestionIndex: string;
                export const ScannedOptions: string;
                export const ScannedSheetCorrectedExamNo: string;
                export const ScannedSheetCorrectedRollNo: string;
                export const ScannedSheetExamSetNo: string;
                export const ScannedSheetId: string;
                export const ScannedSheetInsertDate: string;
                export const ScannedSheetInsertUserId: string;
                export const ScannedSheetIsActive: string;
                export const ScannedSheetResultProcessed: string;
                export const ScannedSheetScannedAt: string;
                export const ScannedSheetScannedBatchId: string;
                export const ScannedSheetScannedComments: string;
                export const ScannedSheetScannedExamNo: string;
                export const ScannedSheetScannedImage: string;
                export const ScannedSheetScannedImageSourcePath: string;
                export const ScannedSheetScannedRollNo: string;
                export const ScannedSheetScannedStatus: string;
                export const ScannedSheetScannedSystemErrors: string;
                export const ScannedSheetScannedUserErrors: string;
                export const ScannedSheetSheetNumber: string;
                export const ScannedSheetSheetTypeId: string;
                export const ScannedSheetTenantId: string;
                export const ScannedSheetUpdateDate: string;
                export const ScannedSheetUpdateUserId: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ImportedScannedSheet {
                export const CorrectedExamNo: string;
                export const CorrectedRollNo: string;
                export const ExamSetNo: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ResultProcessed: string;
                export const ScannedAt: string;
                export const ScannedBatchDescription: string;
                export const ScannedBatchId: string;
                export const ScannedBatchInsertDate: string;
                export const ScannedBatchInsertUserId: string;
                export const ScannedBatchIsActive: string;
                export const ScannedBatchName: string;
                export const ScannedBatchTenantId: string;
                export const ScannedBatchUpdateDate: string;
                export const ScannedBatchUpdateUserId: string;
                export const ScannedComments: string;
                export const ScannedExamNo: string;
                export const ScannedImage: string;
                export const ScannedImageSourcePath: string;
                export const ScannedRollNo: string;
                export const ScannedStatus: string;
                export const ScannedSystemErrors: string;
                export const ScannedUserErrors: string;
                export const SheetNumber: string;
                export const SheetTypeDescription: string;
                export const SheetTypeEPaperSize: string;
                export const SheetTypeHeightInPixel: string;
                export const SheetTypeId: string;
                export const SheetTypeInsertDate: string;
                export const SheetTypeInsertUserId: string;
                export const SheetTypeIsActive: string;
                export const SheetTypeIsPrivate: string;
                export const SheetTypeName: string;
                export const SheetTypeOverlayImage: string;
                export const SheetTypePdfTemplate: string;
                export const SheetTypeSheetData: string;
                export const SheetTypeSheetImage: string;
                export const SheetTypeSheetNumber: string;
                export const SheetTypeSynced: string;
                export const SheetTypeTotalQuestions: string;
                export const SheetTypeUpdateDate: string;
                export const SheetTypeUpdateUserId: string;
                export const SheetTypeWidthInPixel: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace RuleType {
                export const Description: string;
                export const Id: string;
                export const Name: string;
            }

            namespace ScannedBatch {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ScannedQuestion {
                export const CorrectedOptions: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const QuestionIndex: string;
                export const ScannedOptions: string;
                export const ScannedSheetCorrectedExamNo: string;
                export const ScannedSheetCorrectedRollNo: string;
                export const ScannedSheetExamSetNo: string;
                export const ScannedSheetId: string;
                export const ScannedSheetInsertDate: string;
                export const ScannedSheetInsertUserId: string;
                export const ScannedSheetIsActive: string;
                export const ScannedSheetResultProcessed: string;
                export const ScannedSheetScannedAt: string;
                export const ScannedSheetScannedBatchId: string;
                export const ScannedSheetScannedComments: string;
                export const ScannedSheetScannedExamNo: string;
                export const ScannedSheetScannedImage: string;
                export const ScannedSheetScannedImageSourcePath: string;
                export const ScannedSheetScannedRollNo: string;
                export const ScannedSheetScannedStatus: string;
                export const ScannedSheetScannedSystemErrors: string;
                export const ScannedSheetScannedUserErrors: string;
                export const ScannedSheetSheetNumber: string;
                export const ScannedSheetSheetTypeId: string;
                export const ScannedSheetTenantId: string;
                export const ScannedSheetUpdateDate: string;
                export const ScannedSheetUpdateUserId: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ScannedSheet {
                export const CorrectedExamNo: string;
                export const CorrectedRollNo: string;
                export const ExamSetNo: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ResultProcessed: string;
                export const ScannedAt: string;
                export const ScannedBatchDescription: string;
                export const ScannedBatchId: string;
                export const ScannedBatchInsertDate: string;
                export const ScannedBatchInsertUserId: string;
                export const ScannedBatchIsActive: string;
                export const ScannedBatchName: string;
                export const ScannedBatchTenantId: string;
                export const ScannedBatchUpdateDate: string;
                export const ScannedBatchUpdateUserId: string;
                export const ScannedComments: string;
                export const ScannedExamNo: string;
                export const ScannedImage: string;
                export const ScannedImageSourcePath: string;
                export const ScannedRollNo: string;
                export const ScannedStatus: string;
                export const ScannedSystemErrors: string;
                export const ScannedUserErrors: string;
                export const SheetNumber: string;
                export const SheetTypeDescription: string;
                export const SheetTypeEPaperSize: string;
                export const SheetTypeHeightInPixel: string;
                export const SheetTypeId: string;
                export const SheetTypeInsertDate: string;
                export const SheetTypeInsertUserId: string;
                export const SheetTypeIsActive: string;
                export const SheetTypeIsPrivate: string;
                export const SheetTypeName: string;
                export const SheetTypeOverlayImage: string;
                export const SheetTypePdfTemplate: string;
                export const SheetTypeSheetData: string;
                export const SheetTypeSheetImage: string;
                export const SheetTypeSheetNumber: string;
                export const SheetTypeSynced: string;
                export const SheetTypeTotalQuestions: string;
                export const SheetTypeUpdateDate: string;
                export const SheetTypeUpdateUserId: string;
                export const SheetTypeWidthInPixel: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace SelectSheetType {
                export const Description: string;
                export const EPaperSize: string;
                export const HeightInPixel: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsPrivate: string;
                export const Name: string;
                export const OverlayImage: string;
                export const PdfTemplate: string;
                export const SheetData: string;
                export const SheetImage: string;
                export const SheetNumber: string;
                export const Synced: string;
                export const TotalQuestions: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const WidthInPixel: string;
            }

            namespace SheetType {
                export const Description: string;
                export const EPaperSize: string;
                export const HeightInPixel: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsPrivate: string;
                export const Name: string;
                export const OverlayImage: string;
                export const PdfTemplate: string;
                export const SheetData: string;
                export const SheetImage: string;
                export const SheetNumber: string;
                export const Synced: string;
                export const TotalQuestions: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const WidthInPixel: string;
            }

            namespace SheetTypeTenant {
                export const DisplayOrder: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsDefault: string;
                export const RowIds: string;
                export const SheetDesignPdf: string;
                export const SheetTypeDescription: string;
                export const SheetTypeEPaperSize: string;
                export const SheetTypeHeightInPixel: string;
                export const SheetTypeId: string;
                export const SheetTypeInsertDate: string;
                export const SheetTypeInsertUserId: string;
                export const SheetTypeIsActive: string;
                export const SheetTypeIsPrivate: string;
                export const SheetTypeName: string;
                export const SheetTypeOverlayImage: string;
                export const SheetTypePdfTemplate: string;
                export const SheetTypeSheetData: string;
                export const SheetTypeSheetImage: string;
                export const SheetTypeSheetNumber: string;
                export const SheetTypeSynced: string;
                export const SheetTypeTotalQuestions: string;
                export const SheetTypeUpdateDate: string;
                export const SheetTypeUpdateUserId: string;
                export const SheetTypeWidthInPixel: string;
                export const TenantId: string;
                export const TenantTenantName: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Student {
                export const Dob: string;
                export const Email: string;
                export const FirstName: string;
                export const FullName: string;
                export const Gender: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastName: string;
                export const MiddleName: string;
                export const Mobile: string;
                export const Note: string;
                export const RollNo: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace ChangePassword {
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace ForgotPassword {
                export const BackToLogin: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace Login {
                export const FacebookButton: string;
                export const ForgotPassword: string;
                export const GoogleButton: string;
                export const LoginToYourAccount: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace ResetPassword {
                export const BackToLogin: string;
                export const EmailSubject: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const AcceptTerms: string;
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const BackToLogin: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
    }

    export declare namespace Navigation {
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace BasicProgressDialog {
            export const CancelTitle: string;
            export const PleaseWait: string;
        }

        namespace BulkServiceAction {
            export const AllHadErrorsFormat: string;
            export const AllSuccessFormat: string;
            export const ConfirmationFormat: string;
            export const ErrorCount: string;
            export const NothingToProcess: string;
            export const SomeHadErrorsFormat: string;
            export const SuccessCount: string;
        }

        namespace Dashboard {
            export const ContentDescription: string;
        }

        namespace Dialogs {
            export const PendingChangesConfirmation: string;
        }

        namespace Layout {
            export const FooterCopyright: string;
            export const FooterInfo: string;
            export const FooterRights: string;
            export const GeneralSettings: string;
            export const Language: string;
            export const Theme: string;
            export const ThemeAzure: string;
            export const ThemeAzureLight: string;
            export const ThemeBlack: string;
            export const ThemeBlackLight: string;
            export const ThemeBlue: string;
            export const ThemeBlueLight: string;
            export const ThemeCosmos: string;
            export const ThemeCosmosLight: string;
            export const ThemeGlassy: string;
            export const ThemeGlassyLight: string;
            export const ThemeGreen: string;
            export const ThemeGreenLight: string;
            export const ThemePurple: string;
            export const ThemePurpleLight: string;
            export const ThemeRed: string;
            export const ThemeRedLight: string;
            export const ThemeYellow: string;
            export const ThemeYellowLight: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace UserRoleDialog {
            export const DialogTitle: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CantFindUserWithEmail: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const SavePrimaryKeyError: string;
    }

    Rio['Texts'] = Q.proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleKey:1,RoleName:1,TenantId:1},RolePermission:{PermissionKey:1,RoleId:1,RolePermissionId:1,RoleRoleName:1},Tenant:{TenantId:1,TenantName:1},Translation:{CustomText:1,EntityPlural:1,Key:1,OverrideConfirmation:1,SaveChangesButton:1,SourceLanguage:1,SourceText:1,TargetLanguage:1,TargetText:1},User:{DisplayName:1,Email:1,ImpersonationToken:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,MobilePhoneNumber:1,MobilePhoneVerified:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Roles:1,Source:1,TenantId:1,TenantName:1,TwoFactorAuth:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Workspace:{Exam:{Code:1,Description:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,NegativeMarks:1,OptionsAvailable:1,ResultCriteria:1,TenantId:1,TotalMarks:1,TotalQuestions:1,UpdateDate:1,UpdateUserId:1},ExamGroupWiseResult:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,GroupDescription:1,GroupId:1,GroupInsertDate:1,GroupInsertUserId:1,GroupIsActive:1,GroupName:1,GroupParentId:1,GroupTenantId:1,GroupUpdateDate:1,GroupUpdateUserId:1,Id:1,Rank:1,RollNumber:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1},ExamQuestion:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamSectionDescription:1,ExamSectionExamId:1,ExamSectionId:1,ExamSectionInsertDate:1,ExamSectionInsertUserId:1,ExamSectionIsActive:1,ExamSectionName:1,ExamSectionParentId:1,ExamSectionTenantId:1,ExamSectionUpdateDate:1,ExamSectionUpdateUserId:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,QuestionIndex:1,RightOptions:1,RowIds:1,RuleTypeDescription:1,RuleTypeId:1,RuleTypeName:1,Score:1,Tags:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ExamQuestionResult:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,IsAttempted:1,IsCorrect:1,ObtainedMarks:1,QuestionIndex:1,RollNumber:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1},ExamRankWiseResult:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,Rank:1,RollNumber:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1},ExamResult:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,ObtainedMarks:1,Percentage:1,RollNumber:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1,TotalAttempted:1,TotalMarks:1,TotalNotAttempted:1,TotalQuestions:1,TotalRightAnswers:1,TotalWrongAnswers:1,UpdateDate:1,UpdateUserId:1},ExamSection:{Description:1,ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,ParentDescription:1,ParentExamId:1,ParentId:1,ParentInsertDate:1,ParentInsertUserId:1,ParentIsActive:1,ParentName:1,ParentParentId:1,ParentTenantId:1,ParentUpdateDate:1,ParentUpdateUserId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ExamSectionResult:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamSectionDescription:1,ExamSectionExamId:1,ExamSectionId:1,ExamSectionInsertDate:1,ExamSectionInsertUserId:1,ExamSectionIsActive:1,ExamSectionName:1,ExamSectionParentId:1,ExamSectionTenantId:1,ExamSectionUpdateDate:1,ExamSectionUpdateUserId:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,ObtainedMarks:1,Percentage:1,RollNumber:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1,TotalAttempted:1,TotalMarks:1,TotalNotAttempted:1,TotalQuestions:1,TotalRightAnswers:1,TotalWrongAnswers:1,UpdateDate:1,UpdateUserId:1},Group:{Description:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,ParentDescription:1,ParentId:1,ParentInsertDate:1,ParentInsertUserId:1,ParentIsActive:1,ParentName:1,ParentParentId:1,ParentTenantId:1,ParentUpdateDate:1,ParentUpdateUserId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},GroupStudent:{GroupDescription:1,GroupId:1,GroupInsertDate:1,GroupInsertUserId:1,GroupIsActive:1,GroupName:1,GroupParentId:1,GroupTenantId:1,GroupUpdateDate:1,GroupUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,RowIds:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ImportedScannedBatch:{Description:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ImportedScannedQuestion:{CorrectedOptions:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,QuestionIndex:1,ScannedOptions:1,ScannedSheetCorrectedExamNo:1,ScannedSheetCorrectedRollNo:1,ScannedSheetExamSetNo:1,ScannedSheetId:1,ScannedSheetInsertDate:1,ScannedSheetInsertUserId:1,ScannedSheetIsActive:1,ScannedSheetResultProcessed:1,ScannedSheetScannedAt:1,ScannedSheetScannedBatchId:1,ScannedSheetScannedComments:1,ScannedSheetScannedExamNo:1,ScannedSheetScannedImage:1,ScannedSheetScannedImageSourcePath:1,ScannedSheetScannedRollNo:1,ScannedSheetScannedStatus:1,ScannedSheetScannedSystemErrors:1,ScannedSheetScannedUserErrors:1,ScannedSheetSheetNumber:1,ScannedSheetSheetTypeId:1,ScannedSheetTenantId:1,ScannedSheetUpdateDate:1,ScannedSheetUpdateUserId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ImportedScannedSheet:{CorrectedExamNo:1,CorrectedRollNo:1,ExamSetNo:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,ResultProcessed:1,ScannedAt:1,ScannedBatchDescription:1,ScannedBatchId:1,ScannedBatchInsertDate:1,ScannedBatchInsertUserId:1,ScannedBatchIsActive:1,ScannedBatchName:1,ScannedBatchTenantId:1,ScannedBatchUpdateDate:1,ScannedBatchUpdateUserId:1,ScannedComments:1,ScannedExamNo:1,ScannedImage:1,ScannedImageSourcePath:1,ScannedRollNo:1,ScannedStatus:1,ScannedSystemErrors:1,ScannedUserErrors:1,SheetNumber:1,SheetTypeDescription:1,SheetTypeEPaperSize:1,SheetTypeHeightInPixel:1,SheetTypeId:1,SheetTypeInsertDate:1,SheetTypeInsertUserId:1,SheetTypeIsActive:1,SheetTypeIsPrivate:1,SheetTypeName:1,SheetTypeOverlayImage:1,SheetTypePdfTemplate:1,SheetTypeSheetData:1,SheetTypeSheetImage:1,SheetTypeSheetNumber:1,SheetTypeSynced:1,SheetTypeTotalQuestions:1,SheetTypeUpdateDate:1,SheetTypeUpdateUserId:1,SheetTypeWidthInPixel:1,TenantId:1,UpdateDate:1,UpdateUserId:1},RuleType:{Description:1,Id:1,Name:1},ScannedBatch:{Description:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ScannedQuestion:{CorrectedOptions:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,QuestionIndex:1,ScannedOptions:1,ScannedSheetCorrectedExamNo:1,ScannedSheetCorrectedRollNo:1,ScannedSheetExamSetNo:1,ScannedSheetId:1,ScannedSheetInsertDate:1,ScannedSheetInsertUserId:1,ScannedSheetIsActive:1,ScannedSheetResultProcessed:1,ScannedSheetScannedAt:1,ScannedSheetScannedBatchId:1,ScannedSheetScannedComments:1,ScannedSheetScannedExamNo:1,ScannedSheetScannedImage:1,ScannedSheetScannedImageSourcePath:1,ScannedSheetScannedRollNo:1,ScannedSheetScannedStatus:1,ScannedSheetScannedSystemErrors:1,ScannedSheetScannedUserErrors:1,ScannedSheetSheetNumber:1,ScannedSheetSheetTypeId:1,ScannedSheetTenantId:1,ScannedSheetUpdateDate:1,ScannedSheetUpdateUserId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ScannedSheet:{CorrectedExamNo:1,CorrectedRollNo:1,ExamSetNo:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,ResultProcessed:1,ScannedAt:1,ScannedBatchDescription:1,ScannedBatchId:1,ScannedBatchInsertDate:1,ScannedBatchInsertUserId:1,ScannedBatchIsActive:1,ScannedBatchName:1,ScannedBatchTenantId:1,ScannedBatchUpdateDate:1,ScannedBatchUpdateUserId:1,ScannedComments:1,ScannedExamNo:1,ScannedImage:1,ScannedImageSourcePath:1,ScannedRollNo:1,ScannedStatus:1,ScannedSystemErrors:1,ScannedUserErrors:1,SheetNumber:1,SheetTypeDescription:1,SheetTypeEPaperSize:1,SheetTypeHeightInPixel:1,SheetTypeId:1,SheetTypeInsertDate:1,SheetTypeInsertUserId:1,SheetTypeIsActive:1,SheetTypeIsPrivate:1,SheetTypeName:1,SheetTypeOverlayImage:1,SheetTypePdfTemplate:1,SheetTypeSheetData:1,SheetTypeSheetImage:1,SheetTypeSheetNumber:1,SheetTypeSynced:1,SheetTypeTotalQuestions:1,SheetTypeUpdateDate:1,SheetTypeUpdateUserId:1,SheetTypeWidthInPixel:1,TenantId:1,UpdateDate:1,UpdateUserId:1},SelectSheetType:{Description:1,EPaperSize:1,HeightInPixel:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,IsPrivate:1,Name:1,OverlayImage:1,PdfTemplate:1,SheetData:1,SheetImage:1,SheetNumber:1,Synced:1,TotalQuestions:1,UpdateDate:1,UpdateUserId:1,WidthInPixel:1},SheetType:{Description:1,EPaperSize:1,HeightInPixel:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,IsPrivate:1,Name:1,OverlayImage:1,PdfTemplate:1,SheetData:1,SheetImage:1,SheetNumber:1,Synced:1,TotalQuestions:1,UpdateDate:1,UpdateUserId:1,WidthInPixel:1},SheetTypeTenant:{DisplayOrder:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,IsDefault:1,RowIds:1,SheetDesignPdf:1,SheetTypeDescription:1,SheetTypeEPaperSize:1,SheetTypeHeightInPixel:1,SheetTypeId:1,SheetTypeInsertDate:1,SheetTypeInsertUserId:1,SheetTypeIsActive:1,SheetTypeIsPrivate:1,SheetTypeName:1,SheetTypeOverlayImage:1,SheetTypePdfTemplate:1,SheetTypeSheetData:1,SheetTypeSheetImage:1,SheetTypeSheetNumber:1,SheetTypeSynced:1,SheetTypeTotalQuestions:1,SheetTypeUpdateDate:1,SheetTypeUpdateUserId:1,SheetTypeWidthInPixel:1,TenantId:1,TenantTenantName:1,UpdateDate:1,UpdateUserId:1},Student:{Dob:1,Email:1,FirstName:1,FullName:1,Gender:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,LastName:1,MiddleName:1,Mobile:1,Note:1,RollNo:1,TenantId:1,UpdateDate:1,UpdateUserId:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{BackToLogin:1,FormInfo:1,FormTitle:1,SubmitButton:1,Success:1},Login:{FacebookButton:1,ForgotPassword:1,GoogleButton:1,LoginToYourAccount:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{BackToLogin:1,EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{AcceptTerms:1,ActivateEmailSubject:1,ActivationCompleteMessage:1,BackToLogin:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}}},Navigation:{LogoutLink:1,SiteTitle:1},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},BasicProgressDialog:{CancelTitle:1,PleaseWait:1},BulkServiceAction:{AllHadErrorsFormat:1,AllSuccessFormat:1,ConfirmationFormat:1,ErrorCount:1,NothingToProcess:1,SomeHadErrorsFormat:1,SuccessCount:1},Dashboard:{ContentDescription:1},Dialogs:{PendingChangesConfirmation:1},Layout:{FooterCopyright:1,FooterInfo:1,FooterRights:1,GeneralSettings:1,Language:1,Theme:1,ThemeAzure:1,ThemeAzureLight:1,ThemeBlack:1,ThemeBlackLight:1,ThemeBlue:1,ThemeBlueLight:1,ThemeCosmos:1,ThemeCosmosLight:1,ThemeGlassy:1,ThemeGlassyLight:1,ThemeGreen:1,ThemeGreenLight:1,ThemePurple:1,ThemePurpleLight:1,ThemeRed:1,ThemeRedLight:1,ThemeYellow:1,ThemeYellowLight:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},UserRoleDialog:{DialogTitle:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CantFindUserWithEmail:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,SavePrimaryKeyError:1}}) as any;
}
