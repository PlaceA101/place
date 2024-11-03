using Microsoft.AspNetCore.Mvc;

namespace AidanNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            return Ok(new { name = "Aidan Place" });
        }
    }
}
