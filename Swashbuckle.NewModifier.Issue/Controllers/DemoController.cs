using Microsoft.AspNetCore.Mvc;
using Swashbuckle.NewModifier.Issue.Models;
using System.Net;

namespace Swashbuckle.NewModifier.Issue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        public DemoController()
        {

        }
        [HttpGet]
        [ProducesResponseType(typeof(Demo), (int)HttpStatusCode.OK)]
        public IActionResult Demo()
        {
            return Ok();
        }
    }
}
