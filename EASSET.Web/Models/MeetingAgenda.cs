using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class MeetingAgenda
{
    public int AgendaId { get; set; }

    public int MeetingId { get; set; }

    public int AgendaNumber { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public int AgendaTypeId { get; set; }

    public int? RequestedByContactId { get; set; }

    public string Images { get; set; }

    public string Attachments { get; set; }

    public virtual MeetingAgendaType AgendaType { get; set; }

    public virtual Meeting Meeting { get; set; }

    public virtual ICollection<MeetingDecision> MeetingDecisions { get; set; } = new List<MeetingDecision>();

    public virtual Contact RequestedByContact { get; set; }
}
