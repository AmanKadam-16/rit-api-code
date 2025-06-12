using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using SchoolMobileEntities;
using SchoolMobileInterface;

namespace RITSchoolMobile.Controllers
{
    public class ProgressReportController : ApiController
    {
        private readonly IProgressReport progressReport;

        public ProgressReportController(IProgressReport progressReport)
        {
            this.progressReport = progressReport;
        }

        [HttpPost]
        [Route("ProgressReport/GetStudentExamResult")]
        public ExamResultList GetStudentExamResult([FromBody]SchoolParam schoolParam)
        {
            return this.progressReport.GetStudentExamResult(schoolParam.asSchoolId, schoolParam.asStudentId);
        }
        [HttpPost]
        [Route("ProgressReport/GetReasonforBlockingProgressReport")]
        public BlockingReport GetReasonforBlockingProgressReport([FromBody] SchoolParam schoolParam)
        {
            return this.progressReport.GetReasonforBlockingProgressReport(schoolParam.asSchoolId, schoolParam.asStudentId, schoolParam.asAcademicYearId);
        }

        [HttpPost]
        [Route("ProgressReport/getIsFinalResultPublished")]
        public Boolean GetIsFinalResultPublished([FromBody] SchoolParam schoolParam)
        {
            return this.progressReport.GetIsFinalResultPublished(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardDivisionId);
        }

        [HttpPost]
        [Route("ProgressReport/getIsTermExamPublished")]
        public Boolean GetIsTermExamPublished([FromBody] SchoolParam schoolParam)
        {
            return this.progressReport.GetIsTermExamPublished(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardDivisionId);
        }
        [HttpPost]
        [Route("ProgressReport/GetProgressReportFileName")]
        public FileName GetProgressReportFileName([FromBody]SchoolParam schoolParam)
        {
            return this.progressReport.GetProgressReportFileName(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStudentId, schoolParam.asLoginUserId,schoolParam.asTermId);
        }
        [HttpPost]
        [Route("ProgressReport/GetPrePrimaryExamPublishStatus")]
        public ButtonStatus GetPrePrimaryExamPublishStatus([FromBody] SchoolParam schoolParam)
        {
            return this.progressReport.GetPrePrimaryExamPublishStatus(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.aiYearwiseStudentId);
        }
        [HttpPost]
        [Route("ProgressReport/GetStudentBasicDetails")]
        public ButtonStatus GetStudentBasicDetails([FromBody]SchoolParam schoolParam)
        {
            return this.progressReport.GetStudentBasicDetails(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStudentId, schoolParam.asLoginUserId);
        }
    }
}
