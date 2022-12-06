using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Rio.Web.Enums
{
    public enum EResultSyncStatus
    {
        [Description("Pending")]
        Pending = 1,
        [Description("Synced")]
        Synced = 2
    }
}
