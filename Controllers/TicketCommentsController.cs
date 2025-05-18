using ITSupportAPI.Data;
using ITSupportAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITSupportAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketCommentsController : ControllerBase
    {
        private readonly ItSupportContext _context;

        private readonly ILogger<TicketCommentsController> _logger;

        public TicketCommentsController(ILogger<TicketCommentsController> logger, ItSupportContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetTicketComments")]
        public IEnumerable<TicketComment> Get()
        {
            var ticketComments = _context.TicketComments.ToList();
            return ticketComments;
        }
    }
}
