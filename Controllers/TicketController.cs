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
        public IEnumerable<Ticket> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            if (page <= 0 || pageSize <= 0)
            {
                throw new ArgumentException("Page and pageSize must be greater than zero.");
            }

            var tickets = _context.Tickets
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            return tickets;
        }
    }
}
