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
        public IEnumerable<User> Get()
        {
            var users = _context.Users.ToList();
            return users;
        }
    }
}
