using Serenity.ComponentModel;
using Serenity.Services;

namespace Rio.Membership
{
    [FormScript("Membership.Login")]
    [BasedOnRow(typeof(Administration.UserRow), CheckNames = true)]
    public class LoginRequest : ServiceRequest
    {
        [Placeholder("user name")]
        public string Username { get; set; }
        [PasswordEditor, Required(true), Placeholder("password")]
        public string Password { get; set; }
        [Ignore]
        public string TwoFactorGuid { get; set; }
        [Ignore]
        public int? TwoFactorCode { get; set; }
        
    }


    [BasedOnRow(typeof(Administration.UserRow), CheckNames = true)]
    public class LoginOTPRequest : ServiceRequest
    {
        [Placeholder("MobileNumber")]
        public string MobileNumber { get; set; }
        [ Required(true), Placeholder("VerificationCode")]
        public int VerificationCode { get; set; }
       

    }
}