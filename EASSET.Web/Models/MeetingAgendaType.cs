using System;
using System.Collections.Generic;

namespace EASSET.Models;

public partial class MeetingAgendaType
{
    public int AgendaTypeId { get; set; }

    public string Name { get; set; }

    public virtual ICollection<MeetingAgenda> MeetingAgenda { get; set; } = new List<MeetingAgenda>();
}
