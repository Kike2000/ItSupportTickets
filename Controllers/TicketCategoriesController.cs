using ITSupportAPI.Data;
using ITSupportAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITSupportAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketCategoriesController : ControllerBase
    {
        private readonly ItSupportContext _context;

        private readonly ILogger<TicketCategoriesController> _logger;

        public TicketCategoriesController(ILogger<TicketCategoriesController> logger, ItSupportContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetTicketCategories")]
        public IEnumerable<TicketCategory> Get()
        {
            var ticketCategory = _context.TicketCategories.ToList();
            return ticketCategory;
        }
    }
}
