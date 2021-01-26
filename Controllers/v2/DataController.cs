using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningSample.Controllers.v2
{
    [ApiVersion("2")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "data from api v2";
        }
    }
}