using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace Rio.Workspace.Columns
{
    [ColumnsScript("Workspace.Settings")]
    [BasedOnRow(typeof(SettingsRow), CheckNames = true)]
    public class SettingsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Host { get; set; }
        public int Port { get; set; }
        public int UseSsl { get; set; }
        public string From { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }
        public string Sender { get; set; }
        public string GatewayUrl { get; set; }
        public int TenantId { get; set; }
    }
}