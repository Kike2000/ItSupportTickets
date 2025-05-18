using System;
using System.Collections.Generic;

namespace ITSupportAPI.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int UserId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? ResolvedAt { get; set; }

    public virtual ICollection<TicketAttachment> TicketAttachments { get; set; } = new List<TicketAttachment>();

    public virtual ICollection<TicketComment> TicketComments { get; set; } = new List<TicketComment>();

    public virtual ICollection<TicketHistory> TicketHistories { get; set; } = new List<TicketHistory>();

    public virtual ICollection<TicketTag> TicketTags { get; set; } = new List<TicketTag>();

    public virtual User User { get; set; } = null!;

    public virtual ICollection<TicketCategory> Categories { get; set; } = new List<TicketCategory>();
}
