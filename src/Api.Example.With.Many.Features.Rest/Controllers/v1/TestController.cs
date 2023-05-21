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

        [HttpPost("something/data")]
        [ProducesResponseType(typeof(Data), StatusCodes.Status200OK)]
        public IActionResult PostData(Data data) => Ok(data);
    }
    public record Data(string Content, IList<string> Strings);
}
