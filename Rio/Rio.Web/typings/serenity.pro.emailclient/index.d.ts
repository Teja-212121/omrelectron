/// <reference types="serenity.corelib" />
/// <reference types="jquery" />
/// <reference types="jqueryui" />
/// <reference types="jquery.validation" />
/// <reference types="react" />
declare namespace Serenity.Pro.EmailClient {
    interface EmailAttachment {
        Key?: number;
        FileName?: string;
        DownloadUrl?: string;
        Size?: number;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailAttachmentRequest extends ServiceRequest {
        Folder?: string;
        UniqueId?: number;
        Key?: string;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailComposeForm {
        To: EmailSuggestEditor;
        Cc: EmailSuggestEditor;
        Bcc: EmailSuggestEditor;
        Subject: StringEditor;
        BodyHtml: EmailContentEditor;
        Attachments: MultipleImageUploadEditor;
        ReplyToFolder: StringEditor;
        ReplyToUniqueId: StringEditor;
    }
    class EmailComposeForm extends Serenity.PrefixedContext {
        static formKey: string;
        private static init;
        constructor(prefix: string);
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailComposeRequest extends ServiceRequest {
        To?: string;
        Cc?: string;
        Bcc?: string;
        Subject?: string;
        BodyHtml?: string;
        Attachments?: string;
        ReplyToFolder?: string;
        ReplyToUniqueId?: number;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailDeleteRequest extends ServiceRequest {
        Folder?: string;
        UniqueIds?: number[];
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailFolder {
        Kind?: string;
        Name?: string;
        FullName?: string;
        UnreadCount?: number;
        SubFolders?: EmailFolder[];
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailItem {
        UniqueId?: number;
        Subject?: string;
        Date?: string;
        From?: string;
        To?: string;
        Cc?: string;
        Seen?: boolean;
        Important?: boolean;
        Deleted?: boolean;
        HasAttachments?: boolean;
        Size?: number;
        HtmlBody?: string;
        Attachments?: EmailAttachment[];
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailListRequest extends ListRequest {
        Folder?: string;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailLoginInfo {
        ImapHost?: string;
        ImapPort?: number;
        ImapUsername?: string;
        ImapPassword?: string;
        SmtpHost?: string;
        SmtpPort?: number;
        SmtpUsername?: string;
        SmtpPassword?: string;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailLoginRequest extends ServiceRequest {
        LoginInfo?: EmailLoginInfo;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailMoveRequest extends ServiceRequest {
        SourceFolder?: string;
        UniqueIds?: number[];
        TargetFolder?: string;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailReplyRequest extends ServiceRequest {
        Folder?: string;
        UniqueId?: number;
        ReplyToAll?: boolean;
        Forward?: boolean;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailReplyResponse extends ServiceResponse {
        Subject?: string;
        To?: string;
        Cc?: string;
        ReplyBody?: string;
        Attachments?: EmailAttachment[];
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailRetrieveRequest extends ServiceRequest {
        Folder?: string;
        UniqueId?: number;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailSuggestRequest extends ServiceRequest {
        ContainsText?: string;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailSuggestResponse extends ServiceResponse {
        Suggestions?: string[];
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailToggleSeenRequest extends ServiceRequest {
        Folder?: string;
        UniqueIds?: number[];
        Seen?: boolean;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailUnreadCountRequest extends ServiceRequest {
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface EmailUnreadCountResponse extends ServiceResponse {
        UnreadCount?: number;
    }
}
declare namespace Serenity.Pro.EmailClient {
    namespace MailboxService {
        const baseUrl = "Serenity.Pro.EmailClient/Mailbox";
        function Login(request: EmailLoginRequest, onSuccess?: (response: ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Signout(request: ServiceRequest, onSuccess?: (response: ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function UnreadCount(request: EmailUnreadCountRequest, onSuccess?: (response: EmailUnreadCountResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Suggest(request: EmailSuggestRequest, onSuccess?: (response: EmailSuggestResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Reply(request: EmailReplyRequest, onSuccess?: (response: EmailReplyResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Compose(request: EmailComposeRequest, onSuccess?: (response: ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function DeleteMessages(request: EmailDeleteRequest, onSuccess?: (response: ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ToggleSeen(request: EmailToggleSeenRequest, onSuccess?: (response: ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function Move(request: EmailMoveRequest, onSuccess?: (response: ServiceResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListMessages(request: EmailListRequest, onSuccess?: (response: ListResponse<EmailItem>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function ListFolders(request: ServiceRequest, onSuccess?: (response: ListResponse<EmailFolder>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        function RetrieveMessage(request: EmailRetrieveRequest, onSuccess?: (response: RetrieveResponse<EmailItem>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        const enum Methods {
            Login = "Serenity.Pro.EmailClient/Mailbox/Login",
            Signout = "Serenity.Pro.EmailClient/Mailbox/Signout",
            UnreadCount = "Serenity.Pro.EmailClient/Mailbox/UnreadCount",
            Suggest = "Serenity.Pro.EmailClient/Mailbox/Suggest",
            Reply = "Serenity.Pro.EmailClient/Mailbox/Reply",
            Compose = "Serenity.Pro.EmailClient/Mailbox/Compose",
            DeleteMessages = "Serenity.Pro.EmailClient/Mailbox/DeleteMessages",
            ToggleSeen = "Serenity.Pro.EmailClient/Mailbox/ToggleSeen",
            Move = "Serenity.Pro.EmailClient/Mailbox/Move",
            ListMessages = "Serenity.Pro.EmailClient/Mailbox/ListMessages",
            ListFolders = "Serenity.Pro.EmailClient/Mailbox/ListFolders",
            RetrieveMessage = "Serenity.Pro.EmailClient/Mailbox/RetrieveMessage"
        }
    }
}
declare namespace Serenity.Pro.EmailClient {
    namespace PermissionKeys {
        namespace EmailClient {
            const Mailbox = "EmailClient:Mailbox";
        }
    }
}
declare namespace Serenity.Pro.EmailClient {
    class EmailComposeDialog extends Serenity.PropertyDialog<EmailComposeRequest, any> {
        private form;
        constructor();
        protected getFormKey(): string;
        private _reply;
        get reply(): EmailReplyResponse;
        set reply(value: EmailReplyResponse);
        protected getDialogButtons(): {
            text: string;
            click: () => void;
        }[];
        protected getDialogOptions(): JQueryUI.DialogOptions;
    }
}
declare namespace Serenity.Pro.EmailClient {
    class EmailContentEditor extends Serenity.HtmlContentEditor {
        constructor(element: JQuery, opt: Serenity.HtmlContentEditorOptions);
        getConfig(): Serenity.CKEditorConfig;
    }
}
declare namespace Serenity.Pro.EmailClient {
    class EmailSuggestEditor extends Serenity.Widget<EmailSuggestEditorOptions> {
        constructor(element: JQuery, opt: EmailSuggestEditorOptions);
    }
    interface EmailSuggestEditorOptions {
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface HtmlIFrameProps extends React.IframeHTMLAttributes<HTMLIFrameElement> {
        contents: string;
    }
    class HtmlIFrame extends React.Component<HtmlIFrameProps> {
        private iframe;
        updateContents(): void;
        componentDidMount(): void;
        componentWillReceiveProps(nextProps: HtmlIFrameProps): void;
        render(): JSX.Element;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface MailViewerProps {
        folder: string;
        flatFolderList: EmailFolder[];
        uid: number;
        onClose: () => void;
    }
    interface MailViewerState {
        message: EmailItem;
    }
    class MailViewer extends React.Component<MailViewerProps, MailViewerState> {
        private loadTimeout;
        constructor(props: MailViewerProps);
        componentDidMount(): void;
        componentWillReceiveProps(newProps: MailViewerProps): void;
        back(): void;
        loadMessage(folder: string, uid: number): PromiseLike<any>;
        load(): void;
        deleteMessage(): void;
        moveToFolder(target: string): void;
        getDateText(): string;
        reply(all?: boolean, forward?: boolean): void;
        render(): JSX.Element;
    }
}
declare namespace Serenity.Pro.EmailClient {
    const folderIcons: {
        inbox: string;
        sent: string;
        drafts: string;
        junk: string;
        trash: string;
    };
    interface MailboxFolderLinkProps {
        folder: EmailFolder;
        activeFolder: string;
    }
    function mailboxFolderName(folder: EmailFolder): string;
    class MailboxFolderLink extends React.Component<MailboxFolderLinkProps> {
        render(): React.ReactNode;
    }
}
declare namespace Serenity {
    interface Widget<TOptions> {
        props: any;
        render(): any;
        setState(value: any): any;
        forceUpdate(): any;
        state: any;
        context: any;
        refs: any;
    }
}
declare namespace Serenity.Pro.EmailClient {
    class MailboxLoginProps {
        onLogin: () => void;
    }
    class MailboxLoginView extends React.Component<MailboxLoginProps> {
        private editorRefs;
        private loadQuickSettings;
        handleQuickSettingChange: (e: React.ChangeEvent<HTMLSelectElement>) => void;
        componentDidMount(): void;
        login(): void;
        private form;
        render(): React.ReactNode;
    }
}
declare namespace Serenity.Pro.EmailClient {
    function mailboxFolderSelectPadding(folder: EmailFolder): string;
    interface MailboxToolbarProps {
        onCheckAll: () => void;
        onToggleSeen: () => void;
        allChecked: boolean;
        onDelete: () => void;
        onRefresh: () => void;
        onMoveToFolder: (folder: string) => void;
        folder: string;
        flatFolderList: EmailFolder[];
        page: number;
        pageSize: number;
        messageCount: number;
        onChangePage: (page: number) => void;
    }
    class MailboxToolbar extends React.Component<MailboxToolbarProps, {}> {
        handleMoveToFolder(e: React.ChangeEvent<HTMLSelectElement>): void;
        render(): JSX.Element;
    }
}
declare namespace Serenity.Pro.EmailClient {
    interface MailboxItem extends EmailItem {
        __checked?: boolean;
    }
    interface MailboxState {
        showLogin: boolean;
        folder: string;
        folders: any[];
        messageCount: number;
        messages: MailboxItem[];
        page: number;
        pageSize: number;
        viewingMessage: number;
        newMessages: number;
        containsText: string;
        containsLock: 0;
    }
    class MailboxView extends React.Component<{}, MailboxState> {
        private reloadTimeout;
        private element;
        constructor(props: {}, context?: any);
        private loadMessages;
        composeMessage(): void;
        serviceErrorHandler(response: ServiceResponse): void;
        initialLoadFolders(): void;
        changeFolder(folder: string): void;
        changePage(page: number): void;
        setElement(el: HTMLElement): void;
        componentDidMount(): void;
        activeFolderName(): string;
        setContainsText(newValue: string): void;
        allChecked(): boolean;
        checkAll(): void;
        deleteSelected(): void;
        moveToFolder(folder: string, message?: MailboxItem): void;
        getToolbarProps(): MailboxToolbarProps;
        setChecked(message: MailboxItem, value: boolean): void;
        toggleSeen(message?: MailboxItem): void;
        refreshMessages(): void;
        signout(): void;
        render(): JSX.Element;
    }
}
