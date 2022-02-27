﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleAPI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {   
        [HttpGet]
        public string Get() {
            return "Jitendra";
        }
    }
}
