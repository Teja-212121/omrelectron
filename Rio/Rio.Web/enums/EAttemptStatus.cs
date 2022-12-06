using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Rio.Web.Enums
{
    public enum EAttemptStatus
    {
        [Description("Attempted")]
        Attempted = 1,
        [Description("Not Attempted")]
        NotAttempted = 2
    }
}
