using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class MeetingLocation
{
    public int LocationId { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual ICollection<Meeting> Meetings { get; set; } = new List<Meeting>();
}
