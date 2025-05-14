using System;
using System.Collections.Generic;

namespace ITSupportAPI.Models;

public partial class TicketComment
{
    public int CommentId { get; set; }

    public int TicketId { get; set; }

    public int UserId { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Ticket Ticket { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
