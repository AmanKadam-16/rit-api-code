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
    public class SchoolNoticesController  : ApiController
    {
        private readonly ISchoolNotices teacher;

        public SchoolNoticesController(ISchoolNotices teacher)
        {
            this.teacher = teacher;
        }

        

        [HttpPost]
        [Route("Teacher/UpdateSelectedSchoolNotices")]
        public string UpdateSelectedSchoolNotices([FromBody] UserParam userAPIparam)
        {
            return this.teacher.UpdateSelectedSchoolNotices(userAPIparam.asSchoolId, userAPIparam.asNoticeXml);
        }

        [HttpPost]
        [Route("Teacher/DeleteSchoolNotice")]
        public string DeleteSchoolNotice([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteSchoolNotice(userAPIparam.asSchoolId, userAPIparam.asNoticeId, userAPIparam.asUpdatedById);
        }
        [HttpPost]
        [Route("Teacher/DeleteSchoolNoticeImage")]
        public string DeleteSchoolNoticeImage([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteSchoolNoticeImage(userAPIparam.asSchoolId, userAPIparam.asNoticeId, userAPIparam.asIsText);
        }
        [HttpPost]
        [Route("Teacher/EditSchoolNoticeDetails")]
        public List<GetSingleNoticeDetail> EditSchoolNoticeDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.EditSchoolNoticeDetails(userAPIparam.asSchoolId, userAPIparam.asNoticeId);
        }
        [HttpPost]
        [Route("Teacher/GetStandardDivisionsForSelectedNoticeId")]
        public List<GetStandardDivisionsForSelectedNoticeId> GetStandardDivisionsForSelectedNoticeId([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStandardDivisionsForSelectedNoticeId(userAPIparam.asSchoolId, userAPIparam.asNoticeId);
        }
        [HttpPost]
        [Route("Teacher/GetUserRolesForSelectedNoticeId")]
        public List<GetUserRolesForSelectedNoticeId> GetUserRolesForSelectedNoticeId([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetUserRolesForSelectedNoticeId(userAPIparam.asSchoolId, userAPIparam.asNoticeId);
        }
        [HttpPost]
        [Route("Teacher/GetAllNoticeList")]
        public List<GetALLNoticeDetails> GetAllNoticeList([FromBody] UserParamSchoolNotices userAPIparam)
        {
            return this.teacher.GetAllNoticeList(userAPIparam.asSchoolId, userAPIparam.asDisplayLocation, userAPIparam.asShowAllNotices, userAPIparam.asText, userAPIparam.asSortExpression, userAPIparam.MaximumRows, userAPIparam.StartRowIndex);
        }
        [HttpPost]
        [Route("Teacher/SaveUpdateSchoolNotices")]
        public string SaveUpdateSchoolNotices([FromBody] UserParamSchoolNotices userAPIparam)
        {
            return this.teacher.SaveUpdateSchoolNotices(userAPIparam.asUserRoleIds, userAPIparam.asClassIds, userAPIparam.asSaveFeature, userAPIparam.asFolderName, userAPIparam.asBase64String, userAPIparam.asBase64String2, userAPIparam.NoticeId, userAPIparam.NoticeName, userAPIparam.DisplayLocation, userAPIparam.StartDate, userAPIparam.EndDate, userAPIparam.SortOrder, userAPIparam.FileName, userAPIparam.IsSelected, userAPIparam.IsText, userAPIparam.NoticeContent, userAPIparam.UserId, userAPIparam.SchoolId, userAPIparam.InertedById, userAPIparam.NoticeDescription, userAPIparam.NoticeImage);
        }

        //
        //UpdateAdharDetails
        [HttpPost]
        [Route("Teacher/UpdateTeacherAadharDetails")]
        public string UpdateTeacherAadharDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.UpdateTeacherAadharDetails(userAPIparam.asUserId, userAPIparam.asSchoolId, userAPIparam.asAadharCardNo, userAPIparam.asAadharCardPhotoCopyPath,userAPIparam.asUpdatedById, userAPIparam.asSaveFeature, userAPIparam.asFolderName, userAPIparam.asBase64String);
        }
     
    }
}