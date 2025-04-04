using Microsoft.AspNetCore.Mvc;
using BitfinexConnector;

namespace BitfinexWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var connector = new TestConnector();
            return connector.SayHello();
        }
    }
}