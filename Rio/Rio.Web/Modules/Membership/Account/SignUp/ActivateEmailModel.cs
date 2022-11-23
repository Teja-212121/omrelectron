
namespace Rio.Membership
{
    public class ActivateEmailModel
    {
        public string Username { get; set; }
        public string Organization { get; set; }
        public string DisplayName { get; set; }
        public string ActivateLink { get; set; }
        public string LoginLink { get; set; }
    }
}