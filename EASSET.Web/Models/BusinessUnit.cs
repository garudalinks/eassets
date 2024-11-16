using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class BusinessUnit
{
    public int UnitId { get; set; }

    public string Name { get; set; }

    public int? ParentUnitId { get; set; }

    public virtual ICollection<BusinessUnit> InverseParentUnit { get; set; } = new List<BusinessUnit>();

    public virtual ICollection<Meeting> Meetings { get; set; } = new List<Meeting>();

    public virtual BusinessUnit ParentUnit { get; set; }
}
