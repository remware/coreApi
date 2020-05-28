using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Api
{
    [Route("identity")]
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("public")]

        public IActionResult PublicSpace()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}