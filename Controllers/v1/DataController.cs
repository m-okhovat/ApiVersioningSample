using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningSample.Controllers.v1
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "data from api v1";
        }
    }
}
