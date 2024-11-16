using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public string Title { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string IdentityNo { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<MeetingAgenda> MeetingAgenda { get; set; } = new List<MeetingAgenda>();

    public virtual ICollection<MeetingDecisionRelevant> MeetingDecisionRelevants { get; set; } = new List<MeetingDecisionRelevant>();

    public virtual ICollection<MeetingDecision> MeetingDecisions { get; set; } = new List<MeetingDecision>();

    public virtual ICollection<Meeting> MeetingOrganizerContacts { get; set; } = new List<Meeting>();

    public virtual ICollection<Meeting> MeetingReporterContacts { get; set; } = new List<Meeting>();

    public virtual User User { get; set; }
}
