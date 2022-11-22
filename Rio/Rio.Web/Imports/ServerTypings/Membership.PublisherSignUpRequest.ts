namespace Rio.Membership {
    export interface PublisherSignUpRequest extends Serenity.ServiceRequest {
        Organization?: string;
        Name?: string;
        Email?: string;
        Mobile?: string;
        Password?: string;
        Recaptcha?: string;
    }
}
