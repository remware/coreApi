using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.IO;

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
        [Route("resources")]
        public IActionResult GetTemplate()
        {
           // show files that are available / authorized
           var file = Path.Combine(Directory.GetCurrentDirectory(), 
                            "assets", "template.csv");

            return PhysicalFile(file, "text/csv");
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