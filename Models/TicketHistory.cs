﻿using System;
using System.Collections.Generic;

namespace ITSupportAPI.Models;

public partial class TicketHistory
{
    public int HistoryId { get; set; }

    public int TicketId { get; set; }

    public string OldStatus { get; set; } = null!;

    public string NewStatus { get; set; } = null!;

    public int ChangedBy { get; set; }

    public DateTime? ChangedAt { get; set; }

    public virtual User ChangedByNavigation { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
