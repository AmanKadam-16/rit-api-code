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

namespace RITSchoolMobile.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudent student;

        public StudentController(IStudent student)
        {
            this.student = student;
        }

        [HttpPost]
        [Route("Student/GetStudentAttendaceForMonth")]
        public GetStudentattendaceforMonthResult GetStudentAttendaceForMonth([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetStudentAttendaceForMonth(schoolAPIParam.asStandardId, schoolAPIParam.asDivisionId, schoolAPIParam.asStudentId, schoolAPIParam.asMonth, schoolAPIParam.asYear, schoolAPIParam.asAcademicYearId, schoolAPIParam.asSchoolId);
        }

        [HttpPost]
        [Route("Student/GetFeeDetails")]
        public Getfeedetails GetFeeDetails([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetFeeDetails(schoolAPIParam.asSchoolId, schoolAPIParam.asStudentId, schoolAPIParam.aiAcademicYearId, schoolAPIParam.abIsForCurrentYear);
        }

        [HttpPost]
        [Route("Student/GetPTADetails")]
        public GetPTAdetails GetPTADetails([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetPTADetails(schoolAPIParam.asUserId, schoolAPIParam.asAcademicYearId, schoolAPIParam.asSchoolId);
        }

        [HttpPost]
        [Route("Student/GetSubjectTeacher")]
        public GetsubjectTeacher GetSubjectTeacher([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetSubjectTeacher(schoolAPIParam.asUserId, schoolAPIParam.asStandardId, schoolAPIParam.asDivisionId, schoolAPIParam.asAcademicYearId, schoolAPIParam.asSchoolId);
        }

        [HttpPost]
        [Route("Student/GetTimeTable")]
        public GetTimetable GetTimeTable([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetTimeTable(schoolAPIParam.asStandardDivId, schoolAPIParam.asTeacherId, schoolAPIParam.asIsTeacher, schoolAPIParam.asAcademicYearId, schoolAPIParam.asSchoolId);
        }

        [HttpPost]
        [Route("Student/Get")]
        public Getresult Get([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.Get(schoolAPIParam.asSchoolId, schoolAPIParam.asUserId, schoolAPIParam.asRoleId);
        }

        [HttpPost]
        [Route("Student/IsPendingFeesForStudent")]
        public IsPendingfeesforstudent IsPendingFeesForStudent([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.IsPendingFeesForStudent(schoolAPIParam.asStudentId, schoolAPIParam.asAcademicYearId, schoolAPIParam.asSchoolId);
        }

        [HttpPost]
        [Route("Student/GetHomeworkDetails")]
        public GetHomeworkdetails GetHomeworkDetails([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetHomeworkDetails(schoolAPIParam.asSchoolId, schoolAPIParam.asAcademicYearId, schoolAPIParam.asStdDivId, schoolAPIParam.asDate, schoolAPIParam.asLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetHomeworkSubjects")]
        public Gethomeworksubjects GetHomeworkSubjects([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetHomeworkSubjects(schoolAPIParam.asSchoolId, schoolAPIParam.asAcademicYearId, schoolAPIParam.asStdDivId, schoolAPIParam.asDate, schoolAPIParam.asLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetHomework")]
        public Gethomeworkresult GetHomework([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetHomework(schoolAPIParam.asSchoolId, schoolAPIParam.asId, schoolAPIParam.asLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetSiblingList")]
        public Getsiblinglist GetSiblingList([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetSiblingList(schoolAPIParam.asStudentId, schoolAPIParam.asSchoolId, schoolAPIParam.asLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetPayables")]
        public List<string> GetPayables([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetPayables(schoolAPIParam.asSchoolId, schoolAPIParam.asAcademicYearId, schoolAPIParam.asStudentId, schoolAPIParam.asLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetReceiptFileName")]
        public string GetReceiptFileName([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetReceiptFileName(schoolAPIParam.asSchoolId, schoolAPIParam.asReceiptNo, schoolAPIParam.asAcademicYearId, schoolAPIParam.asAccountHeaderId, schoolAPIParam.asIsRefundFee, schoolAPIParam.asStudentId, schoolAPIParam.asSerialNo, schoolAPIParam.asLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetChallanFileName")]
        public string GetChallanFileName([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetChallanFileName(schoolAPIParam.asSchoolId, schoolAPIParam.asAcademicYearId, schoolAPIParam.asStudentId, schoolAPIParam.asPayableFor, schoolAPIParam.asLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetFinancialYear")]
        public FinancialYear GetFinancialYear([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetFinancialYear(schoolAPIParam.aiSchoolId, schoolAPIParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetAllAcademicYearsOfStudent")]
        public GetAcademicYears GetAllAcademicYearsOfStudent([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetAllAcademicYearsOfStudent(schoolAPIParam.aiSchoolId, schoolAPIParam.aiYearwiseStudentId);
        }

        [HttpPost]
        [Route("Student/DisplayGuardianDetails")]
        public DisplayGuardianweb GetDisplayGuardianDetails([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.DisplayGuardianDetails(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiUserId);
        }
        [HttpPost]
        [Route("Student/DisplayGuardianPhotos")]
        public DisplayGuardianPhotoweb GetDisplayGuardianphotos([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.DisplayGuardianphotos(schoolAPIParam.aiUserId, schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.iPhotoTypeId);
        }

        [HttpPost]
        [Route("Student/GuestGuardianPhotos")]
        public DisplayGuardianPhotoweb GetGuestsBinaryPhoto([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GuestsBinaryPhoto(schoolAPIParam.aiGuestId, schoolAPIParam.aiSchoolId);
        }
        [HttpPost]
        [Route("Student/GetAllTestsForStudent")]
        public GetAllTestsForStudentweb GetAllTestsForStudent([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetTestsForStudent(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiStudentId);
        }
        [HttpPost]
        [Route("Student/AllSubjectsForExam")]
        public GetAllSubjectsForExamWeb GetAllSubjectsForExam([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.AllSubjectsForExam(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.asExamId, schoolAPIParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetSupportDetails")]
        public suppotdetails GetSupportDetails([FromBody] SchoolParam userAPIparam)
        {
            return this.student.GetSupportDetails(userAPIparam.aiUserId, userAPIparam.aiSchoolId, userAPIparam.aiAcademicYrId);
        }

        [HttpPost]
        [Route("Student/GetOnlineExamProgressReportDetails")]
        public OnlineExamProgressReportDetails GetOnlineExamProgressReportDetails([FromBody] SchoolParam userAPIparam)
        {
            return this.student.GetOnlineExamProgressReportDetails(userAPIparam.aiSchoolId, userAPIparam.aiAcademicYrId, userAPIparam.asStdDivId, userAPIparam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetQuestionsForOnlineExam")]
        public QuestionsForOnlineExam GetQuestionsForOnlineExam([FromBody] SchoolParam userAPIparam)
        {
            return this.student.GetQuestionsForOnlineExam(userAPIparam.aiSchoolId, userAPIparam.aiAcademicYrId, userAPIparam.asStandardId, userAPIparam.asStdDivId, userAPIparam.asSubjectId, userAPIparam.asSchoolwiseTestId, userAPIparam.asStudentId);
        }


        [HttpPost]
        [Route("SaveFeedbackDetails")]
        public SaveFeedbackDetails SaveFeedbackDetails([FromBody] SchoolParam userAPIparam)
        {
            return this.student.SaveFeedbackDetails(userAPIparam.aiSchoolId, userAPIparam.aiAcademicYrId, userAPIparam.aiFeedbackfor, userAPIparam.aiUserId, userAPIparam.aiFeedbackDescription, userAPIparam.aiFeedbackTypeId, userAPIparam.aiInsertedById, userAPIparam.aiEmail, userAPIparam.aiUserName, userAPIparam.asLogin);
        }
        [HttpPost]
        [Route("SaveStudentDetailsForSupport")]
        public SaveSupportDetails SaveStudentDetailsForSupport([FromBody] MessgCenterParam userAPIparam)
        {
            return this.student.SaveStudentDetailsForSupport(userAPIparam.asUserId, userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asFileName, userAPIparam.asDescription, userAPIparam.asEmailAddress, userAPIparam.asMobileNo, userAPIparam.asSubject, userAPIparam.asBase64URLString);
        }

        [HttpPost]
        [Route("GetAcademicYearsOfStudent")]
        public GetAcademicYearsOfStudent GetAcademicYearsOfStudent([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetAcademicYearsOfStudent(schoolAPIParam.aiSchoolId, schoolAPIParam.asAcademicYearId, schoolAPIParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetUserAadharCardDetails")]
        public GetUserAadharCardDetailsResult GetUserAadharCardDetails(SchoolParam schoolAPIParam)
        {
            return this.student.GetUserAadharCardDetails(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiUserId);
        }

        [HttpPost]
        [Route("Student/SaveUserAadharCardDetails")]
        public SaveUserAadharCardDetailsResult SaveUserAadharCardDetails(UserParam userParam)
        {
            return this.student.SaveUserAadharCardDetails(Convert.ToInt32(userParam.asSchoolId), Convert.ToInt32(userParam.aiUserId), userParam.asAadharCardNo, userParam.asAadharCardFileName, Convert.ToInt32(userParam.asUserRoleId), userParam.asAadharCardBase64String, userParam.asNameOnAadharCard, userParam.asMotherTongue, userParam.asEmailId);
        }

        [HttpPost]
        [Route("Student/GetParentPhotos")]
        public GetParentPhotosResult GetParentPhotos([FromBody] StudentParam studentParam)
        {
            return this.student.GetParentPhoto(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiUserId);
        }

        [HttpPost]
        [Route("Student/SaveParentPhotos")]
        public SaveParentPhotosResult SaveParentPhotos([FromBody] StudentParam studentParam)
        {
            return this.student.SaveParentPhotos(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.asFatherPhotoFileName, studentParam.asMotherPhotoFileName, studentParam.asRelativePhotoFileName, studentParam.asFatherImgPhoto, studentParam.asMotherImgPhoto, studentParam.asLocalGuardianPhoto, studentParam.aiUserId, studentParam.aiIsSubmit, studentParam.asRelativeName, studentParam.abSaveForSibling.ToString());
        }

        [HttpPost]
        [Route("Student/SubmitParentPhotoDetails")]
        public SubmitParentPhotoDetailsResult SubmitParentPhotoDetails([FromBody] StudentParam studentParam)
        {
            return this.student.SubmitParentPhotoDetails(studentParam.aiUserId, studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.abSubmitForSibling);
        }

        [HttpPost]
        [Route("Student/GetAttendanceToppers")]
        public GetAttendanceToppersResult GetAttendanceToppers([FromBody] StudentParam studentParam)
        {
            return this.student.GetAttendanceToppers(studentParam.aiSchoolId.ToString(), studentParam.aiAcademicYearId.ToString(), studentParam.StandardDivisionId, studentParam.TopRanker, studentParam.aiStudentId.ToString());
        }

        [HttpPost]
        [Route("Student/GetAcademicYearsForOldAttendance")]
        public GetAcademicYearsForOldAttendanceResult GetAcademicYearsForOldAttendance([FromBody] StudentParam studentParam)
        {
            return this.student.GetAcademicYearsForOldAttendance(studentParam.aiSchoolId.ToString(), studentParam.aiStudentId.ToString(), studentParam.abIncludeCurrentYear);
        }

        [HttpPost]
        [Route("Student/GetITRFileName")]
        public string GetITRFileName([FromBody] StudentParam studentParam)
        {
            return this.student.GetITRFileName(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStudentId.ToString(), studentParam.aiFinancialStartYear, studentParam.SelectAcademicYearId, studentParam.ITRCategoryId, studentParam.aiLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetStudentPhoto")]
        public GetStudentPhotoResult GetStudentPhoto([FromBody] StudentParam studentParam)
        {
            return this.student.GetStudentPhoto(studentParam.aiSchoolId, studentParam.aiUserId, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/DeleteStudentPhoto")]
        public DeleteStudentPhotoDetailsResult DeleteStudentPhoto([FromBody] StudentParam studentParam)
        {
            return this.student.DeleteStudentPhoto(studentParam.aiSchoolId, studentParam.aiUpdatedById, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/SaveStudentPhoto")]
        public SaveStudentPhotoResult SaveStudentPhoto([FromBody] StudentParam studentParam)
        {
            return this.student.SaveStudentPhoto(studentParam.aiSchoolId, studentParam.aiStudentId, studentParam.aiInsertedById, studentParam.asPhotoBase64String);
        }

        [HttpPost]
        [Route("Student/SubmitStudentPhoto")]
        public SubmitStudentPhotoDetailResult SubmitStudentPhotoDetails([FromBody] StudentParam studentParam)
        {
            return this.student.SubmitStudentPhotoDetails(studentParam.aiStudentId, studentParam.aiUpdatedById, studentParam.aiSchoolId, studentParam.aiAcademicYearId);
        }

        [HttpPost]
        [Route("Student/SubmitOnlineExam")]
        public SubmitStudentOnlineExamResult SubmitStudentOnlineExamDetails([FromBody] StudentParam studentParam)
        {
            return this.student.SubmitStudentOnlineExamDetails(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStandardId, studentParam.aiStandardDivisionId, studentParam.aiSubjectId, studentParam.aiExamId, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetTransportCommitteeDetails")]
        public GetTransportCommitteeResult GetTransportCommitteeDetails([FromBody] StudentParam studentParam)
        {
            return this.student.GetTransportCommitteeDetails(studentParam.aiUserId, studentParam.aiAcademicYearId, studentParam.aiSchoolId);
        }

        [HttpPost]
        [Route("Student/GetDatewiseHomeworkDetails")]
        public GetDatewiseHomeworkDetailsResult GetDatewiseHomeworkDetails([FromBody] StudentParam studentParam)
        {
            return this.student.GetDatewiseHomeworkDetails(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStandardDivisionId, studentParam.asStartDate, studentParam.asEndDate);
        }

        //[HttpPost]
        //[Route("Student/GetFeeDetailsOfOldAcademic")]
        //public Getfeedetails GetFeeDetailsOfOldAcademic([FromBody] SchoolParam schoolParam)
        //{
        //    return this.student.GetFeeDetailsOfOldAcademic(schoolParam.aiSchoolId.ToInt(), schoolParam.aiStudentId.ToInt(), schoolParam.aiAcademicYearId);
        //}

        [HttpPost]
        [Route("Student/SaveOnlineExamDetails")]
        public SaveOnlineExamDetailsResult SaveOnlineExamDetails([FromBody] StudentParam studentParam)
        {
            return this.student.SaveOnlineExamDetails(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStandardId, studentParam.aiStandardDivisionId, studentParam.aiSubjectId, studentParam.aiExamId, studentParam.aiStudentId, studentParam.alstQuestAnswerDetails, studentParam.aiInsertedById, studentParam.aiTotalMarks, studentParam.aiOutOfMarks, studentParam.asAttachmentBase64String);
        }

        [HttpPost]
        [Route("Student/GetInternalFeeDetails")]
        public GetInternalFeeDetailsResult GetInternalFeeDetails([FromBody] StudentParam studentParam)
        {
            return this.student.GetInternalFeeDetails(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStudentId, studentParam.abIsNextYearFeePayment);
        }

        [HttpPost]
        [Route("Student/GetNextYearDetails")]
        public GetNextYearDetailsResult GetNextYearDetails([FromBody] StudentParam studentParam)
        {
            return this.student.GetNextYearDetails(studentParam.aiSchoolId, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetNextYearFeeDetails")]
        public GetNextYearFeeDetailsResult GetNextYearFeeDetails([FromBody] StudentParam studentParam)
        {
            return this.student.GetNextYearFeeDetails(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiSchoolwiseStudentId, studentParam.aiStandardId);
        }

        [HttpPost]
        [Route("Student/GetOldStudentDetails")]
        public GetOldStudentDetailsResult GetOldStudentDetails([FromBody] StudentParam studentParam)
        {
            return this.student.GetOldStudentDetails(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetFeeStructureLinks")]
        public GetFeeStructureLinksResult GetFeeStructureLinks([FromBody] StudentParam studentParam)
        {
            return this.student.GetFeeStructureLinks(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiUserId, studentParam.abShowFeeStructureForNextYear);
        }

        [HttpPost]
        [Route("Student/GetStudentDailyLogDetails")]
        public GetStudentDailyLogResult GetStudentDailyLogDetails([FromBody] StudentParam studentParam)
        {
            return this.student.GetStudentDailyLogDetails(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStandardDivisionId, studentParam.aiMonthId, studentParam.asYear);
        }

        [HttpPost]
        [Route("Student/GetStaffDetailsForlogin")]
        public GetStaffDetailsForLoginResult GetStaffDetailsForlogin([FromBody] StudentParam studentParam)
        {
            return this.student.GetStaffDetailsForlogin(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiYearwiseStudentId, studentParam.aiUserId);
        }

        [HttpPost]
        [Route("Student/GetAcademicYearsforFeeChallan")]
        public AcademicYearsforFeeChallanResult GetAcademicYearsforFeeChallan([FromBody] StudentParam studentParam)
        {
            return this.student.GetAcademicYearsforFeeChallan(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetDetailsForChallanImport")]
        public DetailsForChallanImport GetDetailsForChallanImport([FromBody] StudentParam studentParam)
        {
            return this.student.GetDetailsForChallanImport(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiSelectedAcademicYearId, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetAllFeeTypesForChallanImport")]
        public FeeTypesForChallanImportResult GetAllFeeTypesForChallanImport([FromBody] StudentParam studentParam)
        {
            return this.student.GetAllFeeTypesForChallanImport(studentParam.aiSchoolId, studentParam.aiSelectedAcademicYearId, studentParam.aiStandardDivisionId, studentParam.aiStandardId);
        }

        [HttpPost]
        [Route("Student/GetAllPayableforChallan")]
        public PayableforChallanResult GetAllPayableforChallan([FromBody] StudentParam studentParam)
        {
            return this.student.GetAllPayableforChallan(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStandardId, studentParam.aiOriginalFeeTypeId);
        }

        [HttpPost]
        [Route("Student/GetFileNameForSNSChallan")]
        public string GetFileNameForSNSChallan([FromBody] StudentParam studentParam)
        {
            return this.student.GetFileNameForSNSChallan(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStandardId, studentParam.aiStandardDivisionId, studentParam.aiSchoolwiseStudentId, studentParam.aiFeeTypeId, studentParam.asPayableFor, studentParam.aiSelectedAcademicYearId, studentParam.aiLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetAllAcademicYearsForInternalFee")]
        public AcademicYearsForInternalFeeResult GetAllAcademicYearsForInternalFee([FromBody] SchoolParam schoolAPIParam)
        {
            return this.student.GetAllAcademicYearsForInternalFee(schoolAPIParam.aiSchoolId, schoolAPIParam.aiYearwiseStudentId);
        }

        [HttpPost]
        [Route("Student/GetFileNameForProgressReport")]
        public FileNameForProgressReportResult GetFileNameForProgressReport([FromBody] StudentParam studentParam)
        {
            return this.student.GetFileNameForProgressReport(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStandardId, studentParam.aiStandardDivisionId, studentParam.aiStudentId, studentParam.aiTermId, studentParam.aiLoginUserId);
        }

        [HttpPost]
        [Route("Student/GetAcademicYearsForProgressReport")]
        public AcademicYearsForProgressReportResult GetAcademicYearsForProgressReport([FromBody] StudentParam studentParam)
        {
            return this.student.GetAcademicYearsForProgressReport(studentParam.aiSchoolId, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetTermsForProgressReport")]
        public TermsForProgressReportResult GetTermsForProgressReport([FromBody] StudentParam studentParam)
        {
            return this.student.GetTermsForProgressReport(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetCautionMoneyReceiptFileName")]
        public string GetCautionMoneyReceiptFileName([FromBody] StudentParam studentParam)
        {
            return this.student.GetCautionMoneyReceiptFileName(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiStudentId);
        }

        [HttpPost]
        [Route("Student/GetInternalFeeReceiptFileName")]
        public string GetInternalFeeReceiptFileName([FromBody] StudentParam studentParam)
        {
            return this.student.GetInternalFeeReceiptFileName(studentParam.aiSchoolId, studentParam.aiAcademicYearId, studentParam.aiSchoolwiseStudentId, studentParam.asReceiptNo, studentParam.aiInternalFeeDetailsId, studentParam.abIsNextYearPayment, studentParam.aiSerialNumber);
        }
    }
}
