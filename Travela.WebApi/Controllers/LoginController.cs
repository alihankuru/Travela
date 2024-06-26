using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.WebApi.Jwt;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public IActionResult Login()
        {
            return Ok(new CreateToken().TokenCreate());
        }

        [HttpPost]
        public IActionResult Register()
        {
            return Ok(new CreateToken().TokenCreate());
        }


    }
}
