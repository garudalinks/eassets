using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class MeetingDecision
{
    public int DecisionId { get; set; }

    public int MeetingId { get; set; }

    public int? AgendaId { get; set; }

    public string Description { get; set; }

    public int DecisionNumber { get; set; }

    public int? ResponsibleContactId { get; set; }

    public DateTime? DueDate { get; set; }

    public int ResolutionStatus { get; set; }

    public string Images { get; set; }

    public string Attachments { get; set; }

    public virtual MeetingAgenda Agenda { get; set; }

    public virtual Meeting Meeting { get; set; }

    public virtual ICollection<MeetingDecisionRelevant> MeetingDecisionRelevants { get; set; } = new List<MeetingDecisionRelevant>();

    public virtual Contact ResponsibleContact { get; set; }
}
