using SchoolMobileEntities;
using SchoolMobileInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Utility;
using static Utility.Constants;

namespace RITSchoolMobile.Controllers
{
    public class HomeworkController : ApiController
    {
        private readonly IHomework homework;

        public HomeworkController(IHomework homework)
        {
            this.homework = homework;
        }
        [HttpPost]
        [Route("Homework/PublishUnpublishAddHomework")]
        public string PublishUnpublishAddHomework([FromBody] UserParam userAPIparam)
        {
            return this.homework.PublishUnpublishAddHomework(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asHomeWorkLogId, userAPIparam.asUnpublishReason, userAPIparam.asUpdatedById, userAPIparam.IsPublished, userAPIparam.IsSMSSent);
        }

        [HttpPost]
        [Route("Homework/GetPagedStudentResult")]
        public GetStudntsFinalResultDetails GetPagedStudentResult([FromBody] UserParam userAPIparam)
        {
            return this.homework.GetPagedStudentResult(userAPIparam.asSchoolId, userAPIparam.asAcademicyearId, userAPIparam.asStandardDivisionId, userAPIparam.SortExp, userAPIparam.prm_StartIndex, userAPIparam.PageSize);
        }

        [HttpPost]
        [Route("Homework/SubmitUnSubmitTestMarksToClassTeacher")]
        public string SubmitUnSubmitTestMarksToClassTeacher([FromBody] UserParam userAPIparam)
        {
            return this.homework.SubmitUnSubmitTestMarksToClassTeacher(userAPIparam.asStandardDivisionId, userAPIparam.asSubjectId, userAPIparam.asTestId, userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asIsSubmitted, userAPIparam.asReportingUserId);
        }

        [HttpPost]
        [Route("Homework/DeleteHomeworkDocument")]
        public string DeleteHomeworkDocument([FromBody] UserParam userAPIparam)
        {
            return this.homework.DeleteHomeworkDocument(userAPIparam.asSchoolId, userAPIparam.asUpdatedById, userAPIparam.asHomeworkId, userAPIparam.asUpdatedById);
        }

        [HttpPost]
        [Route("Homework/GetAllHomeworkDocuments")]
        public List<AllHomeworkDocuments> GetAllHomeworkDocuments([FromBody] UserParam userAPIparam)
        {
            return this.homework.GetAllHomeworkDocuments(userAPIparam.asSchoolId, userAPIparam.asHomeworkId, userAPIparam.asAcademicyearId);
        }


        [HttpPost]
        [Route("Homework/GetHomeworkDetails")]
        public GetHomeworkDetails GetHomeworkDetails([FromBody] UserParam userAPIparam)
        {
            return this.homework.GetHomeworkDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicyearId, userAPIparam.asHomeworkId);
        }

        [HttpPost]
        [Route("Homework/GetTeacherList")]
        public TeacherList GetTeacherList([FromBody] UserParam userAPIparam)
        {
            return this.homework.GetTeacherList(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.HasFullAccess);
        }


        [HttpPost]
        [Route("Homework/GetAllStudentStatus")]
        public List<StudentRecordStatus> GetAllStudentStatus([FromBody] UserParam userAPIparam)
        {
            return this.homework.GetAllStudentStatus(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId, userAPIparam.asFilter, userAPIparam.sortExpression, userAPIparam.sortDirection, userAPIparam.StartIndex, userAPIparam.EndIndex,userAPIparam.ShowSaved, userAPIparam.IncludeRiseAndShine, userAPIparam.HasEditAccess, userAPIparam.UserId);
        }
    }
}