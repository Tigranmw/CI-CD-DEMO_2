using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Test.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Ping()
        {
            return Ok("pong");
        }
    }
}