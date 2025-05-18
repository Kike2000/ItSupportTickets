using System;
using System.Collections.Generic;

namespace ITSupportAPI.Models;

public partial class TicketPriority
{
    public int PriorityId { get; set; }

    public string PriorityName { get; set; } = null!;

    public string? Description { get; set; }
}
