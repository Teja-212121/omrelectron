
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Rio.Web.Enums
{
    public enum PreDefinedKeyStatus
    {
        [Description("Consumed")]
        Consumed = 1,
        [Description("Not Consumed")]
        NotConsumed = 2
    }
}