using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Album.Api.Services;

namespace Album.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get([FromQuery] string name)
        {
            return Ok(GreetingService.checkParameter(name));
        }
    }
}
