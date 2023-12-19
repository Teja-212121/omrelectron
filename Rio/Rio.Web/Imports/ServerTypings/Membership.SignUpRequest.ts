namespace Rio.Membership {
    export interface SignUpRequest extends Serenity.ServiceRequest {
        Email?: string;
        Password?: string;
        DisplayName?: string;
        FirstName?: string;
        LastName?: string;
        Countrycode?: Web.Enums.CountryCode;
        Mobile?: string;
    }
}
