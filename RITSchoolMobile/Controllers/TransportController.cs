using SchoolMobileEntities;
using SchoolMobileInterface;
using System.Web.Http;

namespace RITSchoolMobile.Controllers
{
    public class TransportController : ApiController
    {
        private readonly ITransport transport;

        public TransportController(ITransport transport)
        {
            this.transport = transport;
        }

        [HttpPost]
        [Route("Transport/GetStudentTransportDetails")]
        public StudentTransportDetails GetStudentTransportDetails([FromBody] SchoolParam schoolAPIParam)
        {
            return this.transport.GetStudentTransportDetails(schoolAPIParam.aiUserId, schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYearId, schoolAPIParam.aiTypeId);
        }
    }
}