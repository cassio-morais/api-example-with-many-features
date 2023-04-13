using Api.Example.With.Many.Features.Rest.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Api.Example.With.Many.Features.Rest.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route(GlobalPathHelper.Pattern)]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new { test = "v2" });
    }
}
