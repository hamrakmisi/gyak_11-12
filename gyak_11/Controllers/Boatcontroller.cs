using gyak_11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gyak_11.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class Boatcontroller : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]
        public IActionResult MindegyHogyHivjak()
        {
            HajosContext context = new HajosContext();
            var kérdések = from x in context.Questions select x.Question1;

            return Ok(kérdések);
        }
    }
}
