using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; }

    public string DisplayName { get; set; }

    public string Email { get; set; }

    public string Source { get; set; }

    public string PasswordHash { get; set; }

    public string PasswordSalt { get; set; }

    public DateTime? LastDirectoryUpdate { get; set; }

    public string UserImage { get; set; }

    public DateTime InsertDate { get; set; }

    public int InsertUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateUserId { get; set; }

    public short IsActive { get; set; }

    public string MobilePhoneNumber { get; set; }

    public bool MobilePhoneVerified { get; set; }

    public int? TwoFactorAuth { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
