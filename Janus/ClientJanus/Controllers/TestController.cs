using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ClientJanus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new[] {"value1", "value2"};
        }
    }
}