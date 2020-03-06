using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EnumGenExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery]DemoRequest request)
        {
            return Ok();
        }
    }

    public class DemoRequest
    {
        public DemoEnum DemoSelection { get; set; }
        public DemoEnum? DemoSelectionNullable { get; set; }
    }

    public enum DemoEnum
    {
        value1,
        value2
    }
}
