using SchoolMobileEntities;
using SchoolMobileInterface.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Utility;
using static Utility.Constants;

namespace RITSchoolMobile.Controllers.Teacher
{
    public class SMSCenterController : ApiController
    {
        private readonly ISMSCenter teacher;

        public SMSCenterController(ISMSCenter teacher)
        {
            this.teacher = teacher;
        }

      

        [HttpPost]
        [Route("Teacher/GetSMSDetails")]
        public GetSMSDetail GetSMSDetails([FromBody] UserParamSMSCenter userAPIparam)
        {
            return this.teacher.GetSMSDetails(userAPIparam.asSchoolId, userAPIparam.asSMSId);
        }
        [HttpPost]
        [Route("Teacher/GetMobileNumberDetails")]
        public GetMobileNumberDetail GetMobileNumberDetails([FromBody] UserParamSMSCenter userAPIparam)
        {
            return this.teacher.GetMobileNumberDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId);
        }
        [HttpPost]
        [Route("Teacher/GetInboxSMSLists")]
        public GetInboxSMSList GetInboxSMS([FromBody] UserParamSMSCenter userAPIparam)
        {
            return this.teacher.GetInboxSMS(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId);
        }

    }
}