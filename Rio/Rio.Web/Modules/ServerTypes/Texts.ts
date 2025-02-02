﻿import { proxyTexts } from "@serenity-is/corelib/q";

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
                export const EApprovalStatus: string;
                export const IsActive: string;
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
                export const Countrycode: string;
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
                export const SMSVerificationCode: string;
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

        namespace Common {

            namespace Mail {
                export const AwsPassword: string;
                export const AwsUserId: string;
                export const Bcc: string;
                export const Body: string;
                export const Cc: string;
                export const ErrorMessage: string;
                export const FromName: string;
                export const Host: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const LockExpiration: string;
                export const MailFrom: string;
                export const MailId: string;
                export const MailTo: string;
                export const Port: string;
                export const Priority: string;
                export const ReplyTo: string;
                export const RetryCount: string;
                export const SentDate: string;
                export const SerializedMessage: string;
                export const Status: string;
                export const Subject: string;
                export const Uid: string;
                export const UseXOAUTH2: string;
            }
        }

        namespace ResultReportView {

            namespace ResultReport {
                export const CorrectedOptions: string;
                export const ExamCode: string;
                export const ExamId: string;
                export const Id: string;
                export const IsAttempted: string;
                export const IsCorrect: string;
                export const ObtainedMarks: string;
                export const QuestionIndex: string;
                export const RightOptions: string;
                export const RollNumber: string;
                export const ScannedSheetId: string;
                export const Score: string;
            }
        }

        namespace Workspace {

            namespace Activation {
                export const ActivationDate: string;
                export const ActivationLogId: string;
                export const DeviceDetails: string;
                export const DeviceId: string;
                export const EStatus: string;
                export const ExamListDescription: string;
                export const ExamListId: string;
                export const ExamListInsertDate: string;
                export const ExamListInsertUserId: string;
                export const ExamListIsActive: string;
                export const ExamListName: string;
                export const ExamListTenantId: string;
                export const ExamListThumbnail: string;
                export const ExamListUpdateDate: string;
                export const ExamListUpdateUserId: string;
                export const ExpiryDate: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SerialKey: string;
                export const SerialKeyId: string;
                export const TeacherAddress: string;
                export const TeacherAllowedIps: string;
                export const TeacherCity: string;
                export const TeacherDob: string;
                export const TeacherEmail: string;
                export const TeacherFirstName: string;
                export const TeacherFullName: string;
                export const TeacherId: string;
                export const TeacherInsertDate: string;
                export const TeacherInsertUserId: string;
                export const TeacherIsActive: string;
                export const TeacherLastName: string;
                export const TeacherMiddleName: string;
                export const TeacherMobile: string;
                export const TeacherSchoolOrInstitute: string;
                export const TeacherTenantId: string;
                export const TeacherUpdateDate: string;
                export const TeacherUpdateUserId: string;
                export const TeacherUserId: string;
                export const TenantId: string;
                export const TenantTenantName: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ActivationLog {
                export const ActivationId: string;
                export const Code: string;
                export const DeviceDetails: string;
                export const DeviceId: string;
                export const EStatus: string;
                export const ExamListDescription: string;
                export const ExamListId: string;
                export const ExamListInsertDate: string;
                export const ExamListInsertUserId: string;
                export const ExamListIsActive: string;
                export const ExamListName: string;
                export const ExamListTenantId: string;
                export const ExamListUpdateDate: string;
                export const ExamListUpdateUserId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Note: string;
                export const SerialKey: string;
                export const SerialKeyId: string;
                export const TeacherAddress: string;
                export const TeacherAllowedIps: string;
                export const TeacherCity: string;
                export const TeacherDob: string;
                export const TeacherEmail: string;
                export const TeacherFirstName: string;
                export const TeacherFullName: string;
                export const TeacherId: string;
                export const TeacherInsertDate: string;
                export const TeacherInsertUserId: string;
                export const TeacherIsActive: string;
                export const TeacherLastName: string;
                export const TeacherMiddleName: string;
                export const TeacherMobile: string;
                export const TeacherSchoolOrInstitute: string;
                export const TeacherTenantId: string;
                export const TeacherUpdateDate: string;
                export const TeacherUpdateUserId: string;
                export const TeacherUserId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace CloudStorageProvider {
                export const Description: string;
                export const Id: string;
                export const Name: string;
                export const NumberOfParameter: string;
                export const Parameter10Title: string;
                export const Parameter1Title: string;
                export const Parameter2Title: string;
                export const Parameter3Title: string;
                export const Parameter4Title: string;
                export const Parameter5Title: string;
                export const Parameter6Title: string;
                export const Parameter7Title: string;
                export const Parameter8Title: string;
                export const Parameter9Title: string;
                export const ParameterProvider: string;
                export const TenantEApprovalStatus: string;
                export const TenantId: string;
                export const TenantIsActive: string;
                export const TenantTenantName: string;
            }

            namespace CloudStorageSetting {
                export const CloudStorageProvidersDescription: string;
                export const CloudStorageProvidersId: string;
                export const CloudStorageProvidersName: string;
                export const CloudStorageProvidersNumberOfParameter: string;
                export const CloudStorageProvidersParameter10Title: string;
                export const CloudStorageProvidersParameter1Title: string;
                export const CloudStorageProvidersParameter2Title: string;
                export const CloudStorageProvidersParameter3Title: string;
                export const CloudStorageProvidersParameter4Title: string;
                export const CloudStorageProvidersParameter5Title: string;
                export const CloudStorageProvidersParameter6Title: string;
                export const CloudStorageProvidersParameter7Title: string;
                export const CloudStorageProvidersParameter8Title: string;
                export const CloudStorageProvidersParameter9Title: string;
                export const CloudStorageProvidersParameterProvider: string;
                export const CloudStorageProvidersTenantId: string;
                export const Id: string;
                export const Parameter1: string;
                export const Parameter10: string;
                export const Parameter2: string;
                export const Parameter3: string;
                export const Parameter4: string;
                export const Parameter5: string;
                export const Parameter6: string;
                export const Parameter7: string;
                export const Parameter8: string;
                export const Parameter9: string;
                export const ParameterProvider: string;
                export const TenantEApprovalStatus: string;
                export const TenantId: string;
                export const TenantIsActive: string;
                export const TenantTenantName: string;
            }

            namespace CouponCode {
                export const Code: string;
                export const ConsumedCount: string;
                export const Count: string;
                export const CountType: string;
                export const CouponValidityDate: string;
                export const ExamListDescription: string;
                export const ExamListId: string;
                export const ExamListInsertDate: string;
                export const ExamListInsertUserId: string;
                export const ExamListIsActive: string;
                export const ExamListName: string;
                export const ExamListTenantId: string;
                export const ExamListUpdateDate: string;
                export const ExamListUpdateUserId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const ValidDate: string;
                export const ValidityInDays: string;
                export const ValidityType: string;
            }

            namespace Exam {
                export const Code: string;
                export const Description: string;
                export const ExamDisplayName: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const ModelAnswer: string;
                export const Name: string;
                export const NegativeMarks: string;
                export const OptionsAvailable: string;
                export const QuestionPaper: string;
                export const ResultCriteria: string;
                export const SelectedTenant: string;
                export const SheetTypeDescription: string;
                export const SheetTypeDisplayName: string;
                export const SheetTypeEPaperSize: string;
                export const SheetTypeHeightInPixel: string;
                export const SheetTypeId: string;
                export const SheetTypeIsPrivate: string;
                export const SheetTypeName: string;
                export const SheetTypeOverlayImage: string;
                export const SheetTypeOverlayImageOpenCV: string;
                export const SheetTypePdfTemplate: string;
                export const SheetTypeSheetData: string;
                export const SheetTypeSheetImage: string;
                export const SheetTypeSheetNumber: string;
                export const SheetTypeSynced: string;
                export const SheetTypeTotalQuestions: string;
                export const SheetTypeWidthInPixel: string;
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

            namespace ExamList {
                export const Description: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const TenantEApprovalStatus: string;
                export const TenantId: string;
                export const TenantIsActive: string;
                export const TenantTenantName: string;
                export const Thumbnail: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace ExamListExams {
                export const Description: string;
                export const EApprovalStatus: string;
                export const EPaperSize: string;
                export const EndDate: string;
                export const ExamCode: string;
                export const ExamDescription: string;
                export const ExamExamDisplayName: string;
                export const ExamId: string;
                export const ExamInsertDate: string;
                export const ExamInsertUserId: string;
                export const ExamIsActive: string;
                export const ExamListDescription: string;
                export const ExamListId: string;
                export const ExamListInsertDate: string;
                export const ExamListInsertUserId: string;
                export const ExamListIsActive: string;
                export const ExamListName: string;
                export const ExamListTenantId: string;
                export const ExamListUpdateDate: string;
                export const ExamListUpdateUserId: string;
                export const ExamModelAnswer: string;
                export const ExamName: string;
                export const ExamNegativeMarks: string;
                export const ExamOptionsAvailable: string;
                export const ExamQuestionPaper: string;
                export const ExamResultCriteria: string;
                export const ExamSheetTypeId: string;
                export const ExamTenantId: string;
                export const ExamTotalMarks: string;
                export const ExamTotalQuestions: string;
                export const ExamUpdateDate: string;
                export const ExamUpdateUserId: string;
                export const HeightInPixel: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsPrivate: string;
                export const ModelAnswerPaperStartDate: string;
                export const OverlayImage: string;
                export const OverlayImageOpenCV: string;
                export const PdfTemplate: string;
                export const Priority: string;
                export const RowIds: string;
                export const SheetData: string;
                export const SheetImage: string;
                export const SheetNumber: string;
                export const SheetTypeDisplayName: string;
                export const StartDate: string;
                export const Synced: string;
                export const TenantEApprovalStatus: string;
                export const TenantId: string;
                export const TenantIsActive: string;
                export const TenantName: string;
                export const TenantTenantName: string;
                export const TotalQuestions: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const WidthInPixel: string;
            }

            namespace ExamQuestion {
                export const DisplayIndex: string;
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
                export const RightOption: string;
                export const RowIds: string;
                export const RuleTypeDescription: string;
                export const RuleTypeId: string;
                export const RuleTypeName: string;
                export const Score: string;
                export const Tags: string;
                export const TenantId: string;
                export const TenantName: string;
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
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsAttempted: string;
                export const IsCorrect: string;
                export const ObtainedMarks: string;
                export const QuestionIndex: string;
                export const RollNumber: string;
                export const ScannedBatchId: string;
                export const ScannedSheetId: string;
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
                export const UpdateDate: string;
                export const UpdateUserId: string;
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
                export const DetailList: string;
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
                export const OCRData1Value: string;
                export const ObtainedMarks: string;
                export const Percentage: string;
                export const RollNumber: string;
                export const ScannedBatchId: string;
                export const ScannedSheetId: string;
                export const ScannedSheetImageBase64: string;
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
                export const TenantName: string;
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
                export const ScannedBatchId: string;
                export const ScannedSheetCorrectedExamNo: string;
                export const ScannedSheetCorrectedRollNo: string;
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

            namespace ExamTeachers {
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const RowIds: string;
                export const TeacherAddress: string;
                export const TeacherAllowedIps: string;
                export const TeacherCity: string;
                export const TeacherDob: string;
                export const TeacherEmail: string;
                export const TeacherFirstName: string;
                export const TeacherFullName: string;
                export const TeacherId: string;
                export const TeacherInsertDate: string;
                export const TeacherInsertUserId: string;
                export const TeacherIsActive: string;
                export const TeacherLastName: string;
                export const TeacherMiddleName: string;
                export const TeacherMobile: string;
                export const TeacherTenantId: string;
                export const TeacherUpdateDate: string;
                export const TeacherUpdateUserId: string;
                export const TeacherUserId: string;
                export const TenantId: string;
                export const TheoryExamCode: string;
                export const TheoryExamDescription: string;
                export const TheoryExamId: string;
                export const TheoryExamInsertDate: string;
                export const TheoryExamInsertUserId: string;
                export const TheoryExamIsActive: string;
                export const TheoryExamName: string;
                export const TheoryExamTenantId: string;
                export const TheoryExamTotalMarks: string;
                export const TheoryExamUpdateDate: string;
                export const TheoryExamUpdateUserId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace GetScanData {
                export const CorrectedOptions: string;
                export const CorrectedRollNo: string;
                export const ExamId: string;
                export const Id: string;
                export const NegativeMarks: string;
                export const QuestionIndex: string;
                export const RightOptions: string;
                export const RuleTypeId: string;
                export const ScanBatchId: string;
                export const ScanSheetId: string;
                export const Score: string;
                export const SheetNumber: string;
                export const StudentId: string;
                export const TenantId: string;
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
                export const SelectedTenant: string;
                export const TeacherId: string;
                export const TenantId: string;
                export const TenantName: string;
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
                export const TeacherId: string;
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
                export const ScannedBatchId: string;
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
                export const ICRData1Key: string;
                export const ICRData1Value: string;
                export const ICRData2Key: string;
                export const ICRData2Value: string;
                export const ICRData3Key: string;
                export const ICRData3Value: string;
                export const Id: string;
                export const ImportScannedSheetDisplayName: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsRectified: string;
                export const OCRData1Key: string;
                export const OCRData1Value: string;
                export const OCRData2Key: string;
                export const OCRData2Value: string;
                export const OCRData3Key: string;
                export const OCRData3Value: string;
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

            namespace KeyGenAs {
                export const EStatus: string;
                export const ExamListDescription: string;
                export const ExamListId: string;
                export const ExamListInsertDate: string;
                export const ExamListInsertUserId: string;
                export const ExamListIsActive: string;
                export const ExamListName: string;
                export const ExamListTenantId: string;
                export const ExamListUpdateDate: string;
                export const ExamListUpdateUserId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Note: string;
                export const Quantity: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const ValidDate: string;
                export const ValidityInDays: string;
                export const ValidityType: string;
            }

            namespace PreDefinedKey {
                export const EStatus: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const SerialKey: string;
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
                export const ScannedQuestions: string;
                export const ScannedSheets: string;
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
                export const ScannedBatchId: string;
                export const ScannedOptions: string;
                export const ScannedSheetCorrectedExamNo: string;
                export const ScannedSheetCorrectedRollNo: string;
                export const ScannedSheetExamSetNo: string;
                export const ScannedSheetId: string;
                export const ScannedSheetImageBase64: string;
                export const ScannedSheetInsertDate: string;
                export const ScannedSheetInsertUserId: string;
                export const ScannedSheetIsActive: string;
                export const ScannedSheetOCRData1Key: string;
                export const ScannedSheetOCRData1Value: string;
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
                export const ICRData1Key: string;
                export const ICRData1Value: string;
                export const ICRData2Key: string;
                export const ICRData2Value: string;
                export const ICRData3Key: string;
                export const ICRData3Value: string;
                export const Id: string;
                export const ImageBase64: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const IsRectified: string;
                export const OCRData1Key: string;
                export const OCRData1Value: string;
                export const OCRData2Key: string;
                export const OCRData2Value: string;
                export const OCRData3Key: string;
                export const OCRData3Value: string;
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
                export const ScannedQuestions: string;
                export const ScannedRollNo: string;
                export const ScannedSheetDisplayName: string;
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

            namespace SerialKey {
                export const EStatus: string;
                export const ExamListDescription: string;
                export const ExamListId: string;
                export const ExamListInsertDate: string;
                export const ExamListInsertUserId: string;
                export const ExamListIsActive: string;
                export const ExamListName: string;
                export const ExamListTenantId: string;
                export const ExamListUpdateDate: string;
                export const ExamListUpdateUserId: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const KeyGenAsId: string;
                export const Note: string;
                export const SerialKey: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const ValidDate: string;
                export const ValidityInDays: string;
                export const ValidityType: string;
            }

            namespace Settings {
                export const ApiKey: string;
                export const From: string;
                export const GatewayUrl: string;
                export const Host: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Password: string;
                export const Port: string;
                export const Sender: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UseSsl: string;
                export const UseXOAUTH2: string;
                export const UserName: string;
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
                export const IsPublic: string;
                export const Name: string;
                export const OverlayImage: string;
                export const OverlayImageOpenCV: string;
                export const PdfTemplate: string;
                export const SheetData: string;
                export const SheetImage: string;
                export const SheetNumber: string;
                export const SheetTypeDisplayName: string;
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
                export const SheetTypeDisplayName: string;
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
                export const Comments: string;
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
                export const SelectedTenant: string;
                export const StudentId: string;
                export const TenantId: string;
                export const TenantName: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace Teachers {
                export const Address: string;
                export const AllowedIps: string;
                export const City: string;
                export const Dob: string;
                export const Email: string;
                export const FirstName: string;
                export const FullName: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastName: string;
                export const MiddleName: string;
                export const Mobile: string;
                export const SchoolOrInstitute: string;
                export const TenantId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
            }

            namespace TheoryExamQuestions {
                export const DisplayIndex: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const MaxMarks: string;
                export const QuestionIndex: string;
                export const Tags: string;
                export const TenantId: string;
                export const TheoryExamCode: string;
                export const TheoryExamDescription: string;
                export const TheoryExamId: string;
                export const TheoryExamInsertDate: string;
                export const TheoryExamInsertUserId: string;
                export const TheoryExamIsActive: string;
                export const TheoryExamName: string;
                export const TheoryExamSectionDescription: string;
                export const TheoryExamSectionId: string;
                export const TheoryExamSectionInsertDate: string;
                export const TheoryExamSectionInsertUserId: string;
                export const TheoryExamSectionIsActive: string;
                export const TheoryExamSectionName: string;
                export const TheoryExamSectionParentId: string;
                export const TheoryExamSectionSortOrder: string;
                export const TheoryExamSectionTenantId: string;
                export const TheoryExamSectionTheoryExamId: string;
                export const TheoryExamSectionUpdateDate: string;
                export const TheoryExamSectionUpdateUserId: string;
                export const TheoryExamTenantId: string;
                export const TheoryExamTotalMarks: string;
                export const TheoryExamUpdateDate: string;
                export const TheoryExamUpdateUserId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace TheoryExamResultQuestions {
                export const AttemptStatus: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const MarksObtained: string;
                export const OutOfMarks: string;
                export const TenantId: string;
                export const TheoryExamQuestionDisplayIndex: string;
                export const TheoryExamQuestionId: string;
                export const TheoryExamQuestionInsertDate: string;
                export const TheoryExamQuestionInsertUserId: string;
                export const TheoryExamQuestionIsActive: string;
                export const TheoryExamQuestionMaxMarks: string;
                export const TheoryExamQuestionQuestionIndex: string;
                export const TheoryExamQuestionTags: string;
                export const TheoryExamQuestionTenantId: string;
                export const TheoryExamQuestionTheoryExamId: string;
                export const TheoryExamQuestionTheoryExamSectionId: string;
                export const TheoryExamQuestionUpdateDate: string;
                export const TheoryExamQuestionUpdateUserId: string;
                export const TheoryExamResultAttemptDate: string;
                export const TheoryExamResultId: string;
                export const TheoryExamResultInsertDate: string;
                export const TheoryExamResultInsertUserId: string;
                export const TheoryExamResultIsActive: string;
                export const TheoryExamResultMarksScored: string;
                export const TheoryExamResultOutOfMarks: string;
                export const TheoryExamResultResultStatus: string;
                export const TheoryExamResultRollNumber: string;
                export const TheoryExamResultSheetImage: string;
                export const TheoryExamResultStudentId: string;
                export const TheoryExamResultStudentScanId: string;
                export const TheoryExamResultTenantId: string;
                export const TheoryExamResultTheoryExamId: string;
                export const TheoryExamResultUpdateDate: string;
                export const TheoryExamResultUpdateUserId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace TheoryExamResults {
                export const AttemptDate: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const MarksScored: string;
                export const OutOfMarks: string;
                export const ResultStatus: string;
                export const RollNumber: string;
                export const SheetImage: string;
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
                export const StudentScanId: string;
                export const StudentTenantId: string;
                export const StudentUpdateDate: string;
                export const StudentUpdateUserId: string;
                export const TenantId: string;
                export const TheoryExamCode: string;
                export const TheoryExamDescription: string;
                export const TheoryExamId: string;
                export const TheoryExamInsertDate: string;
                export const TheoryExamInsertUserId: string;
                export const TheoryExamIsActive: string;
                export const TheoryExamName: string;
                export const TheoryExamResultQuestions: string;
                export const TheoryExamTenantId: string;
                export const TheoryExamTotalMarks: string;
                export const TheoryExamUpdateDate: string;
                export const TheoryExamUpdateUserId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace TheoryExamSections {
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
                export const ParentSortOrder: string;
                export const ParentTenantId: string;
                export const ParentTheoryExamId: string;
                export const ParentUpdateDate: string;
                export const ParentUpdateUserId: string;
                export const SortOrder: string;
                export const TenantId: string;
                export const TheoryExamCode: string;
                export const TheoryExamDescription: string;
                export const TheoryExamId: string;
                export const TheoryExamInsertDate: string;
                export const TheoryExamInsertUserId: string;
                export const TheoryExamIsActive: string;
                export const TheoryExamName: string;
                export const TheoryExamTenantId: string;
                export const TheoryExamTotalMarks: string;
                export const TheoryExamUpdateDate: string;
                export const TheoryExamUpdateUserId: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
            }

            namespace TheoryExams {
                export const Code: string;
                export const Description: string;
                export const ExamQuestions: string;
                export const ExamSections: string;
                export const Id: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const Name: string;
                export const RowIds: string;
                export const TenantId: string;
                export const TotalMarks: string;
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

    Rio['Texts'] = proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleKey:1,RoleName:1,TenantId:1},RolePermission:{PermissionKey:1,RoleId:1,RolePermissionId:1,RoleRoleName:1},Tenant:{EApprovalStatus:1,IsActive:1,TenantId:1,TenantName:1},Translation:{CustomText:1,EntityPlural:1,Key:1,OverrideConfirmation:1,SaveChangesButton:1,SourceLanguage:1,SourceText:1,TargetLanguage:1,TargetText:1},User:{Countrycode:1,DisplayName:1,Email:1,ImpersonationToken:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,MobilePhoneNumber:1,MobilePhoneVerified:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Roles:1,SMSVerificationCode:1,Source:1,TenantId:1,TenantName:1,TwoFactorAuth:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Common:{Mail:{AwsPassword:1,AwsUserId:1,Bcc:1,Body:1,Cc:1,ErrorMessage:1,FromName:1,Host:1,InsertDate:1,InsertUserId:1,LockExpiration:1,MailFrom:1,MailId:1,MailTo:1,Port:1,Priority:1,ReplyTo:1,RetryCount:1,SentDate:1,SerializedMessage:1,Status:1,Subject:1,Uid:1,UseXOAUTH2:1}},ResultReportView:{ResultReport:{CorrectedOptions:1,ExamCode:1,ExamId:1,Id:1,IsAttempted:1,IsCorrect:1,ObtainedMarks:1,QuestionIndex:1,RightOptions:1,RollNumber:1,ScannedSheetId:1,Score:1}},Workspace:{Activation:{ActivationDate:1,ActivationLogId:1,DeviceDetails:1,DeviceId:1,EStatus:1,ExamListDescription:1,ExamListId:1,ExamListInsertDate:1,ExamListInsertUserId:1,ExamListIsActive:1,ExamListName:1,ExamListTenantId:1,ExamListThumbnail:1,ExamListUpdateDate:1,ExamListUpdateUserId:1,ExpiryDate:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,SerialKey:1,SerialKeyId:1,TeacherAddress:1,TeacherAllowedIps:1,TeacherCity:1,TeacherDob:1,TeacherEmail:1,TeacherFirstName:1,TeacherFullName:1,TeacherId:1,TeacherInsertDate:1,TeacherInsertUserId:1,TeacherIsActive:1,TeacherLastName:1,TeacherMiddleName:1,TeacherMobile:1,TeacherSchoolOrInstitute:1,TeacherTenantId:1,TeacherUpdateDate:1,TeacherUpdateUserId:1,TeacherUserId:1,TenantId:1,TenantTenantName:1,UpdateDate:1,UpdateUserId:1},ActivationLog:{ActivationId:1,Code:1,DeviceDetails:1,DeviceId:1,EStatus:1,ExamListDescription:1,ExamListId:1,ExamListInsertDate:1,ExamListInsertUserId:1,ExamListIsActive:1,ExamListName:1,ExamListTenantId:1,ExamListUpdateDate:1,ExamListUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Note:1,SerialKey:1,SerialKeyId:1,TeacherAddress:1,TeacherAllowedIps:1,TeacherCity:1,TeacherDob:1,TeacherEmail:1,TeacherFirstName:1,TeacherFullName:1,TeacherId:1,TeacherInsertDate:1,TeacherInsertUserId:1,TeacherIsActive:1,TeacherLastName:1,TeacherMiddleName:1,TeacherMobile:1,TeacherSchoolOrInstitute:1,TeacherTenantId:1,TeacherUpdateDate:1,TeacherUpdateUserId:1,TeacherUserId:1,UpdateDate:1,UpdateUserId:1},CloudStorageProvider:{Description:1,Id:1,Name:1,NumberOfParameter:1,Parameter10Title:1,Parameter1Title:1,Parameter2Title:1,Parameter3Title:1,Parameter4Title:1,Parameter5Title:1,Parameter6Title:1,Parameter7Title:1,Parameter8Title:1,Parameter9Title:1,ParameterProvider:1,TenantEApprovalStatus:1,TenantId:1,TenantIsActive:1,TenantTenantName:1},CloudStorageSetting:{CloudStorageProvidersDescription:1,CloudStorageProvidersId:1,CloudStorageProvidersName:1,CloudStorageProvidersNumberOfParameter:1,CloudStorageProvidersParameter10Title:1,CloudStorageProvidersParameter1Title:1,CloudStorageProvidersParameter2Title:1,CloudStorageProvidersParameter3Title:1,CloudStorageProvidersParameter4Title:1,CloudStorageProvidersParameter5Title:1,CloudStorageProvidersParameter6Title:1,CloudStorageProvidersParameter7Title:1,CloudStorageProvidersParameter8Title:1,CloudStorageProvidersParameter9Title:1,CloudStorageProvidersParameterProvider:1,CloudStorageProvidersTenantId:1,Id:1,Parameter1:1,Parameter10:1,Parameter2:1,Parameter3:1,Parameter4:1,Parameter5:1,Parameter6:1,Parameter7:1,Parameter8:1,Parameter9:1,ParameterProvider:1,TenantEApprovalStatus:1,TenantId:1,TenantIsActive:1,TenantTenantName:1},CouponCode:{Code:1,ConsumedCount:1,Count:1,CountType:1,CouponValidityDate:1,ExamListDescription:1,ExamListId:1,ExamListInsertDate:1,ExamListInsertUserId:1,ExamListIsActive:1,ExamListName:1,ExamListTenantId:1,ExamListUpdateDate:1,ExamListUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,TenantId:1,UpdateDate:1,UpdateUserId:1,ValidDate:1,ValidityInDays:1,ValidityType:1},Exam:{Code:1,Description:1,ExamDisplayName:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,ModelAnswer:1,Name:1,NegativeMarks:1,OptionsAvailable:1,QuestionPaper:1,ResultCriteria:1,SelectedTenant:1,SheetTypeDescription:1,SheetTypeDisplayName:1,SheetTypeEPaperSize:1,SheetTypeHeightInPixel:1,SheetTypeId:1,SheetTypeIsPrivate:1,SheetTypeName:1,SheetTypeOverlayImage:1,SheetTypeOverlayImageOpenCV:1,SheetTypePdfTemplate:1,SheetTypeSheetData:1,SheetTypeSheetImage:1,SheetTypeSheetNumber:1,SheetTypeSynced:1,SheetTypeTotalQuestions:1,SheetTypeWidthInPixel:1,TenantId:1,TotalMarks:1,TotalQuestions:1,UpdateDate:1,UpdateUserId:1},ExamGroupWiseResult:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,GroupDescription:1,GroupId:1,GroupInsertDate:1,GroupInsertUserId:1,GroupIsActive:1,GroupName:1,GroupParentId:1,GroupTenantId:1,GroupUpdateDate:1,GroupUpdateUserId:1,Id:1,Rank:1,RollNumber:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1},ExamList:{Description:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,TenantEApprovalStatus:1,TenantId:1,TenantIsActive:1,TenantTenantName:1,Thumbnail:1,UpdateDate:1,UpdateUserId:1},ExamListExams:{Description:1,EApprovalStatus:1,EPaperSize:1,EndDate:1,ExamCode:1,ExamDescription:1,ExamExamDisplayName:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamListDescription:1,ExamListId:1,ExamListInsertDate:1,ExamListInsertUserId:1,ExamListIsActive:1,ExamListName:1,ExamListTenantId:1,ExamListUpdateDate:1,ExamListUpdateUserId:1,ExamModelAnswer:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamQuestionPaper:1,ExamResultCriteria:1,ExamSheetTypeId:1,ExamTenantId:1,ExamTotalMarks:1,ExamTotalQuestions:1,ExamUpdateDate:1,ExamUpdateUserId:1,HeightInPixel:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,IsPrivate:1,ModelAnswerPaperStartDate:1,OverlayImage:1,OverlayImageOpenCV:1,PdfTemplate:1,Priority:1,RowIds:1,SheetData:1,SheetImage:1,SheetNumber:1,SheetTypeDisplayName:1,StartDate:1,Synced:1,TenantEApprovalStatus:1,TenantId:1,TenantIsActive:1,TenantName:1,TenantTenantName:1,TotalQuestions:1,UpdateDate:1,UpdateUserId:1,WidthInPixel:1},ExamQuestion:{DisplayIndex:1,ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamSectionDescription:1,ExamSectionExamId:1,ExamSectionId:1,ExamSectionInsertDate:1,ExamSectionInsertUserId:1,ExamSectionIsActive:1,ExamSectionName:1,ExamSectionParentId:1,ExamSectionTenantId:1,ExamSectionUpdateDate:1,ExamSectionUpdateUserId:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,QuestionIndex:1,RightOption:1,RowIds:1,RuleTypeDescription:1,RuleTypeId:1,RuleTypeName:1,Score:1,Tags:1,TenantId:1,TenantName:1,UpdateDate:1,UpdateUserId:1},ExamQuestionResult:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsAttempted:1,IsCorrect:1,ObtainedMarks:1,QuestionIndex:1,RollNumber:1,ScannedBatchId:1,ScannedSheetId:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ExamRankWiseResult:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,Rank:1,RollNumber:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1},ExamResult:{DetailList:1,ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,OCRData1Value:1,ObtainedMarks:1,Percentage:1,RollNumber:1,ScannedBatchId:1,ScannedSheetId:1,ScannedSheetImageBase64:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1,TenantName:1,TotalAttempted:1,TotalMarks:1,TotalNotAttempted:1,TotalQuestions:1,TotalRightAnswers:1,TotalWrongAnswers:1,UpdateDate:1,UpdateUserId:1},ExamSection:{Description:1,ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,ParentDescription:1,ParentExamId:1,ParentId:1,ParentInsertDate:1,ParentInsertUserId:1,ParentIsActive:1,ParentName:1,ParentParentId:1,ParentTenantId:1,ParentUpdateDate:1,ParentUpdateUserId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ExamSectionResult:{ExamCode:1,ExamDescription:1,ExamId:1,ExamInsertDate:1,ExamInsertUserId:1,ExamIsActive:1,ExamName:1,ExamNegativeMarks:1,ExamOptionsAvailable:1,ExamResultCriteria:1,ExamSectionDescription:1,ExamSectionExamId:1,ExamSectionId:1,ExamSectionInsertDate:1,ExamSectionInsertUserId:1,ExamSectionIsActive:1,ExamSectionName:1,ExamSectionParentId:1,ExamSectionTenantId:1,ExamSectionUpdateDate:1,ExamSectionUpdateUserId:1,ExamTenantId:1,ExamTotalMarks:1,ExamUpdateDate:1,ExamUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,ObtainedMarks:1,Percentage:1,RollNumber:1,ScannedBatchId:1,ScannedSheetCorrectedExamNo:1,ScannedSheetCorrectedRollNo:1,SheetGuid:1,SheetNumber:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1,TotalAttempted:1,TotalMarks:1,TotalNotAttempted:1,TotalQuestions:1,TotalRightAnswers:1,TotalWrongAnswers:1,UpdateDate:1,UpdateUserId:1},ExamTeachers:{Id:1,InsertDate:1,InsertUserId:1,IsActive:1,RowIds:1,TeacherAddress:1,TeacherAllowedIps:1,TeacherCity:1,TeacherDob:1,TeacherEmail:1,TeacherFirstName:1,TeacherFullName:1,TeacherId:1,TeacherInsertDate:1,TeacherInsertUserId:1,TeacherIsActive:1,TeacherLastName:1,TeacherMiddleName:1,TeacherMobile:1,TeacherTenantId:1,TeacherUpdateDate:1,TeacherUpdateUserId:1,TeacherUserId:1,TenantId:1,TheoryExamCode:1,TheoryExamDescription:1,TheoryExamId:1,TheoryExamInsertDate:1,TheoryExamInsertUserId:1,TheoryExamIsActive:1,TheoryExamName:1,TheoryExamTenantId:1,TheoryExamTotalMarks:1,TheoryExamUpdateDate:1,TheoryExamUpdateUserId:1,UpdateDate:1,UpdateUserId:1},GetScanData:{CorrectedOptions:1,CorrectedRollNo:1,ExamId:1,Id:1,NegativeMarks:1,QuestionIndex:1,RightOptions:1,RuleTypeId:1,ScanBatchId:1,ScanSheetId:1,Score:1,SheetNumber:1,StudentId:1,TenantId:1},Group:{Description:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,ParentDescription:1,ParentId:1,ParentInsertDate:1,ParentInsertUserId:1,ParentIsActive:1,ParentName:1,ParentParentId:1,ParentTenantId:1,ParentUpdateDate:1,ParentUpdateUserId:1,SelectedTenant:1,TeacherId:1,TenantId:1,TenantName:1,UpdateDate:1,UpdateUserId:1},GroupStudent:{GroupDescription:1,GroupId:1,GroupInsertDate:1,GroupInsertUserId:1,GroupIsActive:1,GroupName:1,GroupParentId:1,GroupTenantId:1,GroupUpdateDate:1,GroupUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,RowIds:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TeacherId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ImportedScannedBatch:{Description:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ImportedScannedQuestion:{CorrectedOptions:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,QuestionIndex:1,ScannedBatchId:1,ScannedOptions:1,ScannedSheetCorrectedExamNo:1,ScannedSheetCorrectedRollNo:1,ScannedSheetExamSetNo:1,ScannedSheetId:1,ScannedSheetInsertDate:1,ScannedSheetInsertUserId:1,ScannedSheetIsActive:1,ScannedSheetResultProcessed:1,ScannedSheetScannedAt:1,ScannedSheetScannedBatchId:1,ScannedSheetScannedComments:1,ScannedSheetScannedExamNo:1,ScannedSheetScannedImage:1,ScannedSheetScannedImageSourcePath:1,ScannedSheetScannedRollNo:1,ScannedSheetScannedStatus:1,ScannedSheetScannedSystemErrors:1,ScannedSheetScannedUserErrors:1,ScannedSheetSheetNumber:1,ScannedSheetSheetTypeId:1,ScannedSheetTenantId:1,ScannedSheetUpdateDate:1,ScannedSheetUpdateUserId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ImportedScannedSheet:{CorrectedExamNo:1,CorrectedRollNo:1,ExamSetNo:1,ICRData1Key:1,ICRData1Value:1,ICRData2Key:1,ICRData2Value:1,ICRData3Key:1,ICRData3Value:1,Id:1,ImportScannedSheetDisplayName:1,InsertDate:1,InsertUserId:1,IsActive:1,IsRectified:1,OCRData1Key:1,OCRData1Value:1,OCRData2Key:1,OCRData2Value:1,OCRData3Key:1,OCRData3Value:1,ResultProcessed:1,ScannedAt:1,ScannedBatchDescription:1,ScannedBatchId:1,ScannedBatchInsertDate:1,ScannedBatchInsertUserId:1,ScannedBatchIsActive:1,ScannedBatchName:1,ScannedBatchTenantId:1,ScannedBatchUpdateDate:1,ScannedBatchUpdateUserId:1,ScannedComments:1,ScannedExamNo:1,ScannedImage:1,ScannedImageSourcePath:1,ScannedRollNo:1,ScannedStatus:1,ScannedSystemErrors:1,ScannedUserErrors:1,SheetNumber:1,SheetTypeDescription:1,SheetTypeEPaperSize:1,SheetTypeHeightInPixel:1,SheetTypeId:1,SheetTypeInsertDate:1,SheetTypeInsertUserId:1,SheetTypeIsActive:1,SheetTypeIsPrivate:1,SheetTypeName:1,SheetTypeOverlayImage:1,SheetTypePdfTemplate:1,SheetTypeSheetData:1,SheetTypeSheetImage:1,SheetTypeSheetNumber:1,SheetTypeSynced:1,SheetTypeTotalQuestions:1,SheetTypeUpdateDate:1,SheetTypeUpdateUserId:1,SheetTypeWidthInPixel:1,TenantId:1,UpdateDate:1,UpdateUserId:1},KeyGenAs:{EStatus:1,ExamListDescription:1,ExamListId:1,ExamListInsertDate:1,ExamListInsertUserId:1,ExamListIsActive:1,ExamListName:1,ExamListTenantId:1,ExamListUpdateDate:1,ExamListUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Note:1,Quantity:1,UpdateDate:1,UpdateUserId:1,ValidDate:1,ValidityInDays:1,ValidityType:1},PreDefinedKey:{EStatus:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,SerialKey:1,UpdateDate:1,UpdateUserId:1},RuleType:{Description:1,Id:1,Name:1},ScannedBatch:{Description:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,ScannedQuestions:1,ScannedSheets:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ScannedQuestion:{CorrectedOptions:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,QuestionIndex:1,ScannedBatchId:1,ScannedOptions:1,ScannedSheetCorrectedExamNo:1,ScannedSheetCorrectedRollNo:1,ScannedSheetExamSetNo:1,ScannedSheetId:1,ScannedSheetImageBase64:1,ScannedSheetInsertDate:1,ScannedSheetInsertUserId:1,ScannedSheetIsActive:1,ScannedSheetOCRData1Key:1,ScannedSheetOCRData1Value:1,ScannedSheetResultProcessed:1,ScannedSheetScannedAt:1,ScannedSheetScannedBatchId:1,ScannedSheetScannedComments:1,ScannedSheetScannedExamNo:1,ScannedSheetScannedImage:1,ScannedSheetScannedImageSourcePath:1,ScannedSheetScannedRollNo:1,ScannedSheetScannedStatus:1,ScannedSheetScannedSystemErrors:1,ScannedSheetScannedUserErrors:1,ScannedSheetSheetNumber:1,ScannedSheetSheetTypeId:1,ScannedSheetTenantId:1,ScannedSheetUpdateDate:1,ScannedSheetUpdateUserId:1,TenantId:1,UpdateDate:1,UpdateUserId:1},ScannedSheet:{CorrectedExamNo:1,CorrectedRollNo:1,ExamSetNo:1,ICRData1Key:1,ICRData1Value:1,ICRData2Key:1,ICRData2Value:1,ICRData3Key:1,ICRData3Value:1,Id:1,ImageBase64:1,InsertDate:1,InsertUserId:1,IsActive:1,IsRectified:1,OCRData1Key:1,OCRData1Value:1,OCRData2Key:1,OCRData2Value:1,OCRData3Key:1,OCRData3Value:1,ResultProcessed:1,ScannedAt:1,ScannedBatchDescription:1,ScannedBatchId:1,ScannedBatchInsertDate:1,ScannedBatchInsertUserId:1,ScannedBatchIsActive:1,ScannedBatchName:1,ScannedBatchTenantId:1,ScannedBatchUpdateDate:1,ScannedBatchUpdateUserId:1,ScannedComments:1,ScannedExamNo:1,ScannedImage:1,ScannedImageSourcePath:1,ScannedQuestions:1,ScannedRollNo:1,ScannedSheetDisplayName:1,ScannedStatus:1,ScannedSystemErrors:1,ScannedUserErrors:1,SheetNumber:1,SheetTypeDescription:1,SheetTypeEPaperSize:1,SheetTypeHeightInPixel:1,SheetTypeId:1,SheetTypeInsertDate:1,SheetTypeInsertUserId:1,SheetTypeIsActive:1,SheetTypeIsPrivate:1,SheetTypeName:1,SheetTypeOverlayImage:1,SheetTypePdfTemplate:1,SheetTypeSheetData:1,SheetTypeSheetImage:1,SheetTypeSheetNumber:1,SheetTypeSynced:1,SheetTypeTotalQuestions:1,SheetTypeUpdateDate:1,SheetTypeUpdateUserId:1,SheetTypeWidthInPixel:1,TenantId:1,UpdateDate:1,UpdateUserId:1},SelectSheetType:{Description:1,EPaperSize:1,HeightInPixel:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,IsPrivate:1,Name:1,OverlayImage:1,PdfTemplate:1,SheetData:1,SheetImage:1,SheetNumber:1,Synced:1,TotalQuestions:1,UpdateDate:1,UpdateUserId:1,WidthInPixel:1},SerialKey:{EStatus:1,ExamListDescription:1,ExamListId:1,ExamListInsertDate:1,ExamListInsertUserId:1,ExamListIsActive:1,ExamListName:1,ExamListTenantId:1,ExamListUpdateDate:1,ExamListUpdateUserId:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,KeyGenAsId:1,Note:1,SerialKey:1,TenantId:1,UpdateDate:1,UpdateUserId:1,ValidDate:1,ValidityInDays:1,ValidityType:1},Settings:{ApiKey:1,From:1,GatewayUrl:1,Host:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Password:1,Port:1,Sender:1,TenantId:1,UpdateDate:1,UpdateUserId:1,UseSsl:1,UseXOAUTH2:1,UserName:1},SheetType:{Description:1,EPaperSize:1,HeightInPixel:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,IsPrivate:1,IsPublic:1,Name:1,OverlayImage:1,OverlayImageOpenCV:1,PdfTemplate:1,SheetData:1,SheetImage:1,SheetNumber:1,SheetTypeDisplayName:1,Synced:1,TotalQuestions:1,UpdateDate:1,UpdateUserId:1,WidthInPixel:1},SheetTypeTenant:{DisplayOrder:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,IsDefault:1,RowIds:1,SheetDesignPdf:1,SheetTypeDescription:1,SheetTypeDisplayName:1,SheetTypeEPaperSize:1,SheetTypeHeightInPixel:1,SheetTypeId:1,SheetTypeInsertDate:1,SheetTypeInsertUserId:1,SheetTypeIsActive:1,SheetTypeIsPrivate:1,SheetTypeName:1,SheetTypeOverlayImage:1,SheetTypePdfTemplate:1,SheetTypeSheetData:1,SheetTypeSheetImage:1,SheetTypeSheetNumber:1,SheetTypeSynced:1,SheetTypeTotalQuestions:1,SheetTypeUpdateDate:1,SheetTypeUpdateUserId:1,SheetTypeWidthInPixel:1,TenantId:1,TenantTenantName:1,UpdateDate:1,UpdateUserId:1},Student:{Comments:1,Dob:1,Email:1,FirstName:1,FullName:1,Gender:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,LastName:1,MiddleName:1,Mobile:1,Note:1,RollNo:1,SelectedTenant:1,StudentId:1,TenantId:1,TenantName:1,UpdateDate:1,UpdateUserId:1},Teachers:{Address:1,AllowedIps:1,City:1,Dob:1,Email:1,FirstName:1,FullName:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,LastName:1,MiddleName:1,Mobile:1,SchoolOrInstitute:1,TenantId:1,UpdateDate:1,UpdateUserId:1,UserId:1},TheoryExamQuestions:{DisplayIndex:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,MaxMarks:1,QuestionIndex:1,Tags:1,TenantId:1,TheoryExamCode:1,TheoryExamDescription:1,TheoryExamId:1,TheoryExamInsertDate:1,TheoryExamInsertUserId:1,TheoryExamIsActive:1,TheoryExamName:1,TheoryExamSectionDescription:1,TheoryExamSectionId:1,TheoryExamSectionInsertDate:1,TheoryExamSectionInsertUserId:1,TheoryExamSectionIsActive:1,TheoryExamSectionName:1,TheoryExamSectionParentId:1,TheoryExamSectionSortOrder:1,TheoryExamSectionTenantId:1,TheoryExamSectionTheoryExamId:1,TheoryExamSectionUpdateDate:1,TheoryExamSectionUpdateUserId:1,TheoryExamTenantId:1,TheoryExamTotalMarks:1,TheoryExamUpdateDate:1,TheoryExamUpdateUserId:1,UpdateDate:1,UpdateUserId:1},TheoryExamResultQuestions:{AttemptStatus:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,MarksObtained:1,OutOfMarks:1,TenantId:1,TheoryExamQuestionDisplayIndex:1,TheoryExamQuestionId:1,TheoryExamQuestionInsertDate:1,TheoryExamQuestionInsertUserId:1,TheoryExamQuestionIsActive:1,TheoryExamQuestionMaxMarks:1,TheoryExamQuestionQuestionIndex:1,TheoryExamQuestionTags:1,TheoryExamQuestionTenantId:1,TheoryExamQuestionTheoryExamId:1,TheoryExamQuestionTheoryExamSectionId:1,TheoryExamQuestionUpdateDate:1,TheoryExamQuestionUpdateUserId:1,TheoryExamResultAttemptDate:1,TheoryExamResultId:1,TheoryExamResultInsertDate:1,TheoryExamResultInsertUserId:1,TheoryExamResultIsActive:1,TheoryExamResultMarksScored:1,TheoryExamResultOutOfMarks:1,TheoryExamResultResultStatus:1,TheoryExamResultRollNumber:1,TheoryExamResultSheetImage:1,TheoryExamResultStudentId:1,TheoryExamResultStudentScanId:1,TheoryExamResultTenantId:1,TheoryExamResultTheoryExamId:1,TheoryExamResultUpdateDate:1,TheoryExamResultUpdateUserId:1,UpdateDate:1,UpdateUserId:1},TheoryExamResults:{AttemptDate:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,MarksScored:1,OutOfMarks:1,ResultStatus:1,RollNumber:1,SheetImage:1,StudentDob:1,StudentEmail:1,StudentFirstName:1,StudentFullName:1,StudentGender:1,StudentId:1,StudentInsertDate:1,StudentInsertUserId:1,StudentIsActive:1,StudentLastName:1,StudentMiddleName:1,StudentMobile:1,StudentNote:1,StudentRollNo:1,StudentScanId:1,StudentTenantId:1,StudentUpdateDate:1,StudentUpdateUserId:1,TenantId:1,TheoryExamCode:1,TheoryExamDescription:1,TheoryExamId:1,TheoryExamInsertDate:1,TheoryExamInsertUserId:1,TheoryExamIsActive:1,TheoryExamName:1,TheoryExamResultQuestions:1,TheoryExamTenantId:1,TheoryExamTotalMarks:1,TheoryExamUpdateDate:1,TheoryExamUpdateUserId:1,UpdateDate:1,UpdateUserId:1},TheoryExamSections:{Description:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,ParentDescription:1,ParentId:1,ParentInsertDate:1,ParentInsertUserId:1,ParentIsActive:1,ParentName:1,ParentParentId:1,ParentSortOrder:1,ParentTenantId:1,ParentTheoryExamId:1,ParentUpdateDate:1,ParentUpdateUserId:1,SortOrder:1,TenantId:1,TheoryExamCode:1,TheoryExamDescription:1,TheoryExamId:1,TheoryExamInsertDate:1,TheoryExamInsertUserId:1,TheoryExamIsActive:1,TheoryExamName:1,TheoryExamTenantId:1,TheoryExamTotalMarks:1,TheoryExamUpdateDate:1,TheoryExamUpdateUserId:1,UpdateDate:1,UpdateUserId:1},TheoryExams:{Code:1,Description:1,ExamQuestions:1,ExamSections:1,Id:1,InsertDate:1,InsertUserId:1,IsActive:1,Name:1,RowIds:1,TenantId:1,TotalMarks:1,UpdateDate:1,UpdateUserId:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{BackToLogin:1,FormInfo:1,FormTitle:1,SubmitButton:1,Success:1},Login:{FacebookButton:1,ForgotPassword:1,GoogleButton:1,LoginToYourAccount:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{BackToLogin:1,EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{AcceptTerms:1,ActivateEmailSubject:1,ActivationCompleteMessage:1,BackToLogin:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}}},Navigation:{LogoutLink:1,SiteTitle:1},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},BasicProgressDialog:{CancelTitle:1,PleaseWait:1},BulkServiceAction:{AllHadErrorsFormat:1,AllSuccessFormat:1,ConfirmationFormat:1,ErrorCount:1,NothingToProcess:1,SomeHadErrorsFormat:1,SuccessCount:1},Dashboard:{ContentDescription:1},Dialogs:{PendingChangesConfirmation:1},Layout:{FooterCopyright:1,FooterInfo:1,FooterRights:1,GeneralSettings:1,Language:1,Theme:1,ThemeAzure:1,ThemeAzureLight:1,ThemeBlack:1,ThemeBlackLight:1,ThemeBlue:1,ThemeBlueLight:1,ThemeCosmos:1,ThemeCosmosLight:1,ThemeGlassy:1,ThemeGlassyLight:1,ThemeGreen:1,ThemeGreenLight:1,ThemePurple:1,ThemePurpleLight:1,ThemeRed:1,ThemeRedLight:1,ThemeYellow:1,ThemeYellowLight:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},UserRoleDialog:{DialogTitle:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CantFindUserWithEmail:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,SavePrimaryKeyError:1}}) as any;
}

export const Texts = Rio.Texts;
