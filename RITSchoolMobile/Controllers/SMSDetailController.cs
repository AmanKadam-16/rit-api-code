using Newtonsoft.Json.Linq;
using SchoolMobileEntities;
using SchoolMobileInterface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Net.Http;

using System.Text;

using Newtonsoft.Json;
using SchoolMobileRepository.SMSDetail;
using System.Threading.Tasks;



namespace RITSchoolMobile.Controllers
{
    public class SMSDetailController : ApiController
    {
        private readonly ISMSDetail smsDetail;

        public SMSDetailController(ISMSDetail smsDetail)
        {
            this.smsDetail = smsDetail;
        }

        [HttpPost]
        [Route("SMS/GetSMSList")]
        public SMSList GetSMSList([FromBody]SchoolParam schoolParam)
        {
            return this.smsDetail.GetSMSList(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUserId, schoolParam.asReceiverUserRoleId, schoolParam.asPageIndex);
        }

        [HttpPost]
        [Route("SMS/GetSMSDetails")]
        public SMSDetails GetSMSDetails([FromBody]SchoolParam schoolParam)
        {
            return this.smsDetail.GetSMSDetails(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUserId, schoolParam.asUserRoleId, schoolParam.asSMSId);
        }
        [HttpPost]
        [Route("SMS/GetUserMobileNumber")]
        public GetUserMobileNumber GetUserMobileNumber([FromBody]SchoolParam schoolParam)
        {
            return this.smsDetail.GetUserMobileNumber(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUserId, schoolParam.asUserRoleId);
        }
        [HttpPost]
        [Route("SMS/SendSMS")]
        public int SendSMS([FromBody]SMSParam param)
        {
            return this.smsDetail.SendSMS(param.asSchoolId, param.aoMessage, param.asSelectedUserIds, param.asSelectedStDivId, param.asIsSoftwareCordinator, param.asMessageId, param.sIsReply, param.asIsForward, param.asSchoolName, param.asTemplateRegistrationId, param.chkManualNumber, param.asManualNumbers);
        }
        [HttpPost]
        [Route("SMS/GetAllSentSMSPermissionAndCounts")]
        public SMSCountsAndPermission GetAllSentSMSPermissionAndCounts([FromBody]SchoolParam schoolParam)
        {
            return this.smsDetail.GetAllSentSMSPermissionAndCounts(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUserId);
        }
        [HttpPost]
        [Route("SMS/SMSStatusDetails")]
        public SMSStatusResponse SMSStatusDetails([FromBody] SchoolParam schoolParam)
        {
            return this.smsDetail.SMSStatusDetails(schoolParam.asSchoolId, schoolParam.asSMSSentDate, schoolParam.aiTake,schoolParam.aiSkip,schoolParam.asFilter);
        }



    }


}

