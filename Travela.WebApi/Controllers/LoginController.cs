using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.WebApi.Jwt;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet("[login]")]
        public IActionResult Login()
        {
            return Ok(new CreateToken().TokenCreate());
        }

        [HttpGet("[register]")]
        public IActionResult Register()
        {
            return Ok(new CreateToken().TokenCreate());
        }


    }
}
