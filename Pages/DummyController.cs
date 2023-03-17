using Microsoft.AspNetCore.Mvc;

namespace dotnetcoresample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DummyController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Dummy server response";
        }
    }
}
