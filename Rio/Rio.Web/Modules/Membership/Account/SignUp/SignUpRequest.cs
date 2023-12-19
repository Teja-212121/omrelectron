using Rio.Web.Enums;
using Serenity.Services;
using System;

namespace Rio.Membership
{
    public class SignUpRequest : ServiceRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CountryCode? Countrycode { get; set; }
        public string Mobile { get; set; }
    }
}