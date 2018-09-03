using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace calcTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class showmethecodeController : ControllerBase
    {
        // GET: api/showmethecode
        [HttpGet]
        public string Get()
        {
            return "https://github.com/charlesfrutuoso/calcTest";
        }

        
    }
}
