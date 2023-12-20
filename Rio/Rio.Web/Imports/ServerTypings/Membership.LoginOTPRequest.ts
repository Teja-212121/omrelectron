namespace Rio.Membership {
    export interface LoginOTPRequest extends Serenity.ServiceRequest {
        MobileNumber?: string;
        VerificationCode?: number;
    }
}
