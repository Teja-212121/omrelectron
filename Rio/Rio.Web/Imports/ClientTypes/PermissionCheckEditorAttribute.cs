using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Rio
{
    public partial class PermissionCheckEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "/Modules/Administration/UserPermission/PermissionCheckEditor:PermissionCheckEditor";

        public PermissionCheckEditorAttribute()
            : base(Key)
        {
        }
    }
}
