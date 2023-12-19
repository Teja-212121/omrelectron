import { ServiceRequest } from "@serenity-is/corelib";
import { CountryCode } from "../Web/Enums.CountryCode";

export interface SignUpRequest extends ServiceRequest {
    Email?: string;
    Password?: string;
    DisplayName?: string;
    FirstName?: string;
    LastName?: string;
    Countrycode?: CountryCode;
    Mobile?: string;
}
