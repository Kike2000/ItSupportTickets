using ITSupportAPI.Data;
using ITSupportAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITSupportAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ItSupportContext _context;

        private readonly ILogger<TicketController> _logger;

        public TicketController(ILogger<TicketController> logger, ItSupportContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetTickets")]
        public IEnumerable<Ticket> Get()
        {
            var tickets = _context.Tickets.ToList();
            return tickets;
        }
    }
}
