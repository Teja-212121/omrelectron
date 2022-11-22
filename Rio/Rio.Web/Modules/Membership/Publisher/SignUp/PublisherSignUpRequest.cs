using Serenity.Services;
using System;

namespace Rio.Membership
{
    public class PublisherSignUpRequest : ServiceRequest
    {
        public String Organization { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Mobile { get; set; }
        public String Password { get; set; }        
        public String Recaptcha { get; set; }
    }
}