using System;
using System.Collections.Generic;

namespace UIShell.RbacPermissionService
{
    /// <summary>
    /// ���ɫ
    /// </summary>
    public partial class GroupRole : BaseModel
    {
        public Group Group { get; set; }
        public Role Role { get; set; }
    }
}
