using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CwlController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Bla()
        {
            await Task.Delay(0);

            return new JsonResult("bla");
        }
    }
}