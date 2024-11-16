using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class Meeting
{
    public int MeetingId { get; set; }

    public string MeetingName { get; set; }

    public string MeetingNumber { get; set; }

    public Guid MeetingGuid { get; set; }

    public int MeetingTypeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int? LocationId { get; set; }

    public int? UnitId { get; set; }

    public int? OrganizerContactId { get; set; }

    public int? ReporterContactId { get; set; }

    public int InsertUserId { get; set; }

    public DateTime InsertDate { get; set; }

    public int? UpdateUserId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual MeetingLocation Location { get; set; }

    public virtual ICollection<MeetingAgenda> MeetingAgenda { get; set; } = new List<MeetingAgenda>();

    public virtual ICollection<MeetingDecision> MeetingDecisions { get; set; } = new List<MeetingDecision>();

    public virtual MeetingType MeetingType { get; set; }

    public virtual Contact OrganizerContact { get; set; }

    public virtual Contact ReporterContact { get; set; }

    public virtual BusinessUnit Unit { get; set; }
}
