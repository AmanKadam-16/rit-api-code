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
    public class WeeklyTimeTableController : ApiController
    {
        private readonly IWeeklyTimeTable teacher;

        public WeeklyTimeTableController(IWeeklyTimeTable teacher)
        {
            this.teacher = teacher;
        }


        [HttpPost]
        [Route("Teacher/GetTimeTableForTeacher")]
        public GetTimeTableForTeacherMaster GetTimeTableForTeacher([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetTimeTableForTeacher(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asTeacherID);
        }
        [HttpPost]
        [Route("Teacher/SaveTeacherTimeTable")]
        public string SaveTeacherTimeTable([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveTeacherTimeTable(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.asTeacherID, userAPIparam.asMasterXml, userAPIparam.asDetailXml, userAPIparam.asTeacherXML, userAPIparam.IsAdditionalClass, userAPIparam.asIncCnt);
        }
        [HttpPost]
        [Route("Teacher/SaveClassTimeTable")]
        public string SaveClassTimeTable([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveClassTimeTable(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.asStdDivId, userAPIparam.asMasterXml, userAPIparam.asDetailXml, userAPIparam.asAdditionalLect, userAPIparam.IsAdditionalClass, userAPIparam.asIncCnt);
        }
        [HttpPost]
        [Route("Teacher/GetGroupwiseOptionalSubject")]
        public List<GroupwiseOptionalSubject> GetGroupwiseOptionalSubject([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetGroupwiseOptionalSubject(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId, userAPIparam.asParentGroupId, userAPIparam.asSubjectGroupId);
        }
        [HttpPost]
        [Route("Teacher/IsPrePrimaryExamConfiguration")]
        public bool IsPrePrimaryExamConfiguration([FromBody] UserParam userAPIparam)
        {
            return this.teacher.IsPrePrimaryExamConfiguration(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId, userAPIparam.asUserRole);
        }
        [HttpPost]
        [Route("Teacher/IsMonthConfigurationForExamResult")]
        public bool IsMonthConfigurationForExamResult([FromBody] UserParam userAPIparam)
        {
            return this.teacher.IsMonthConfigurationForExamResult(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId);
        }
        [HttpPost]
        [Route("Teacher/IsTestAndSubjectConfiguredForRemarks")]
        public bool IsTestAndSubjectConfiguredForRemarks([FromBody] UserParam userAPIparam)
        {
            return this.teacher.IsTestAndSubjectConfiguredForRemarks(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asTestId, userAPIparam.asSubjectId);
        }
        [HttpPost]
        [Route("Teacher/GetAllStudentsByGivenStdDivs")]
        public List<GetAllStudentsByGivenStdDiv> GetAllStudentsByGivenStdDivs([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllStudentsByGivenStdDivs(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivIds, userAPIparam.IsLeftStudents);
        }
        [HttpPost]
        [Route("Teacher/GetSMSTemplate")]
        public GetSMSTemplate GetSMSTemplate([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetSMSTemplate(userAPIparam.asSchoolId, userAPIparam.asSmsTemplateId);
        }
        [HttpPost]
        [Route("Teacher/InsertMessageDetail")]
        public string InsertMessageDetail([FromBody] UserParam userAPIparam)
        {
            return this.teacher.InsertMessageDetail(userAPIparam.asSchoolId, userAPIparam.asSubject, userAPIparam.asMessageBody, userAPIparam.asDisplayText, userAPIparam.asSenderUserRoleId, userAPIparam.asSenderUserId, userAPIparam.asRequestReadReceipt, userAPIparam.asAcademicYearId, userAPIparam.InsertedById, userAPIparam.asDisplayTextCc);
        }
        [HttpPost]
        [Route("Teacher/ValidateDataForTeacher")]
        public List<ValidateData> ValidateData([FromBody] UserParam userAPIparam)
        {
            return this.teacher.ValidateData(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.asTeacherID, userAPIparam.asMasterXml, userAPIparam.asDetailXml, userAPIparam.asTeacherXML, userAPIparam.asIncCnt);
        }
        [HttpPost]
        [Route("Teacher/ValidateDataForClass")]
        public List<ValidateData> ValidateClassData([FromBody] UserParam userAPIparam)
        {
            return this.teacher.ValidateClassData(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.asStdDivId, userAPIparam.asMasterXml, userAPIparam.asDetailXml, userAPIparam.IsAdditionalClass, userAPIparam.asIncCnt);

        }
        [HttpPost]
        [Route("Teacher/ValidateAdditionalDataForTeacher")]
        public List<ValidateData> ValidateAdditionalData([FromBody] UserParam userAPIparam)
        {
            return this.teacher.ValidateAdditionalData(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.asTeacherID, userAPIparam.asMasterXml, userAPIparam.asDetailXml, userAPIparam.IsAdditionalClass, userAPIparam.asIncCnt);
        }
        //Weekly Timetable PopUp - Submit + Validate combined API
        [HttpPost]
        [Route("Teacher/SubmitAndValidateAdditionalLectures")]
        public SubmitAndValidateAdditionalLectures ValidateAdditionalLectures([FromBody] UserParam userAPIparam)
        {
            return this.teacher.ValidateAdditionalLectures(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.asTeacherID, userAPIparam.asMasterXml, userAPIparam.asDetailXml, userAPIparam.IsAdditionalClass, userAPIparam.asIncCnt);
        }
    }
}