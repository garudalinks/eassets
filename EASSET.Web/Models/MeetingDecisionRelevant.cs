using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class MeetingDecisionRelevant
{
    public int DecisionRelevantId { get; set; }

    public int DecisionId { get; set; }

    public int ContactId { get; set; }

    public virtual Contact Contact { get; set; }

    public virtual MeetingDecision Decision { get; set; }
}
