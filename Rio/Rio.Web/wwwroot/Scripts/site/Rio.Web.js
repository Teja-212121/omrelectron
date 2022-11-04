var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        class LanguageColumns {
        }
        LanguageColumns.columnsKey = 'Administration.Language';
        Administration.LanguageColumns = LanguageColumns;
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        class LanguageForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!LanguageForm.init) {
                    LanguageForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    Q.initFormType(LanguageForm, [
                        'LanguageId', w0,
                        'LanguageName', w0
                    ]);
                }
            }
        }
        LanguageForm.formKey = 'Administration.Language';
        Administration.LanguageForm = LanguageForm;
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let LanguageRow;
        (function (LanguageRow) {
            LanguageRow.idProperty = 'Id';
            LanguageRow.nameProperty = 'LanguageName';
            LanguageRow.localTextPrefix = 'Administration.Language';
            LanguageRow.lookupKey = 'Administration.Language';
            function getLookup() {
                return Q.getLookup('Administration.Language');
            }
            LanguageRow.getLookup = getLookup;
            LanguageRow.deletePermission = 'Administration:Translation';
            LanguageRow.insertPermission = 'Administration:Translation';
            LanguageRow.readPermission = 'Administration:Translation';
            LanguageRow.updatePermission = 'Administration:Translation';
        })(LanguageRow = Administration.LanguageRow || (Administration.LanguageRow = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let LanguageService;
        (function (LanguageService) {
            LanguageService.baseUrl = 'Administration/Language';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(x => {
                LanguageService[x] = function (r, s, o) {
                    return Q.serviceRequest(LanguageService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(LanguageService = Administration.LanguageService || (Administration.LanguageService = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let PermissionKeys;
        (function (PermissionKeys) {
            PermissionKeys.Security = "Administration:Security";
            PermissionKeys.Translation = "Administration:Translation";
            PermissionKeys.Tenants = "Administration:Tenants";
        })(PermissionKeys = Administration.PermissionKeys || (Administration.PermissionKeys = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        class RoleColumns {
        }
        RoleColumns.columnsKey = 'Administration.Role';
        Administration.RoleColumns = RoleColumns;
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        class RoleForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!RoleForm.init) {
                    RoleForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    Q.initFormType(RoleForm, [
                        'RoleName', w0,
                        'RoleKey', w0
                    ]);
                }
            }
        }
        RoleForm.formKey = 'Administration.Role';
        Administration.RoleForm = RoleForm;
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let RolePermissionRow;
        (function (RolePermissionRow) {
            RolePermissionRow.idProperty = 'RolePermissionId';
            RolePermissionRow.nameProperty = 'PermissionKey';
            RolePermissionRow.localTextPrefix = 'Administration.RolePermission';
            RolePermissionRow.deletePermission = 'Administration:Security';
            RolePermissionRow.insertPermission = 'Administration:Security';
            RolePermissionRow.readPermission = 'Administration:Security';
            RolePermissionRow.updatePermission = 'Administration:Security';
        })(RolePermissionRow = Administration.RolePermissionRow || (Administration.RolePermissionRow = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let RolePermissionService;
        (function (RolePermissionService) {
            RolePermissionService.baseUrl = 'Administration/RolePermission';
            [
                'Update',
                'List'
            ].forEach(x => {
                RolePermissionService[x] = function (r, s, o) {
                    return Q.serviceRequest(RolePermissionService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(RolePermissionService = Administration.RolePermissionService || (Administration.RolePermissionService = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let RoleRow;
        (function (RoleRow) {
            RoleRow.idProperty = 'RoleId';
            RoleRow.nameProperty = 'RoleName';
            RoleRow.localTextPrefix = 'Administration.Role';
            RoleRow.lookupKey = 'Administration.Role';
            function getLookup() {
                return Q.getLookup('Administration.Role');
            }
            RoleRow.getLookup = getLookup;
            RoleRow.deletePermission = 'Administration:Security';
            RoleRow.insertPermission = 'Administration:Security';
            RoleRow.readPermission = 'Administration:Security';
            RoleRow.updatePermission = 'Administration:Security';
        })(RoleRow = Administration.RoleRow || (Administration.RoleRow = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let RoleService;
        (function (RoleService) {
            RoleService.baseUrl = 'Administration/Role';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(x => {
                RoleService[x] = function (r, s, o) {
                    return Q.serviceRequest(RoleService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(RoleService = Administration.RoleService || (Administration.RoleService = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        class TenantColumns {
        }
        TenantColumns.columnsKey = 'Administration.Tenant';
        Administration.TenantColumns = TenantColumns;
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        class TenantForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!TenantForm.init) {
                    TenantForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    Q.initFormType(TenantForm, [
                        'TenantName', w0
                    ]);
                }
            }
        }
        TenantForm.formKey = 'Administration.Tenant';
        Administration.TenantForm = TenantForm;
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let TenantRow;
        (function (TenantRow) {
            TenantRow.idProperty = 'TenantId';
            TenantRow.nameProperty = 'TenantName';
            TenantRow.localTextPrefix = 'Administration.Tenant';
            TenantRow.lookupKey = 'Administration.Tenant';
            function getLookup() {
                return Q.getLookup('Administration.Tenant');
            }
            TenantRow.getLookup = getLookup;
            TenantRow.deletePermission = 'Administration:Tenants';
            TenantRow.insertPermission = 'Administration:Tenants';
            TenantRow.readPermission = 'Administration:Tenants';
            TenantRow.updatePermission = 'Administration:Tenants';
        })(TenantRow = Administration.TenantRow || (Administration.TenantRow = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let TenantService;
        (function (TenantService) {
            TenantService.baseUrl = 'Administration/Tenant';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(x => {
                TenantService[x] = function (r, s, o) {
                    return Q.serviceRequest(TenantService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(TenantService = Administration.TenantService || (Administration.TenantService = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let TranslationService;
        (function (TranslationService) {
            TranslationService.baseUrl = 'Administration/Translation';
            [
                'List',
                'Update'
            ].forEach(x => {
                TranslationService[x] = function (r, s, o) {
                    return Q.serviceRequest(TranslationService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(TranslationService = Administration.TranslationService || (Administration.TranslationService = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let TwoFactorAuthType;
        (function (TwoFactorAuthType) {
            TwoFactorAuthType[TwoFactorAuthType["Email"] = 1] = "Email";
            TwoFactorAuthType[TwoFactorAuthType["SMS"] = 2] = "SMS";
        })(TwoFactorAuthType = Administration.TwoFactorAuthType || (Administration.TwoFactorAuthType = {}));
        Serenity.Decorators.registerEnumType(TwoFactorAuthType, 'Rio.Administration.TwoFactorAuthType');
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        class UserColumns {
        }
        UserColumns.columnsKey = 'Administration.User';
        Administration.UserColumns = UserColumns;
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        class UserForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!UserForm.init) {
                    UserForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.EmailAddressEditor;
                    var w2 = s.LookupEditor;
                    var w3 = s.BooleanEditor;
                    var w4 = s.EnumEditor;
                    var w5 = s.ImageUploadEditor;
                    var w6 = s.PasswordEditor;
                    Q.initFormType(UserForm, [
                        'Username', w0,
                        'DisplayName', w0,
                        'Email', w1,
                        'Roles', w2,
                        'MobilePhoneNumber', w0,
                        'MobilePhoneVerified', w3,
                        'TwoFactorAuth', w4,
                        'UserImage', w5,
                        'Password', w6,
                        'PasswordConfirm', w6,
                        'Source', w0,
                        'TenantId', w2
                    ]);
                }
            }
        }
        UserForm.formKey = 'Administration.User';
        Administration.UserForm = UserForm;
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let UserPermissionRow;
        (function (UserPermissionRow) {
            UserPermissionRow.idProperty = 'UserPermissionId';
            UserPermissionRow.nameProperty = 'PermissionKey';
            UserPermissionRow.localTextPrefix = 'Administration.UserPermission';
            UserPermissionRow.deletePermission = 'Administration:Security';
            UserPermissionRow.insertPermission = 'Administration:Security';
            UserPermissionRow.readPermission = 'Administration:Security';
            UserPermissionRow.updatePermission = 'Administration:Security';
        })(UserPermissionRow = Administration.UserPermissionRow || (Administration.UserPermissionRow = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let UserPermissionService;
        (function (UserPermissionService) {
            UserPermissionService.baseUrl = 'Administration/UserPermission';
            [
                'Update',
                'List',
                'ListRolePermissions',
                'ListPermissionKeys'
            ].forEach(x => {
                UserPermissionService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserPermissionService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(UserPermissionService = Administration.UserPermissionService || (Administration.UserPermissionService = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let UserRoleRow;
        (function (UserRoleRow) {
            UserRoleRow.idProperty = 'UserRoleId';
            UserRoleRow.localTextPrefix = 'Administration.UserRole';
            UserRoleRow.deletePermission = 'Administration:Security';
            UserRoleRow.insertPermission = 'Administration:Security';
            UserRoleRow.readPermission = 'Administration:Security';
            UserRoleRow.updatePermission = 'Administration:Security';
        })(UserRoleRow = Administration.UserRoleRow || (Administration.UserRoleRow = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let UserRoleService;
        (function (UserRoleService) {
            UserRoleService.baseUrl = 'Administration/UserRole';
            [
                'Update',
                'List'
            ].forEach(x => {
                UserRoleService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserRoleService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(UserRoleService = Administration.UserRoleService || (Administration.UserRoleService = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let UserRow;
        (function (UserRow) {
            UserRow.idProperty = 'UserId';
            UserRow.isActiveProperty = 'IsActive';
            UserRow.nameProperty = 'Username';
            UserRow.localTextPrefix = 'Administration.User';
            UserRow.lookupKey = 'Administration.User';
            function getLookup() {
                return Q.getLookup('Administration.User');
            }
            UserRow.getLookup = getLookup;
            UserRow.deletePermission = 'Administration:Security';
            UserRow.insertPermission = 'Administration:Security';
            UserRow.readPermission = 'Administration:Security';
            UserRow.updatePermission = 'Administration:Security';
        })(UserRow = Administration.UserRow || (Administration.UserRow = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Administration;
    (function (Administration) {
        let UserService;
        (function (UserService) {
            UserService.baseUrl = 'Administration/User';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(x => {
                UserService[x] = function (r, s, o) {
                    return Q.serviceRequest(UserService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(UserService = Administration.UserService || (Administration.UserService = {}));
    })(Administration = Rio.Administration || (Rio.Administration = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        class ChangePasswordForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!ChangePasswordForm.init) {
                    ChangePasswordForm.init = true;
                    var s = Serenity;
                    var w0 = s.PasswordEditor;
                    Q.initFormType(ChangePasswordForm, [
                        'OldPassword', w0,
                        'NewPassword', w0,
                        'ConfirmPassword', w0
                    ]);
                }
            }
        }
        ChangePasswordForm.formKey = 'Membership.ChangePassword';
        Membership.ChangePasswordForm = ChangePasswordForm;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        class ForgotPasswordForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!ForgotPasswordForm.init) {
                    ForgotPasswordForm.init = true;
                    var s = Serenity;
                    var w0 = s.EmailAddressEditor;
                    Q.initFormType(ForgotPasswordForm, [
                        'Email', w0
                    ]);
                }
            }
        }
        ForgotPasswordForm.formKey = 'Membership.ForgotPassword';
        Membership.ForgotPasswordForm = ForgotPasswordForm;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        class LoginForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!LoginForm.init) {
                    LoginForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.PasswordEditor;
                    Q.initFormType(LoginForm, [
                        'Username', w0,
                        'Password', w1
                    ]);
                }
            }
        }
        LoginForm.formKey = 'Membership.Login';
        Membership.LoginForm = LoginForm;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        class ResetPasswordForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!ResetPasswordForm.init) {
                    ResetPasswordForm.init = true;
                    var s = Serenity;
                    var w0 = s.PasswordEditor;
                    Q.initFormType(ResetPasswordForm, [
                        'NewPassword', w0,
                        'ConfirmPassword', w0
                    ]);
                }
            }
        }
        ResetPasswordForm.formKey = 'Membership.ResetPassword';
        Membership.ResetPasswordForm = ResetPasswordForm;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        class SignUpForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!SignUpForm.init) {
                    SignUpForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.EmailAddressEditor;
                    var w2 = s.PasswordEditor;
                    Q.initFormType(SignUpForm, [
                        'DisplayName', w0,
                        'Email', w1,
                        'ConfirmEmail', w1,
                        'Password', w2,
                        'ConfirmPassword', w2
                    ]);
                }
            }
        }
        SignUpForm.formKey = 'Membership.SignUp';
        Membership.SignUpForm = SignUpForm;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Texts;
    (function (Texts) {
        Rio['Texts'] = Q.proxyTexts(Texts, '', { Db: { Administration: { Language: { Id: 1, LanguageId: 1, LanguageName: 1 }, Role: { RoleId: 1, RoleKey: 1, RoleName: 1, TenantId: 1 }, RolePermission: { PermissionKey: 1, RoleId: 1, RolePermissionId: 1, RoleRoleName: 1 }, Tenant: { TenantId: 1, TenantName: 1 }, Translation: { CustomText: 1, EntityPlural: 1, Key: 1, OverrideConfirmation: 1, SaveChangesButton: 1, SourceLanguage: 1, SourceText: 1, TargetLanguage: 1, TargetText: 1 }, User: { DisplayName: 1, Email: 1, ImpersonationToken: 1, InsertDate: 1, InsertUserId: 1, IsActive: 1, LastDirectoryUpdate: 1, MobilePhoneNumber: 1, MobilePhoneVerified: 1, Password: 1, PasswordConfirm: 1, PasswordHash: 1, PasswordSalt: 1, Roles: 1, Source: 1, TenantId: 1, TenantName: 1, TwoFactorAuth: 1, UpdateDate: 1, UpdateUserId: 1, UserId: 1, UserImage: 1, Username: 1 }, UserPermission: { Granted: 1, PermissionKey: 1, User: 1, UserId: 1, UserPermissionId: 1, Username: 1 }, UserRole: { RoleId: 1, User: 1, UserId: 1, UserRoleId: 1, Username: 1 } }, Workspace: { Exam: { Code: 1, Description: 1, Id: 1, InsertDate: 1, InsertUserId: 1, IsActive: 1, Name: 1, NegativeMarks: 1, OptionsAvailable: 1, ResultCriteria: 1, TenantId: 1, TotalMarks: 1, UpdateDate: 1, UpdateUserId: 1 }, Group: { Description: 1, Id: 1, InsertDate: 1, InsertUserId: 1, IsActive: 1, Name: 1, ParentDescription: 1, ParentId: 1, ParentInsertDate: 1, ParentInsertUserId: 1, ParentIsActive: 1, ParentName: 1, ParentParentId: 1, ParentTenantId: 1, ParentUpdateDate: 1, ParentUpdateUserId: 1, TenantId: 1, UpdateDate: 1, UpdateUserId: 1 }, SheetType: { Description: 1, EPaperSize: 1, HeightInPixel: 1, Id: 1, InsertDate: 1, InsertUserId: 1, IsActive: 1, IsPrivate: 1, Name: 1, OverlayImage: 1, PdfTemplate: 1, SheetData: 1, SheetImage: 1, SheetNumber: 1, Synced: 1, TotalQuestions: 1, UpdateDate: 1, UpdateUserId: 1, WidthInPixel: 1 } } }, Forms: { Membership: { ChangePassword: { FormTitle: 1, SubmitButton: 1, Success: 1 }, ForgotPassword: { BackToLogin: 1, FormInfo: 1, FormTitle: 1, SubmitButton: 1, Success: 1 }, Login: { FacebookButton: 1, ForgotPassword: 1, GoogleButton: 1, LoginToYourAccount: 1, OR: 1, RememberMe: 1, SignInButton: 1, SignUpButton: 1 }, ResetPassword: { BackToLogin: 1, EmailSubject: 1, FormTitle: 1, SubmitButton: 1, Success: 1 }, SignUp: { AcceptTerms: 1, ActivateEmailSubject: 1, ActivationCompleteMessage: 1, BackToLogin: 1, ConfirmEmail: 1, ConfirmPassword: 1, DisplayName: 1, Email: 1, FormInfo: 1, FormTitle: 1, Password: 1, SubmitButton: 1, Success: 1 } } }, Navigation: { LogoutLink: 1, SiteTitle: 1 }, Site: { AccessDenied: { ClickToChangeUser: 1, ClickToLogin: 1, LackPermissions: 1, NotLoggedIn: 1, PageTitle: 1 }, BasicProgressDialog: { CancelTitle: 1, PleaseWait: 1 }, BulkServiceAction: { AllHadErrorsFormat: 1, AllSuccessFormat: 1, ConfirmationFormat: 1, ErrorCount: 1, NothingToProcess: 1, SomeHadErrorsFormat: 1, SuccessCount: 1 }, Dashboard: { ContentDescription: 1 }, Dialogs: { PendingChangesConfirmation: 1 }, Layout: { FooterCopyright: 1, FooterInfo: 1, FooterRights: 1, GeneralSettings: 1, Language: 1, Theme: 1, ThemeAzure: 1, ThemeAzureLight: 1, ThemeBlack: 1, ThemeBlackLight: 1, ThemeBlue: 1, ThemeBlueLight: 1, ThemeCosmos: 1, ThemeCosmosLight: 1, ThemeGlassy: 1, ThemeGlassyLight: 1, ThemeGreen: 1, ThemeGreenLight: 1, ThemePurple: 1, ThemePurpleLight: 1, ThemeRed: 1, ThemeRedLight: 1, ThemeYellow: 1, ThemeYellowLight: 1 }, RolePermissionDialog: { DialogTitle: 1, EditButton: 1, SaveSuccess: 1 }, UserDialog: { EditPermissionsButton: 1, EditRolesButton: 1 }, UserPermissionDialog: { DialogTitle: 1, Grant: 1, Permission: 1, Revoke: 1, SaveSuccess: 1 }, UserRoleDialog: { DialogTitle: 1, SaveSuccess: 1 }, ValidationError: { Title: 1 } }, Validation: { AuthenticationError: 1, CantFindUserWithEmail: 1, CurrentPasswordMismatch: 1, DeleteForeignKeyError: 1, EmailConfirm: 1, EmailInUse: 1, InvalidActivateToken: 1, InvalidResetToken: 1, MinRequiredPasswordLength: 1, SavePrimaryKeyError: 1 } });
    })(Texts = Rio.Texts || (Rio.Texts = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        class ExamColumns {
        }
        ExamColumns.columnsKey = 'Workspace.Exam';
        Workspace.ExamColumns = ExamColumns;
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        class ExamForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!ExamForm.init) {
                    ExamForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.DecimalEditor;
                    var w3 = s.DateEditor;
                    Q.initFormType(ExamForm, [
                        'Code', w0,
                        'Name', w0,
                        'Description', w0,
                        'TotalMarks', w1,
                        'NegativeMarks', w2,
                        'OptionsAvailable', w1,
                        'ResultCriteria', w0,
                        'InsertDate', w3,
                        'InsertUserId', w1,
                        'UpdateDate', w3,
                        'UpdateUserId', w1,
                        'IsActive', w1,
                        'TenantId', w1
                    ]);
                }
            }
        }
        ExamForm.formKey = 'Workspace.Exam';
        Workspace.ExamForm = ExamForm;
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        let ExamRow;
        (function (ExamRow) {
            ExamRow.idProperty = 'Id';
            ExamRow.nameProperty = 'Code';
            ExamRow.localTextPrefix = 'Workspace.Exam';
            ExamRow.deletePermission = 'Administration:General';
            ExamRow.insertPermission = 'Administration:General';
            ExamRow.readPermission = 'Administration:General';
            ExamRow.updatePermission = 'Administration:General';
        })(ExamRow = Workspace.ExamRow || (Workspace.ExamRow = {}));
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        let ExamService;
        (function (ExamService) {
            ExamService.baseUrl = 'Workspace/Exam';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(x => {
                ExamService[x] = function (r, s, o) {
                    return Q.serviceRequest(ExamService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(ExamService = Workspace.ExamService || (Workspace.ExamService = {}));
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        class GroupColumns {
        }
        GroupColumns.columnsKey = 'Workspace.Group';
        Workspace.GroupColumns = GroupColumns;
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        class GroupForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!GroupForm.init) {
                    GroupForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.DateEditor;
                    Q.initFormType(GroupForm, [
                        'Name', w0,
                        'Description', w0,
                        'ParentId', w1,
                        'InsertDate', w2,
                        'InsertUserId', w1,
                        'UpdateDate', w2,
                        'UpdateUserId', w1,
                        'IsActive', w1,
                        'TenantId', w1
                    ]);
                }
            }
        }
        GroupForm.formKey = 'Workspace.Group';
        Workspace.GroupForm = GroupForm;
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        let GroupRow;
        (function (GroupRow) {
            GroupRow.idProperty = 'Id';
            GroupRow.nameProperty = 'Name';
            GroupRow.localTextPrefix = 'Workspace.Group';
            GroupRow.deletePermission = 'Administration:General';
            GroupRow.insertPermission = 'Administration:General';
            GroupRow.readPermission = 'Administration:General';
            GroupRow.updatePermission = 'Administration:General';
        })(GroupRow = Workspace.GroupRow || (Workspace.GroupRow = {}));
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        let GroupService;
        (function (GroupService) {
            GroupService.baseUrl = 'Workspace/Group';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(x => {
                GroupService[x] = function (r, s, o) {
                    return Q.serviceRequest(GroupService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(GroupService = Workspace.GroupService || (Workspace.GroupService = {}));
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        class SheetTypeColumns {
        }
        SheetTypeColumns.columnsKey = 'Workspace.SheetType';
        Workspace.SheetTypeColumns = SheetTypeColumns;
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        class SheetTypeForm extends Serenity.PrefixedContext {
            constructor(prefix) {
                super(prefix);
                if (!SheetTypeForm.init) {
                    SheetTypeForm.init = true;
                    var s = Serenity;
                    var w0 = s.StringEditor;
                    var w1 = s.IntegerEditor;
                    var w2 = s.BooleanEditor;
                    var w3 = s.DateEditor;
                    Q.initFormType(SheetTypeForm, [
                        'Name', w0,
                        'Description', w0,
                        'TotalQuestions', w1,
                        'EPaperSize', w1,
                        'HeightInPixel', w1,
                        'WidthInPixel', w1,
                        'SheetData', w0,
                        'SheetImage', w0,
                        'OverlayImage', w0,
                        'Synced', w2,
                        'IsPrivate', w2,
                        'PdfTemplate', w0,
                        'SheetNumber', w0,
                        'InsertDate', w3,
                        'InsertUserId', w1,
                        'UpdateDate', w3,
                        'UpdateUserId', w1,
                        'IsActive', w1
                    ]);
                }
            }
        }
        SheetTypeForm.formKey = 'Workspace.SheetType';
        Workspace.SheetTypeForm = SheetTypeForm;
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        let SheetTypeRow;
        (function (SheetTypeRow) {
            SheetTypeRow.idProperty = 'Id';
            SheetTypeRow.nameProperty = 'Name';
            SheetTypeRow.localTextPrefix = 'Workspace.SheetType';
            SheetTypeRow.deletePermission = 'Administration:General';
            SheetTypeRow.insertPermission = 'Administration:General';
            SheetTypeRow.readPermission = 'Administration:General';
            SheetTypeRow.updatePermission = 'Administration:General';
        })(SheetTypeRow = Workspace.SheetTypeRow || (Workspace.SheetTypeRow = {}));
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Workspace;
    (function (Workspace) {
        let SheetTypeService;
        (function (SheetTypeService) {
            SheetTypeService.baseUrl = 'Workspace/SheetType';
            [
                'Create',
                'Update',
                'Delete',
                'Retrieve',
                'List'
            ].forEach(x => {
                SheetTypeService[x] = function (r, s, o) {
                    return Q.serviceRequest(SheetTypeService.baseUrl + '/' + x, r, s, o);
                };
            });
        })(SheetTypeService = Workspace.SheetTypeService || (Workspace.SheetTypeService = {}));
    })(Workspace = Rio.Workspace || (Rio.Workspace = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var LanguageList;
    (function (LanguageList) {
        function getValue() {
            var result = [];
            for (var k of Rio.Administration.LanguageRow.getLookup().items) {
                if (k.LanguageId !== 'en') {
                    result.push([k.Id.toString(), k.LanguageName]);
                }
            }
            return result;
        }
        LanguageList.getValue = getValue;
    })(LanguageList = Rio.LanguageList || (Rio.LanguageList = {}));
})(Rio || (Rio = {}));
/// <reference path="LanguageList.ts" />
var Rio;
(function (Rio) {
    var ScriptInitialization;
    (function (ScriptInitialization) {
        Q.Config.rootNamespaces.push('Rio');
        Serenity.EntityDialog.defaultLanguageList = Rio.LanguageList.getValue;
        Serenity.HtmlContentEditor.CKEditorBasePath = "~/Serenity.Assets/Scripts/ckeditor/";
        if ($.fn['colorbox']) {
            $.fn['colorbox'].settings.maxWidth = "95%";
            $.fn['colorbox'].settings.maxHeight = "95%";
        }
        Serenity.setupUIOverrides();
        window.onerror = Q.ErrorHandling.runtimeErrorHandler;
        $(() => {
            // let demo page use its own settings for idle timeout
            if (window.location.pathname.indexOf('Samples/IdleTimeout') > 0)
                return;
            var meta = $('meta[name=username]');
            if ((meta.length && meta.attr('content')) ||
                (!meta.length && Q.Authorization.isLoggedIn)) {
                new Serenity.IdleTimeout({
                    activityTimeout: 15 * 60,
                    warningDuration: 2 * 60
                });
            }
        });
    })(ScriptInitialization = Rio.ScriptInitialization || (Rio.ScriptInitialization = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        let ChangePasswordPanel = class ChangePasswordPanel extends Serenity.PropertyPanel {
            constructor(container) {
                super(container);
                this.form = new Membership.ChangePasswordForm(this.idPrefix);
                this.form.NewPassword.addValidationRule(this.uniqueName, e => {
                    if (this.form.w('ConfirmPassword', Serenity.PasswordEditor).value.length < 7) {
                        return Q.format(Rio.Texts.Validation.MinRequiredPasswordLength, 7);
                    }
                });
                this.form.ConfirmPassword.addValidationRule(this.uniqueName, e => {
                    if (this.form.ConfirmPassword.value !== this.form.NewPassword.value) {
                        return Q.text('Validation.PasswordConfirm');
                    }
                });
                this.byId('SubmitButton').click(e => {
                    e.preventDefault();
                    if (!this.validateForm()) {
                        return;
                    }
                    var request = this.getSaveEntity();
                    Q.serviceCall({
                        url: Q.resolveUrl('~/Account/ChangePassword'),
                        request: request,
                        onSuccess: () => {
                            Q.information(Rio.Texts.Forms.Membership.ChangePassword.Success, () => {
                                window.location.href = Q.resolveUrl('~/');
                            });
                        }
                    });
                });
            }
            getFormKey() { return Membership.ChangePasswordForm.formKey; }
            getTemplate() {
                return `<div class="s-Panel">
    <h3 class="page-title mb-4 text-center">${Q.text("Forms.Membership.ChangePassword.FormTitle")}</h3>
    <form id="~_Form" action="">
        <div id="~_PropertyGrid"></div>
        <div class="px-field mt-4">
            <button id="~_SubmitButton" type="submit" class="btn btn-primary w-100">
                ${Rio.Texts.Forms.Membership.ChangePassword.SubmitButton}
            </button>
        </div>
    </form>
</div>`;
            }
        };
        ChangePasswordPanel = __decorate([
            Serenity.Decorators.registerClass()
        ], ChangePasswordPanel);
        Membership.ChangePasswordPanel = ChangePasswordPanel;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        let ForgotPasswordPanel = class ForgotPasswordPanel extends Serenity.PropertyPanel {
            constructor(container) {
                super(container);
                this.form = new Membership.ForgotPasswordForm(this.idPrefix);
                this.byId('SubmitButton').click(e => {
                    e.preventDefault();
                    if (!this.validateForm()) {
                        return;
                    }
                    var request = this.getSaveEntity();
                    Q.serviceCall({
                        url: Q.resolveUrl('~/Account/ForgotPassword'),
                        request: request,
                        onSuccess: response => {
                            Q.information(Rio.Texts.Forms.Membership.ForgotPassword.Success, () => {
                                window.location.href = Q.resolveUrl('~/');
                            });
                        }
                    });
                });
            }
            getFormKey() { return Membership.ForgotPasswordForm.formKey; }
        };
        ForgotPasswordPanel = __decorate([
            Serenity.Decorators.registerClass()
        ], ForgotPasswordPanel);
        Membership.ForgotPasswordPanel = ForgotPasswordPanel;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        let LoginPanel = class LoginPanel extends Serenity.PropertyPanel {
            getFormKey() { return Membership.LoginForm.formKey; }
            constructor(container) {
                super(container);
                $.fn['vegas'] && $('body')['vegas']({
                    delay: 30000,
                    cover: true,
                    overlay: "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAIAAAACAQMAAABIeJ9nAAAAA3NCSVQICAjb4U" +
                        "/gAAAABlBMVEX///8AAABVwtN+AAAAAnRSTlMA/1uRIrUAAAAJcEhZcwAAAsQAAALEAVuRnQsAAAAWdEVYdENyZWF0" +
                        "aW9uIFRpbWUAMDQvMTMvMTGrW0T6AAAAHHRFWHRTb2Z0d2FyZQBBZG9iZSBGaXJld29ya3MgQ1M1cbXjNgAAAAxJREFUCJljaGBgAAABhACBrONIPgAAAABJRU5ErkJggg==",
                    slides: [
                        { src: Q.resolveUrl("~/Content/site/slides/slide1.jpg"), transition: 'fade' },
                        { src: Q.resolveUrl("~/Content/site/slides/slide2.jpg"), transition: 'zoomOut' },
                        { src: Q.resolveUrl("~/Content/site/slides/slide3.jpg"), transition: 'swirlLeft' }
                    ]
                });
                this.byId('LoginButton').click(e => {
                    e.preventDefault();
                    if (!this.validateForm()) {
                        return;
                    }
                    var request = this.getSaveEntity();
                    Q.serviceCall({
                        url: Q.resolveUrl('~/Account/Login'),
                        request: request,
                        onSuccess: response => {
                            this.redirectToReturnUrl();
                        },
                        onError: (response) => {
                            if (response != null && response.Error != null && response.Error.Code == "TwoFactorAuthenticationRequired") {
                                var args = response.Error.Arguments.split('|');
                                this.handleTwoFactorAuthentication(request.Username, request.Password, args[1], args[0]);
                                return;
                            }
                            if (response != null && response.Error != null && response.Error.Code == "RedirectUserTo") {
                                window.location.href = response.Error.Arguments;
                                return;
                            }
                            if (response != null && response.Error != null && !Q.isEmptyOrNull(response.Error.Message)) {
                                Q.notifyError(response.Error.Message);
                                $('#Password').focus();
                                return;
                            }
                            Q.ErrorHandling.showServiceError(response.Error);
                        }
                    });
                });
            }
            redirectToReturnUrl() {
                var q = Q.parseQueryString();
                var returnUrl = q['returnUrl'] || q['ReturnUrl'];
                if (returnUrl) {
                    var hash = window.location.hash;
                    if (hash != null && hash != '#')
                        returnUrl += hash;
                    window.location.href = returnUrl;
                }
                else {
                    window.location.href = Q.resolveUrl('~/');
                }
            }
            handleTwoFactorAuthentication(user, pass, twoFactorGuid, info) {
                var tries = 0;
                var remaining = 120;
                var dialog = null;
                var showDialog = () => {
                    dialog = new Serenity.Extensions.PromptDialog({
                        title: "Two Factor Authentication",
                        editorOptions: {
                            maxLength: 4,
                        },
                        editorType: "Integer",
                        message: info,
                        isHtml: true,
                        required: true,
                        validateValue: (x) => {
                            if (x >= 1000 && x <= 9999) {
                                tries++;
                                Q.serviceCall({
                                    url: Q.resolveUrl('~/Account/Login'),
                                    request: {
                                        Username: user,
                                        Password: pass,
                                        TwoFactorGuid: twoFactorGuid,
                                        TwoFactorCode: x
                                    },
                                    onSuccess: (r) => {
                                        this.redirectToReturnUrl();
                                        return;
                                    },
                                    onError: (z) => {
                                        Q.notifyError(z.Error.Message);
                                        if (tries > 2) {
                                            Q.notifyError("Code entered is invalid! You can't try more than 3 times!");
                                            dialog = null;
                                            return;
                                        }
                                        showDialog();
                                    }
                                });
                                return true;
                            }
                            Q.notifyError("Please enter a valid code!");
                            return false;
                        }
                    });
                    dialog.dialogOpen();
                    dialog.element.on("dialogclose.me", function (x) {
                        if (dialog != null) {
                            dialog.element.off("dialogclose.me");
                            dialog = null;
                        }
                    });
                };
                function updateCounter() {
                    remaining -= 1;
                    if (dialog != null) {
                        dialog.element.find("span.counter").text(remaining.toString());
                    }
                    if (remaining >= 0)
                        setTimeout(updateCounter, 1000);
                    else if (dialog != null)
                        dialog.dialogClose();
                }
                ;
                showDialog();
                window.setTimeout(updateCounter, 1000);
            }
            getTemplate() {
                return `
    <h2 class="text-center p-4">
        <img src="${Q.resolveUrl("~/Content/site/images/serenity-logo-w-128.png")}"
            class="rounded-circle p-1" style="background-color: var(--s-sidebar-band-bg)"
            width="50" height="50" /> omrapp
    </h2>

    <div class="s-Panel p-4">
        <h5 class="text-center my-4">${Rio.Texts.Forms.Membership.Login.LoginToYourAccount}</h5>
        <form id="~_Form" action="">
            <div id="~_PropertyGrid"></div>
            <div class="px-field">
                <a class="float-end text-decoration-none" href="${Q.resolveUrl('~/Account/ForgotPassword')}">
                    ${Rio.Texts.Forms.Membership.Login.ForgotPassword}
                </a>
            </div>
            <div class="px-field">
                <button id="~_LoginButton" type="submit" class="btn btn-primary my-3 w-100">
                    ${Rio.Texts.Forms.Membership.Login.SignInButton}
                </button>
            </div>
        </form>
    </div>

    <div class="text-center mt-2">
        <a class="text-decoration-none" href="${Q.resolveUrl('~/Account/SignUp')}">${Q.text("Forms.Membership.Login.SignUpButton")}</a>
    </div>   
`;
            }
        };
        LoginPanel = __decorate([
            Serenity.Decorators.registerClass()
        ], LoginPanel);
        Membership.LoginPanel = LoginPanel;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        let ResetPasswordPanel = class ResetPasswordPanel extends Serenity.PropertyPanel {
            constructor(container) {
                super(container);
                this.form = new Membership.ResetPasswordForm(this.idPrefix);
                this.form.NewPassword.addValidationRule(this.uniqueName, e => {
                    if (this.form.NewPassword.value.length < 7) {
                        return Q.format(Rio.Texts.Validation.MinRequiredPasswordLength, 7);
                    }
                });
                this.form.ConfirmPassword.addValidationRule(this.uniqueName, e => {
                    if (this.form.ConfirmPassword.value !== this.form.NewPassword.value) {
                        return Q.text('Validation.PasswordConfirm');
                    }
                });
                this.byId('SubmitButton').click(e => {
                    e.preventDefault();
                    if (!this.validateForm()) {
                        return;
                    }
                    var request = this.getSaveEntity();
                    request.Token = this.byId('Token').val();
                    Q.serviceCall({
                        url: Q.resolveUrl('~/Account/ResetPassword'),
                        request: request,
                        onSuccess: response => {
                            Q.information(Rio.Texts.Forms.Membership.ResetPassword.Success, () => {
                                window.location.href = Q.resolveUrl('~/Account/Login');
                            });
                        }
                    });
                });
            }
            getFormKey() { return Membership.ResetPasswordForm.formKey; }
        };
        ResetPasswordPanel = __decorate([
            Serenity.Decorators.registerClass()
        ], ResetPasswordPanel);
        Membership.ResetPasswordPanel = ResetPasswordPanel;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
var Rio;
(function (Rio) {
    var Membership;
    (function (Membership) {
        let SignUpPanel = class SignUpPanel extends Serenity.PropertyPanel {
            constructor(container) {
                super(container);
                this.form = new Membership.SignUpForm(this.idPrefix);
                this.form.ConfirmEmail.addValidationRule(this.uniqueName, e => {
                    if (this.form.ConfirmEmail.value !== this.form.Email.value) {
                        return Rio.Texts.Validation.EmailConfirm;
                    }
                });
                this.form.ConfirmPassword.addValidationRule(this.uniqueName, e => {
                    if (this.form.ConfirmPassword.value !== this.form.Password.value) {
                        return Q.text('Validation.PasswordConfirm');
                    }
                });
                this.byId('SubmitButton').click(e => {
                    e.preventDefault();
                    if (!this.validateForm()) {
                        return;
                    }
                    Q.serviceCall({
                        url: Q.resolveUrl('~/Account/SignUp'),
                        request: {
                            DisplayName: this.form.DisplayName.value,
                            Email: this.form.Email.value,
                            Password: this.form.Password.value
                        },
                        onSuccess: response => {
                            Q.information(Q.text('Forms.Membership.SignUp.Success'), () => {
                                window.location.href = Q.resolveUrl('~/');
                            });
                        }
                    });
                });
            }
            getFormKey() { return Membership.SignUpForm.formKey; }
        };
        SignUpPanel = __decorate([
            Serenity.Decorators.registerClass()
        ], SignUpPanel);
        Membership.SignUpPanel = SignUpPanel;
    })(Membership = Rio.Membership || (Rio.Membership = {}));
})(Rio || (Rio = {}));
//# sourceMappingURL=Rio.Web.js.map