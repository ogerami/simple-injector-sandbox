﻿using System.Web.Http;
using SimpleInjectorSandbox.Services;

namespace SimpleInjectorSandbox.Controllers
{
    [Route("api/test")]
    public class TestController : ApiController
    {
        private readonly TestService _testService;

        public TestController(TestService testService)
        {
            _testService = testService;
        }

        public IHttpActionResult Get()
        {
            return Ok(_testService.GetAll());
        }
    }
}