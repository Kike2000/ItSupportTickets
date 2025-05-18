using System;
using System.Collections.Generic;

namespace ITSupportAPI.Models;

public partial class TicketTag
{
    public int TagId { get; set; }

    public int TicketId { get; set; }

    public string TagName { get; set; } = null!;

    public virtual Ticket Ticket { get; set; } = null!;
}
