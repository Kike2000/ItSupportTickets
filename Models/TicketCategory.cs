using System;
using System.Collections.Generic;

namespace ITSupportAPI.Models;

public partial class TicketCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
