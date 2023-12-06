import { ServiceRequest } from "@serenity-is/corelib";

export interface SignUpRequest extends ServiceRequest {
    Email?: string;
    Password?: string;
    DisplayName?: string;
    FirstName?: string;
    LastName?: string;
    Mobile?: string;
}
