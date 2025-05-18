using ITSupportAPI.Data;
using ITSupportAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITSupportAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ItSupportContext _context;

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, ItSupportContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            if (page < 1 || pageSize < 1)
            {
                throw new ArgumentException("Page and pageSize must be greater than 0.");
            }

            var users = _context.Users
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();
            return users;
        }
    }
}
