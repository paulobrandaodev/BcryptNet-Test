using Microsoft.AspNetCore.Mvc;
using BCrypt.Net;

namespace TesteByCrypt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword("my password");

            return Json(passwordHash);
        }

        [HttpGet("/hash")]
        public IActionResult Get(string hash)
        {
            return Json(BCrypt.Net.BCrypt.Verify("my password", hash));
        }
    }
}
