using Microsoft.AspNetCore.Mvc;
using Shared.Api.Attributes;

namespace Template.Controllers
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("2.0")]
    [Route("[controller]")]
    [Produces("application/json")]
    [DevelopmentOnly]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("get")]
        public object Get()
        {
            return 1;
        }

        [HttpGet, MapToApiVersion("2.0")]
        [Route("get")]
        public object GetV2()
        {
            return 2;
        }
    }
}