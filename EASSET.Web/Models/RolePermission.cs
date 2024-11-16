using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class RolePermission
{
    public long RolePermissionId { get; set; }

    public int RoleId { get; set; }

    public string PermissionKey { get; set; }

    public virtual Role Role { get; set; }
}
