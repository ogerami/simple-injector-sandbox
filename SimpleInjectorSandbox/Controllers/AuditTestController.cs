using System.Web.Http;
using SimpleInjectorSandbox.Services;

namespace SimpleInjectorSandbox.Controllers
{
    [Route("api/audit/test")]
    public class AuditTestController : ApiController
    {
        private readonly TestService _testService;

        public AuditTestController(TestService testService)
        {
            _testService = testService;
        }

        public IHttpActionResult Get()
        {
            return Ok(_testService.GetAll());
        }
    }
}