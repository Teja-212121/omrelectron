using Serenity.ComponentModel;
using Serenity.Web;
using System;

namespace Rio.Workspace.Forms
{
    [FormScript("Workspace.Settings")]
    [BasedOnRow(typeof(SettingsRow), CheckNames = true)]
    public class SettingsForm
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool UseSsl { get; set; }
        public string From { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }
        public string Sender { get; set; }
        public string GatewayUrl { get; set; }
        public bool UseXOAUTH2 { get; set; }
    }
}