using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; }

    public string RoleKey { get; set; }

    public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
