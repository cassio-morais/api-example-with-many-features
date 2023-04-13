using Microsoft.AspNetCore.Mvc;

namespace Api.Example.With.Many.Features.Rest.Controllers.v3
{
    [ApiController]
    [ApiVersion("3.0")]
    [Route("base-path/api/[controller]")]
    public class TestVersioningByHeaderController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new { test = "v3 - versioning by header" });
    }
}
