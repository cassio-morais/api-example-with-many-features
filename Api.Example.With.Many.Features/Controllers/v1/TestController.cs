using Api.Example.With.Many.Features.Rest.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Api.Example.With.Many.Features.Rest.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route(GlobalPathHelper.Pattern)]
    public class TestController : ControllerBase
    {
        [HttpGet("something")]
        public IActionResult Get() => Ok(new { test = "v1" });
    }
}
