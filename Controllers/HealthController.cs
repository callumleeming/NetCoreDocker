using Microsoft.AspNetCore.Mvc;

namespace NetCoreDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Healthy!");
        }
    }
}
