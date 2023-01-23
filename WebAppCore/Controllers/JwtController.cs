using Microsoft.AspNetCore.Mvc;
using WebAppCore.Helpers;
namespace WebAppCore.Controllers
{
    public class JwtController : ControllerBase
    {
        [HttpGet]
        public IActionResult Jwt()
        {
            return new ObjectResult(JwtToken.GenerateJwtToken());
        }
    }
}
