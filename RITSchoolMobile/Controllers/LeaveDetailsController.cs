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
    public class LeaveDetailsController : ApiController
    {
        private readonly ILeaveDetails teacher;

        public LeaveDetailsController(ILeaveDetails teacher)
        {
            this.teacher = teacher;
        }


        //Start Your Controller Code from Here


        //LeveDetails ----Category
        [HttpPost]
        [Route("Teacher/GetAllLeaveCategory")]
        public List<GetAllLeaveCategory> GetAllLeaveCategory([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllLeaveCategory(userAPIparam.asId, userAPIparam.asSchoolId);

        }

        //LeveDetails ----view
        [HttpPost]
        [Route("Teacher/GetLeaveCategoryDetails")]
        public List<GetLeaveCategoryDetails> GetLeaveCategoryDetails([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.GetLeaveCategoryDetails(userAPIparamLeaveDetails.asId, userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asUserId);

        }
        //  LeveDetails ---- list view
        [HttpPost]
        [Route("Teacher/GetAllLeaveApprovalCatgoriesList")]
        public List<GetAllLeaveApprovalCatgories> GetAllLeaveApprovalCatgories([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.GetAllLeaveApprovalCatgories(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asCategoryId, userAPIparamLeaveDetails.asStatusId, userAPIparamLeaveDetails.asSortExpression, userAPIparamLeaveDetails.asStartIndex, userAPIparamLeaveDetails.asEndIndex, userAPIparamLeaveDetails.asShowOnlyNonUpdated, userAPIparamLeaveDetails.asAcademicYearId);

        }


        //LeveDetails ----DeleteApprovel
        [HttpPost]
        [Route("Teacher/DeleteLeaveApprovalCatgories")]
        public string DeleteLeaveApprovalCatgories([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteLeaveApprovalCatgories(userAPIparam.asSchoolId, userAPIparam.asId, userAPIparam.asUpdatedById);
        }

        //UpdateAdharDetails
        [HttpPost]
        [Route("Teacher/UpdateStudentAadharDetails")]
        public string UpdateStudentAadharDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.UpdateStudentAadharDetails(userAPIparam.asUserId, userAPIparam.asSchoolId, userAPIparam.asAadharCardNo, userAPIparam.asAadharCardPhotoCopyPath, userAPIparam.asStudentNameOnAadharCard, userAPIparam.asMotherTongue, userAPIparam.asEmail, userAPIparam.asUpdatedById, userAPIparam.asSaveFeature, userAPIparam.asFolderName, userAPIparam.asBase64String);
        }

        // [HttpPost]
        // [Route("Teacher/UpdateStudentAadharDetails")]
        // public string UpdateStudentAadharDetails([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        // {
        //     return this.teacher.UpdateStudentAadharDetails(userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asSchoolId, userAPIparam.asAadharCardNo, userAPIparam.asAadharCardPhotoCopyPath, userAPIparam.asStudentNameOnAadharCard, userAPIparam.asMotherTongue, userAPIparam.asEmail, userAPIparam.asUpdatedById, userAPIparam.asSaveFeature, userAPIparam.asFolderName, userAPIparam.asBase64String);
        // }

        // MissingAttendanceDetails -------
        [HttpPost]
        [Route("Teacher/GetMissingAttendanceDetailsForAlert")]
        public List<GetMissingAttendanceDetailsForAlert> GetMissingAttendanceDetailsForAlert([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.GetMissingAttendanceDetailsForAlert(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asAcademic_Year_Id, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asStandard_Division_Id, userAPIparamLeaveDetails.asDate);

        }


        // grade perform --------- year
        [HttpPost]
        [Route("Teacher/GetAllYears")]
        public List<GetAllYears> GetAllYears([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllYears(userAPIparam.asSchoolId);

        }
        // GetAllUsersReportingToGivenUser  --- pending & submit grade parform
        [HttpPost]
         [Route("Teacher/GetAllUsersReportingToGivenUser")]
         public List<GetAllUsersReportingToGivenUser> GetAllUsersReportingToGivenUser([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
         {
             return this.teacher.GetAllUsersReportingToGivenUser(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asYear, userAPIparamLeaveDetails.asShowPending, userAPIparamLeaveDetails.asStartIndex, userAPIparamLeaveDetails.asPageSize);

         }
        // GetAllUsersReportingToGivenUser  ---get Details

        [HttpPost]
        [Route("Teacher/GetStaffPerformanceEvaluationDetails")]
        public GetStaffPerformanceEvaluationDetailsmaster GetStaffPerformanceEvaluationDetails([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.GetStaffPerformanceEvaluationDetails(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asReportingUserId , userAPIparamLeaveDetails.asYear, userAPIparamLeaveDetails.asAcademicYearId);

        }
        //  SaveStaffPerformanceEvalDetails  --- Save
        
       
        //  SaveStaffPerformanceEvalDetails  --- submit

        [HttpPost]
        [Route("Teacher/SubmitStaffPerformanceDetails")]
        public string SubmitStaffPerformanceDetails([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.SubmitStaffPerformanceDetails(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asReportingUserId, userAPIparamLeaveDetails.asYear, userAPIparamLeaveDetails.asIsSubmitAction);
        }

        //StaffPerformanceEvalDetails --Delete  

        [HttpPost]
        [Route("Teacher/DeleteInvestmentDocument")]
        public string DeleteInvestmentDocument([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.DeleteInvestmentDocument(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asFinancialYearId, userAPIparamLeaveDetails.asUpdatedById, userAPIparamLeaveDetails.asDocumentId, userAPIparamLeaveDetails.asDocumnetTypeId);
        }

        //StaffPerformanceEvalDetails --upload  

        [HttpPost]
        [Route("Teacher/SaveInvestmentDocuments")]
        public string SaveInvestmentDocuments([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.SaveInvestmentDocuments(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asFinancialYearId, userAPIparamLeaveDetails.asDocumentId, userAPIparamLeaveDetails.asFileName, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asInsertedById, userAPIparamLeaveDetails.asDocumnetTypeId, userAPIparamLeaveDetails.asAcademicYearId, userAPIparamLeaveDetails.asReportingUserId);
        }
        //StaffPerformanceEvalDetails --view  

        [HttpPost]
        [Route("Teacher/InvestmentDocument")]
        public List<InvestmentDocument> InvestmentDocument([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.InvestmentDocument(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asFinancialYearId, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asDocumentId, userAPIparamLeaveDetails.asDocumnetTypeId, userAPIparamLeaveDetails.asAcademicYearId, userAPIparamLeaveDetails.asReportingUserId , userAPIparamLeaveDetails.asLoginUserId);

        }
        //

        [HttpPost]
        [Route("Teacher/MissingAttendanceDetails")]
        public MissingAttendanceDetailsMaster MissingAttendanceDetails([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.MissingAttendanceDetails(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asAcademicYearId, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asStandardDivisionId);

        }
        //
        [HttpPost]
        [Route("Teacher/SaveStaffPerformanceEvalDetails")]
        public string SaveStaffPerformanceEvalDetails([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.SaveStaffPerformanceEvalDetails(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asUpdatedById, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asReportingUserId, userAPIparamLeaveDetails.asYear, userAPIparamLeaveDetails.asPerformanceXml, userAPIparamLeaveDetails.asClasses, userAPIparamLeaveDetails.asSubjects);
        }
        //GetExamScheduleDetails --
        [HttpPost]
        [Route("Teacher/GetExamScheduleDetails")]
        public GetExamScheduleDetailsMasteR GetExamScheduleDetails([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.GetExamScheduleDetails(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asAcademicYearId);

        }
        [HttpPost]
        [Route("Teacher/GetLeaveStatus")]
        public List<LeaveStatus> GetLeaveStatus([FromBody] UserParamLeaveDetails userAPIparamLeaveDetails)
        {
            return this.teacher.GetLeaveStatus(userAPIparamLeaveDetails.asSchoolId, userAPIparamLeaveDetails.asAcademicYearId, userAPIparamLeaveDetails.asUserId, userAPIparamLeaveDetails.asCategoryId, userAPIparamLeaveDetails.asShowOnlyNonUpdated);

        }
    }
}