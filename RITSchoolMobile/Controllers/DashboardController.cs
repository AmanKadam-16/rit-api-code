using SchoolMobileEntities;
using SchoolMobileInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RITSchoolMobile.Controllers
{
    public class DashboardController : ApiController
    {
        private readonly IDashboard dashboard;

        public DashboardController(IDashboard dashboard)
        {
            this.dashboard = dashboard;
        }

        [HttpPost]
        [Route("Dashboard/GetStudentDetailsWeb")]
        public StudentDetailsWeb GetStudentDetails([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.GetStudentDetails(schoolAPIParam.aiStudentId, schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId);
        }

        [HttpPost]
        [Route("Dashboard/GetUpcomingEvents")]
        public UpcomingEventData GetUpcomingEvents([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.GetUpcomingEvents(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiUserId, schoolAPIParam.aiUserRoleId, schoolAPIParam.isScreenFullAccess, schoolAPIParam.abIsServiceCall = false);
        }

        [HttpPost]
        [Route("Dashboard/GetUnreadMessageList")]
        public UnreadMessageDetails GetUnreadMessageList([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.GetUnreadMessageList(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiReceiverId, schoolAPIParam.aiReceiverRoleId, schoolAPIParam.abIsServiceCall = false, schoolAPIParam.asProfilePicUpdDt = "");
        }

        [HttpPost]
        [Route("Dashboard/GetUpcomingStaffBdayList")]
        public BirthdayDetails GetUpcomingStaffBdayList([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.GetUpcomingStaffBdayList(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiUserRoleId, schoolAPIParam.asView, schoolAPIParam.abIsServiceCall = false);
        }

        [HttpPost]
        [Route("Dashboard/GetAlbumsList")]
        public List<PhotoGalley> GetAlbumsList([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.GetAlbumsList(schoolAPIParam.aiSchoolId, schoolAPIParam.aiMonth, schoolAPIParam.aiYear, schoolAPIParam.aiUserId, schoolAPIParam.iFirstLoad, schoolAPIParam.abIsServiceCall = false);
        }

        [HttpPost]
        [Route("Dashboard/GetUserFeedback")]
        public GetUserFeedbacks GetUserFeedback([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.GetUserFeedback(schoolAPIParam.aiUserRoleId, schoolAPIParam.aiFeedbackTypeId, schoolAPIParam.asFeedBackFor, schoolAPIParam.aiSchoolId, schoolAPIParam.sortDirection, schoolAPIParam.asStartDate, schoolAPIParam.asEndDate, schoolAPIParam.sortExpression, schoolAPIParam.startRowIndex, schoolAPIParam.iEndIndex, schoolAPIParam.abIsServiceCall, schoolAPIParam.asDesignationId, schoolAPIParam.abIsAccountsCumAdminOfficer);
        }

        [HttpPost]
        [Route("Dashboard/GetReportDescription")]
        public GetReportDescriptions GetReportDescription([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.GetReportDescription(schoolAPIParam.aiReportId,schoolAPIParam.aiSchoolId);
        }

        [HttpPost]
        [Route("Dashboard/GetReportName")]
        public GetReportname GetReportName([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.GetReportName(schoolAPIParam.aiSchoolId, schoolAPIParam.asAcademicYearId, schoolAPIParam.aiStandardId, schoolAPIParam.aiReportId, schoolAPIParam.aiTermId);
        }

        [HttpPost]
        [Route("Dashboard/SubmitStudentOnlineExam")]
        public SubmitStudentonlineexam SubmitStudentOnlineExam([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.SubmitStudentOnlineExam(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiStdId, schoolAPIParam.aiStdDivId, schoolAPIParam.aiSubjectId, schoolAPIParam.aiExamId, schoolAPIParam.aiStudentId);
        }

        [HttpPost]
        [Route("Dashboard/Messagefrom")]
        public GetSchoolNoticeweb FetchSchoolNoticess([FromBody] SchoolParam schoolAPIParam)
        {
            return this.dashboard.FetchSchoolNoticess(schoolAPIParam.aiSchoolId);
        }

    }
}
