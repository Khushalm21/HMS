using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class khushaltestcontroller : ControllerBase
    {
        [HttpGet]

        public IActionResult get()
        {
            return Ok("hello from khushal");
        }
    }
}
