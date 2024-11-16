using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class MeetingType
{
    public int MeetingTypeId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Meeting> Meetings { get; set; } = new List<Meeting>();
}
