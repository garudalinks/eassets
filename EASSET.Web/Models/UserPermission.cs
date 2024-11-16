using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class UserPermission
{
    public long UserPermissionId { get; set; }

    public int UserId { get; set; }

    public string PermissionKey { get; set; }

    public bool Granted { get; set; }

    public virtual User User { get; set; }
}
