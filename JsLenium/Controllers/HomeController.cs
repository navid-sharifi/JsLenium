using Microsoft.AspNetCore.Mvc;

namespace JsLenium.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {

        [Route("initial")]
        public IActionResult Initial()
        {
            return View();
        }

        [Route("GetCommand")]
        public IActionResult GetCommand()
        {
            return Ok("Command");
        }

    }
}