using Serenity.ComponentModel;
using System;

namespace Rio.Membership
{
    [FormScript("Membership.SignUp")]
    public class PublisherSignUpForm
    {
        [Required(true), Placeholder("Organization")]
        public String Organization { get; set; }
        [Required(true), Placeholder("full name")]
        public String DisplayName { get; set; }
        [Required(true), Placeholder("mobile")]
        public String Mobile { get; set; }
        [EmailAddressEditor, Required(true), Placeholder("e-mail")]
        public String Email { get; set; }
        [EmailAddressEditor, Required(true), Placeholder("confirm email")]
        public String ConfirmEmail { get; set; }
        [PasswordEditor, Required(true), Placeholder("password")]
        public String Password { get; set; }
        [PasswordEditor, Required(true), Placeholder("confirm password")]
        public String ConfirmPassword { get; set; }
    }
}
