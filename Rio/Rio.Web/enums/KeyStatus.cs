
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Rio.Web.Enums
{
    public enum KeyStatus
    {
        [Description("Created")]
        Created = 1,
        [Description("Open")]
        Open = 2,
        [Description("Activated")]
        Activated = 3,
        [Description("Disabled")]
        Disabled = 4,
        [Description("Expired")]
        Expired = 5,
        [Description("Offline Activated")]
        OfflineActivated = 6
    }
}