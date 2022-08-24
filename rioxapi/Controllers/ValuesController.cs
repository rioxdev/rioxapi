using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace rioxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("rampage extrem!");
        }
    }
}
