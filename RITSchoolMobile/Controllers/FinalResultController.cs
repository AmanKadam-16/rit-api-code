using SchoolMobileEntities;
using SchoolMobileInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.UI.WebControls;
using Utility;
using static SchoolMobileEntities.DevsionNameDetiles;
using static Utility.Constants;

namespace RITSchoolMobile.Controllers
{
    public class FinalResultController : ApiController
    {
        private readonly IFinalResult teacher;

        public FinalResultController(IFinalResult teacher)
        {
            this.teacher = teacher;
        }


        //Start Your Controller Code from Here
        //Publish button
        [HttpPost]
        [Route("Teacher/IsAllConffguredTestPublished")]
        public string IsAllConffguredTestPublished([FromBody] UserParam userAPIparam)
        {
            return this.teacher.IsAllConffguredTestPublished(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId);
        }

        //show

        [HttpPost]
        [Route("Teacher/GetStudentResult")]
        public List<GetStudentResultMaster> GetStudentResult([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentResult(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId, userAPIparam.asStudentsIds,  userAPIparam.asWithGrace);
        }
        //Preprimaryprogress Report
        [HttpPost]
        [Route("Teacher/GetClassTeacherXseedSubjects")]
        public GetClassTeacherXseedSubjectsMaster GetClassTeacherXseedSubjects([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassTeacherXseedSubjects(userAPIparam.asSchoolId, userAPIparam.asAcadmeicYearId, userAPIparam.asStdDivId, userAPIparam.asAssessmentId);
        }

        //AddharCard  view Detiles API
        [HttpPost]
        [Route("Teacher/GetUserDetailsForAadharCardNo")]
        public List<GetUserDetailsForAadharCardNo> GetUserDetailsForAadharCardNo([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetUserDetailsForAadharCardNo(userAPIparam.asSchoolId, userAPIparam.asUserId);
        }

        // progress Report show single student
        [HttpPost]
        [Route("Teacher/StudentProgressReport")]
        public StudentProgressReportMaster StudentProgressReport([FromBody] UserParam userAPIparam)
        {
            return this.teacher.StudentProgressReport(userAPIparam.asSchoolId, userAPIparam.asAcadmeicYearId, userAPIparam.asStudentId, userAPIparam.asUserId);
        }


        //Investment Declaration ---SubmitInvestmentDetails

        [HttpPost]
        [Route("Teacher/SubmitInvestmentDetails")]
        public string SubmitInvestmentDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.SubmitInvestmentDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asFinancialYearId, UserParamFinalResult.asUserId, UserParamFinalResult.asUpdatedById);
        }

        //Investment Declaration --SaveInvestmentDetails
        [HttpPost]
        [Route("Teacher/SaveInvestmentDetails")]
        public string SaveInvestmentDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.SaveInvestmentDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asFinancialYearId, UserParamFinalResult.asUpdatedById, UserParamFinalResult.asUserId, UserParamFinalResult.asDeclarationXML, UserParamFinalResult.asRegimeId);
        }
        //progress report show all student mark API

        [HttpPost]
        [Route("Teacher/GetAllStudentsProgressSheet")]
        public GetAllStudentsProgressSheetResultMaster GetAllStudentsProgressSheetResult([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetAllStudentsProgressSheetResult(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asStdDivId);
        }
        //Get All Class Teachers Name
        [HttpPost]
        [Route("Teacher/GetAllPrimaryClassTeacherss")]
        public List<AllPrimaryTeacherNames> GetAllPrimaryClassTeacherss([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetAllPrimaryClassTeacherss(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId , UserParamFinalResult.asTeacher_id);
        }
        // exam result greads API
        [HttpPost]
        [Route("Teacher/GetAllGradesForStandard")]
        public List<AllGradesDetails> GetAllGradesForStandard([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetAllGradesForStandard(UserParamFinalResult.asSchool_Id, UserParamFinalResult.asAcademic_Year_Id, UserParamFinalResult.asStandard_Id, UserParamFinalResult.asSubjectId, UserParamFinalResult.asTest_Id);
        }
        // Exam Result Remark Categeory API
        [HttpPost]
        [Route("Teacher/GetRemarksCategory")]
        public List<RemarksCategory> GetRemarksCategory([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetRemarksCategory(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId);
        }
        // Exam Result RemarkTemplate API
        [HttpPost]
        [Route("Teacher/GetRemarkTemplateDetails")]
        public List<GetRemarkTemplate> GetRemarkTemplateDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetRemarkTemplateDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asRemarkId, UserParamFinalResult.asSortExpression, UserParamFinalResult.asSortDirection, UserParamFinalResult.asFilter, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asMarksGradesConfigurationDetailsId, UserParamFinalResult.asStandardId);
        }

        //Delete Addharcardcopypath
        [HttpPost]
        [Route("Teacher/DeleteAadharCardPhotoCopy")]
        public string DeleteAadharCardPhotoCopy([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteAadharCardPhotoCopy(UserParamFinalResult.asUserId, UserParamFinalResult.asSchoolId , UserParamFinalResult.asUpdatedById);
        }
        //Weeckly time table---Devison name
        [HttpPost]
        [Route("Teacher/DevsionNameDetiles")]
        public DevsionNameDetiles DevsionNameDetiles([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DevsionNameDetiles(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId , UserParamFinalResult.asStandard_Id);
        }
        // Weeckly Time Table --Techer & Standard
        [HttpPost]
        [Route("Teacher/TeacherAndStandardForTimeTable")]
        public GetTeacherAndStandardForTimeTableMaster GetTeacherAndStandardForTimeTable([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetTeacherAndStandardForTimeTable(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asTeacher_id);
        }
        // Weeckly time table ---ReseTTime table
        [HttpPost]
        [Route("Teacher/ResetTimetable")]
        public string ResetTimetable([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.ResetTimetable(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asTeacher_id, UserParamFinalResult.asStandardDivision_Id);
        }
        //Weeckly time table---GetLectureCountsForTeacherss
        [HttpPost]
        [Route("Teacher/GetLecturesCountsForTeacher")]
        public List<GetLecturesCountsForTeacher> GetLecturesCountsForTeacher([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetLecturesCountsForTeacher(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asTeacherId, UserParamFinalResult.asConsiderAssembly, UserParamFinalResult.asConsiderMPT, UserParamFinalResult.asConsiderStayback, UserParamFinalResult.asConsiderWeeklyTest);
        }
        //weeckly time table-AdditionalClasses
        [HttpPost]
        [Route("Teacher/AdditionalClasses")]
        public AdditionalClassesMaster AdditionalClasses([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.AdditionalClasses(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearID, UserParamFinalResult.asTeacher_Id, UserParamFinalResult.asStandardDivision_Id);
        }
        //weeckly time table--DeleteAdditionalLecture
        [HttpPost]
        [Route("Teacher/DeleteAdditionalLecture")]
        public string DeleteAdditionalLecture([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteAdditionalLecture(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asTeacherId, UserParamFinalResult.asStayBack, UserParamFinalResult.asMPTweekday, UserParamFinalResult.asMPTLectNo, UserParamFinalResult.asAssemblyDay, UserParamFinalResult.asAssemblyLecNo);
        }
        //Weeckly time table---GetTeacherSubjectDetails
        [HttpPost]
        [Route("Teacher/GetTeacherSubjectDetails")]
        public List<GetTeacherSubjectDetails> GetTeacherSubjectDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetTeacherSubjectDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId);
        }
        //weeckly  timetable --Display_Student_TimeTable
        [HttpPost]
        [Route("Teacher/Display_Student_TimeTable")]
        public DisplayStudentTimeTablemaster DisplayStudentTimeTable([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.DisplayStudentTimeTable(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asStandardDivision_Id);
        }
        // dashbord upcoming event
        [HttpPost]
        [Route("Teacher/GetUpcomingEvents")]
        public List<GetUpcomingEvents> GetUpcomingEvents([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetUpcomingEvents(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asUserId,UserParamFinalResult.asUserRoleId, UserParamFinalResult.asScreenFullAccess);
        }
        // lession plan
        [HttpPost]
        [Route("Teacher/GetLessonPlanConfigDetailss")]
        public GetLessonPlanConfigDetailsMasters GetLessonPlanConfigDetailss([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetLessonPlanConfigDetailss(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asUserId, UserParamFinalResult.asReportingUserId, UserParamFinalResult.asStartIndex, UserParamFinalResult.asEndIndex,  UserParamFinalResult.asRecordCount, UserParamFinalResult.asStartDate, UserParamFinalResult.asEndDate);
        }
        // Dashboard--Unread message
        [HttpPost]
        [Route("Teacher/GetUnreadMessages")]
        public GetUnreadMessagesMaster GetUnreadMessages([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetUnreadMessages(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asReceiverId, UserParamFinalResult.asReceiverRoleId, UserParamFinalResult.asProfilePicUpdateDate);
        }
        // Dashboard ---PhotoAlbum web
        [HttpPost]
        [Route("Teacher/GetPhotoAlumbs")]
        public GetPhotoAlumbs GetPhotoAlumbs([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetPhotoAlumbs(UserParamFinalResult.asSchoolId, UserParamFinalResult.asMonth, UserParamFinalResult.asYear);
        }
        [HttpPost]
        [Route("Teacher/GetPrePrimaryProgressSheetStatus")]
        public string GetPrePrimaryProgressSheetStatus([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetPrePrimaryProgressSheetStatus(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStdDivId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asTest_Id);
        }
        [HttpPost]
        [Route("Teacher/PublishUnpublishExamResult")]
        public string PublishUnpublishExamResult([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.PublishUnpublishExamResult(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStdDivId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asTest_Id, UserParamFinalResult.asUnpublishReason, UserParamFinalResult.asPublishById);
        }
        [HttpPost]
        [Route("Teacher/GetLessonPlanRecordCount")]
        public GetLessonPlanRecordCount GetLessonPlanRecordCount([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetLessonPlanRecordCount(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asUserId, UserParamFinalResult.asReportingUserId, UserParamFinalResult.asStartIndex, UserParamFinalResult.asEndIndex, UserParamFinalResult.asStartDate, UserParamFinalResult.asEndDate);
        }
        [HttpPost]
        [Route("Teacher/UpdateReadSuggestion")]
        public string UpdateReadSuggestion([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.UpdateReadSuggestion(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asUpdatedById, UserParamFinalResult.asUserId, UserParamFinalResult.asStartDate, UserParamFinalResult.asEndDate);
        }
        [HttpPost]
        [Route("Teacher/IsTestPublishedForStdDiv")]
        public bool IsTestPublishedForStdDiv([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.IsTestPublishedForStdDiv(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asStdDivId);
        }
        [HttpPost]
        [Route("Teacher/IsResultPublishedForStdDiv")]
        public bool IsResultPublishedForStdDiv([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.IsResultPublishedForStdDiv(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asStdDivId);
        }
        [Route("Teacher/IsAtleastOneResultGeneratedForStdDiv")]
        public IsAtleastOneResultGeneratedForStdDiv IsAtleastOneResultGeneratedForStdDiv([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.IsAtleastOneResultGeneratedForStdDiv(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asStdDivId,UserParamFinalResult.asStandardId);
        }

        [HttpPost]
        [Route("Teacher/GetStudentsForNonXseedSubjects")]
        public List<GetStudentsForNonXseedSubjects> GetStudentsForNonXseedSubjects([FromBody] UserParam UserParamFinalResult)
        {
            return this.teacher.GetStudentsForNonXseedSubjects(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStandardDivisionId, UserParamFinalResult.asAssessmentId, UserParamFinalResult.asSubjectId);
        }

        [HttpPost]
        [Route("Teacher/GetStudentsForStdDevMasters")]
        public GetStudentsForStdDevMasters GetStudentsForStdDev([FromBody] UserParam UserParamFinalResult)
        {
            return this.teacher.GetStudentsForStdDev(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStandardDivisionId, UserParamFinalResult.asAssessmentId, UserParamFinalResult.asSubjectId);
        }

        [HttpPost]
        [Route("Teacher/SaveNonXseedSubGrades")]
        public string SaveNonXseedSubGrades([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.SaveNonXseedSubGrades(UserParamFinalResult.asXseedGradesXML, UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asAssessmentId,  UserParamFinalResult.asStandardDivId, UserParamFinalResult.asSubjectId, UserParamFinalResult.asInsertedById, UserParamFinalResult.asUpdatedById);
        }

        [HttpPost]
        [Route("Teacher/GetTimeTableForClass")]
        public GetTimeTableForClassMaster GetTimeTableForClass([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetTimeTableForClass(UserParamFinalResult.asSchool_Id, UserParamFinalResult.asAcademicYear_ID, UserParamFinalResult.asStandardDivisionId);
        }

        [HttpPost]
        [Route("Teacher/GetTeacherSubjectMaxLecDetails")]
        public GetTeacherSubjectMaxLecDetailsMaster GetTeacherSubjectMaxLecDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetTeacherSubjectMaxLecDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asTeacherId, UserParamFinalResult.asStandardDivId);
        }

        [HttpPost]
        [Route("Teacher/GetStudentRecordComment")]
        public GetStudentRecordComment GetStudentRecordComment([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetStudentRecordComment(UserParamFinalResult.asSchoolId, UserParamFinalResult.asSchoolwiseStudentId, UserParamFinalResult.asCommentId);
        }
        //Studentwise Progress Report
        [HttpPost]
        [Route("Teacher/GetStandardwiseAssessmentDetails")]
        public StandardwiseAssessmentMaster GetStandardwiseAssessmentDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetStandardwiseAssessmentDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStandardId);
        }

        [HttpPost]
        [Route("Teacher/GetProgressReportDetails")]
        public GetProgressReportMaster GetProgressReportDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetProgressReportDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStandardDivisionId, UserParamFinalResult.asYearwiseStudentId, UserParamFinalResult.asAssessmentId);
        }
        // Save Studentwise Progress Report
        [HttpPost]
        [Route("Teacher/ManageStudentWiseAssessmentGrades")]
        public string ManageStudentWiseAssessmentGrades([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.ManageStudentWiseAssessmentGrades(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asYearwiseStudentId, UserParamFinalResult.asStandardDivisionId, UserParamFinalResult.asAssessmentId, UserParamFinalResult.asInsertedById, UserParamFinalResult.asLearningOutcomeXML, UserParamFinalResult.asXseedGradesXML, UserParamFinalResult.asMode, UserParamFinalResult.asRemark, UserParamFinalResult.asSubjectRemarkXML);
        }
        // Performance Evaluation
        [HttpPost]
        [Route("Teacher/PublishStaffPerformanceDetails")]
        public string PublishStaffPerformanceDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.PublishStaffPerformanceDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asUserId, UserParamFinalResult.asReportingUserId, UserParamFinalResult.asYear, UserParamFinalResult.asIsPublish, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asEffectiveDate, UserParamFinalResult.asLastIncrementDate);
        }

        [HttpPost]
        [Route("Teacher/DeleteAdditionalLectures")]
        public string DeleteAdditionalLectures([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.DeleteAdditionalLectures(UserParamFinalResult.asSchoolId,UserParamFinalResult.asDetailID);
        }

        [HttpPost]
        [Route("Teacher/GetNoticeAndEventDetails")]
        public GetNoticeAndEventDetails GetNoticeAndEventDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetNoticeAndEventDetails(UserParamFinalResult.asDisplayLocation, UserParamFinalResult.asShowAllNotices, UserParamFinalResult.asSchoolId, UserParamFinalResult.asSortExpression, UserParamFinalResult.asStartIndex, UserParamFinalResult.asEndIndex, UserParamFinalResult.asLoginUserRoleId);
        }
        //Duplicate School Notice Name
        [HttpPost]
        [Route("Teacher/GetSchoolNoticeIdByName")]
        public SchoolNoticeIdByName GetNoticeIdByName([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetNoticeIdByName(UserParamFinalResult.asSchoolId, UserParamFinalResult.asNoticeName, UserParamFinalResult.asStartDate, UserParamFinalResult.asEndDate);
        }
        //Check Duplicate Lecture 
        [HttpPost]
        [Route("Teacher/CheckDuplicateLecturesMsg")]
        public CheckDuplicateLecturesMsg CheckDuplicateLectures([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.CheckDuplicateLectures(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asSubjectId, UserParamFinalResult.asTeacherId, UserParamFinalResult.asStdDivId, UserParamFinalResult.asLectureNo, UserParamFinalResult.asWeekDayId);
        }
        [HttpPost]
        [Route("Teacher/OptionalSubjectLectures")]
        public OptionalLecturesMaster OptionalSubjectLectures([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.OptionalSubjectLectures(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearID, UserParamFinalResult.asTeacher_Id, UserParamFinalResult.asStandardDivision_Id);
        }
        //Students Base Page
        [HttpPost]
        [Route("Teacher/GetStandardDivisionOfTeacher")]
        public List<StandardDivisionOfTeacher> GetStandardDivisionOfTeacher([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetStandardDivisionOfTeacher(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademic_Year_Id, UserParamFinalResult.asTeacher_Id);
        }
        //Student List
        [HttpPost]
        [Route("Teacher/StudentsList")]
        public List<StudentsList> StudentsList([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.StudentsList(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asStandard_Id, UserParamFinalResult.asDivision_Id, UserParamFinalResult.asSchoolWise_Standard_Division_Id, UserParamFinalResult.asStartIndex, UserParamFinalResult.asEndIndex, UserParamFinalResult.asSortExpression);
        }
        //SMS CENTER new API
        [HttpPost]
        [Route("Teacher/SMSCenterList")]
        public List<SMSCenterList> SMSCenterList([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.SMSCenterList(UserParamFinalResult.asSchoolId, UserParamFinalResult.asUserId, UserParamFinalResult.asReceiverUserRoleId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStartIndex, UserParamFinalResult.asPageSize, UserParamFinalResult.asSearchText, UserParamFinalResult.asSortExp);
        }
        //Students Edit Page
        [HttpPost]
        [Route("Teacher/MasterDatastudent")]
        public MasterDatastudent MasterDatastudent([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.MasterDatastudent(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStandardId, UserParamFinalResult.asDivisionId);
        }
        [HttpPost]
        [Route("Teacher/GetStudentAdditionalDetails")]
        public GetStudentAdditionalDetails GetStudentAdditionalDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetStudentAdditionalDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId);
        }
        [HttpPost]
        [Route("Teacher/GetAcademicDatesForStandard")]
        public GetAcademicDatesForStandard GetAcademicDatesForStandard([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetAcademicDatesForStandard(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearID, UserParamFinalResult.asStandardId);
        }
        [HttpPost]
        [Route("Teacher/GetStudentDataForAutoSearch")]
        public List<GetStudentDataForAutoSearch> GetStudentDataForAutoSearch([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetStudentDataForAutoSearch(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asYearwiseStudentIds);
        }
        //Add Additional
        [HttpPost]
        [Route("Teacher/AddStudentAdditionalDetails")]
        public string AddStudentAdditionalDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.AddStudentAdditionalDetails(UserParamFinalResult.asSchoolId,UserParamFinalResult.asStudentStatusId, UserParamFinalResult.asAdmissionAcadmicYear, UserParamFinalResult.asAdmissionStandard, UserParamFinalResult.asCurrentAcademicYear, UserParamFinalResult.asCurrentStandard,
UserParamFinalResult.asIsHandicapped, UserParamFinalResult.asPreviousMarksObtained, UserParamFinalResult.asPreviousMarksOutOff, UserParamFinalResult.asPreviousYearOfPassing, UserParamFinalResult.asSubjectNames, UserParamFinalResult.asSchoolwiseStudentId, UserParamFinalResult.asUserid,
UserParamFinalResult.asReligion, UserParamFinalResult.asBirthTaluka, UserParamFinalResult.asBirthDistrict, UserParamFinalResult.asHouseNoPlotNo, UserParamFinalResult.asMainArea, UserParamFinalResult.asSubareaName, UserParamFinalResult.asLandmark, UserParamFinalResult.asTaluka, UserParamFinalResult.asDistrict,
UserParamFinalResult.asFeeAreaName, UserParamFinalResult.asFatherOccupation, UserParamFinalResult.asFatherQualification, UserParamFinalResult.asFatherEmail, UserParamFinalResult.asFatherOfficeName, UserParamFinalResult.asFatherOfficeAddress, UserParamFinalResult.asMotherOccupation,
UserParamFinalResult.asMotherQualification, UserParamFinalResult.asMotherEmail, UserParamFinalResult.asMotherOfficeName, UserParamFinalResult.asMotherOfficeAddress, UserParamFinalResult.asFatherDOB, UserParamFinalResult.asMotherDOB, UserParamFinalResult.asFatherDesignation,
UserParamFinalResult.asMotherDesignation, UserParamFinalResult.asFatherPhoto, UserParamFinalResult.asMotherPhoto, UserParamFinalResult.asAnniversaryDate, UserParamFinalResult.asLocalGuardianPhoto, UserParamFinalResult.asRelativeName, UserParamFinalResult.asFatherBinaryPhoto, UserParamFinalResult.asMotherBinaryPhoto, UserParamFinalResult.asRelativeBinaryPhoto,
UserParamFinalResult.asFatherWeight, UserParamFinalResult.asMotherWeight, UserParamFinalResult.asFatherHeight, UserParamFinalResult.asMotherHeight, UserParamFinalResult.asFatherAadharcardNo, UserParamFinalResult.asMotherAadharcardNo, UserParamFinalResult.asFatherBloodGroup, UserParamFinalResult.asMotherBloodGroup,
UserParamFinalResult.asFamilyMonthlyIncome, UserParamFinalResult.asCWSN, UserParamFinalResult.asFatherAnnualIncome, UserParamFinalResult.asMotherAnnualIncome, UserParamFinalResult.asBirthState, UserParamFinalResult.asName1, UserParamFinalResult.asAge1, UserParamFinalResult.asInstitute1, UserParamFinalResult.asStandard1, UserParamFinalResult.asName2,
UserParamFinalResult.asAge2, UserParamFinalResult.asInstitute2, UserParamFinalResult.asStandard2, UserParamFinalResult.asResidenceType, UserParamFinalResult.asRFID, UserParamFinalResult.asPENNumber,
UserParamFinalResult.asSaveFeature, UserParamFinalResult.asFolderName);
        }

        [HttpPost]
        [Route("Teacher/GetNextStudentRollAndLogin")]
        public GetNextStudentRollAndLogin GetNextStudentRollAndLogin([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetNextStudentRollAndLogin(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStandardId, UserParamFinalResult.asDivisionId);
        }

        [HttpPost]
        [Route("Teacher/GetStudentsSiblingDetail")]
        public List<GetStudentsSiblingDetail> GetStudentsSiblingDetail([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetStudentsSiblingDetail(UserParamFinalResult.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/CheckIsRollNumberDuplicate")]
        public bool CheckIsRollNumberDuplicate([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.CheckIsRollNumberDuplicate(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asStandardId, UserParamFinalResult.asDivisionId,UserParamFinalResult.asRollNo, UserParamFinalResult.asStudentId);
        }
        [HttpPost]
        [Route("Teacher/IsRegisterNoAlreadyPresent")]
        public bool IsRegisterNoAlreadyPresent([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.IsRegisterNoAlreadyPresent(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.asEnrolment_Number);
        }
        [HttpPost]
        [Route("Teacher/IsGeneralRegisterNoAlreadyPresent")]
        public bool IsGeneralRegisterNoAlreadyPresent([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.IsGeneralRegisterNoAlreadyPresent(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.asGRNumber);
        }
        [HttpPost]
        [Route("Teacher/IsStudentUniqueNoAlreadyPresent")]
        public bool IsStudentUniqueNoAlreadyPresent([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.IsStudentUniqueNoAlreadyPresent(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.asStudentUniqueNo);
        }
        [HttpPost]
        [Route("Teacher/CheckIsRFormNumberDuplicate")]
        public bool CheckIsRFormNumberDuplicate([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.CheckIsRFormNumberDuplicate(UserParamFinalResult.asSchoolId, UserParamFinalResult.asFormNumber, UserParamFinalResult.asStudentId);
        }
        [HttpPost]
        [Route("Teacher/UpdateStudentTrackingDetails")]
        public string UpdateStudentTrackingDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.UpdateStudentTrackingDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.asInsertedById, UserParamFinalResult.asID, UserParamFinalResult.asAcademicYearId);
        }
        [HttpPost]
        [Route("Teacher/UpdateStudent")]
        public UpdateStudentResult UpdateStudent([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.UpdateStudent(UserParamFinalResult.asSchoolId,UserParamFinalResult.asStudentId,UserParamFinalResult.asInsertedById,UserParamFinalResult.asID,UserParamFinalResult.asAcademicYearId,UserParamFinalResult.asFormNumber,
UserParamFinalResult.asPhoto_file_Path, UserParamFinalResult.asFirst_Name,UserParamFinalResult.asMiddle_Name,UserParamFinalResult.asLast_Name,UserParamFinalResult.asMother_Name,UserParamFinalResult.asBlood_Group,UserParamFinalResult.asEnrolment_Number,UserParamFinalResult.asParent_Name,
UserParamFinalResult.asParent_Occupation,UserParamFinalResult.asOther_Occupation,UserParamFinalResult.asAddress,UserParamFinalResult.asCity,UserParamFinalResult.asState,UserParamFinalResult.asPincode,UserParamFinalResult.asResidence_Phone_Number,
UserParamFinalResult.asMobile_Number,UserParamFinalResult.asMobile_Number2,UserParamFinalResult.asOffice_Number,UserParamFinalResult.asNeighbour_Number,UserParamFinalResult.asUpdated_By_Id,UserParamFinalResult.asUpdate_Date,
UserParamFinalResult.asDOB,UserParamFinalResult.asBirth_Place,UserParamFinalResult.asNationality,UserParamFinalResult.asSex,UserParamFinalResult.asSalutation_Id,UserParamFinalResult.asCategory_Id,UserParamFinalResult.asCasteAndSubCaste,
UserParamFinalResult.asAdmission_Date,UserParamFinalResult.asJoining_Date,UserParamFinalResult.asDateOfBirthInText,UserParamFinalResult.asOptional_Subject_Id,UserParamFinalResult.asMother_Tongue,UserParamFinalResult.asLastSchoolName,
UserParamFinalResult.asLastSchoolAddress,UserParamFinalResult.asLastCompletedStd,UserParamFinalResult.asLastSchoolUDISENo,UserParamFinalResult.asLastCompletedBoard,UserParamFinalResult.asIsRecognisedBoard,UserParamFinalResult.asAadharCardNo,
UserParamFinalResult.asNameOnAadharCard, UserParamFinalResult.asAadharCard_Photo_Copy_Path, UserParamFinalResult.asFamily_Photo_Copy_Path, UserParamFinalResult.asUDISENumber, UserParamFinalResult.asBoardRegistrationNo, UserParamFinalResult.asIsRiseAndShine,
UserParamFinalResult.asAdmissionSectionId, UserParamFinalResult.asGRNumber, UserParamFinalResult.asStudentUniqueNo, UserParamFinalResult.asSaralNo, UserParamFinalResult.asIsOnlyChild, UserParamFinalResult.asMinority,
UserParamFinalResult.asRoll_No, UserParamFinalResult.asRule_Id, UserParamFinalResult.asIsStaffKid, UserParamFinalResult.asHeight, UserParamFinalResult.asWeight, UserParamFinalResult.asUpdated_By_id, UserParamFinalResult.asRTECategoryId,
UserParamFinalResult.asSecondLanguageSubjectId, UserParamFinalResult.asThirdLanguageSubjectId,UserParamFinalResult.asIsForDayBoarding, UserParamFinalResult.asFeeCategoryDetailsId, UserParamFinalResult.asRTEApplicationFormNo, UserParamFinalResult.asAnnualIncome,
            UserParamFinalResult.asStandard_Id, UserParamFinalResult.asDivision_Id,
            UserParamFinalResult.asReligion,
            UserParamFinalResult.aiTrackingId,
            UserParamFinalResult.asYearWise_Student_Id,
            UserParamFinalResult.asParentUserId,
            UserParamFinalResult.asStudentEmailAddress, UserParamFinalResult.asUserId, UserParamFinalResult.IsDeleteFee,
            UserParamFinalResult.adtOldJoiningDate,
            UserParamFinalResult.asAadharCardBase64, UserParamFinalResult.asFamilyPhotoBase64, UserParamFinalResult.asSaveFeature, UserParamFinalResult.asFolderName);

        }

        [HttpPost]
        [Route("Teacher/JoiningDateUpdateAttendance")]
        public string JoiningDateUpdateAttendance([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.JoiningDateUpdateAttendance(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStudentId, UserParamFinalResult.asDeleteAttendance);
        }

        [HttpPost]
        [Route("Teacher/UpdateSecondLanguage")]
        public string UpdateSecondLanguage([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.UpdateSecondLanguage(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asUpdatedById, UserParamFinalResult.asXML, UserParamFinalResult.asStandard_Id, UserParamFinalResult.asDivision_Id, UserParamFinalResult.asYearwiseStudentId);
        }
        [HttpPost]
        [Route("Teacher/SaveSwitchLoginDetails")]
        public string SaveSwitchLoginDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.SaveSwitchLoginDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asYearwiseStudentId, UserParamFinalResult.asParentUserId);
        }
        [HttpPost]
        [Route("Teacher/MarkNewStudentsMarks")]
        public string MarkNewStudentsMarks([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.MarkNewStudentsMarks(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asYearwiseStudentId, UserParamFinalResult.asOldJoiningDate, UserParamFinalResult.asInsertedById);
        }

        ///
        [HttpPost]
        [Route("Teacher/GetAllStreams")]
        public List<GetAllStreams> GetAllStreams([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetAllStreams(UserParamFinalResult.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/GetAllGroupsOfStream")]
        public List<GetAllGroupsOfStream> GetAllGroupsOfStream([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetAllGroupsOfStream(UserParamFinalResult.asSchoolId,UserParamFinalResult.asStreamId);
        }
        [HttpPost]
        [Route("Teacher/GetStreamwiseSubjectDetails")]
        public GetStreamwiseSubjectDetailsMaster GetStreamwiseSubjectDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetStreamwiseSubjectDetails(UserParamFinalResult.asSchoolId,UserParamFinalResult.asStreamGroupId, UserParamFinalResult.asAcademicYearId);
        }
        [HttpPost]
        [Route("Teacher/RetriveStudentStreamwiseSubject")]
        public RetriveStudentStreamwiseSubjectMaster RetriveStudentStreamwiseSubject([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.RetriveStudentStreamwiseSubject(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.asAcademicYearId);
        }
        //
        [HttpPost]
        [Route("Teacher/RetriveStudentInfo")]
        public RetrieveStudentModel RetriveStudentInfo([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.RetriveStudentInfo(UserParamFinalResult.asSchoolId, UserParamFinalResult.asYearwiseStudentId);
        }
        [HttpPost]
        [Route("Teacher/GetStandardwiseMinMaxDOB")]
        public List<GetStandardwiseMinMaxDOB> GetStandardwiseMinMaxDOB([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetStandardwiseMinMaxDOB(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStandardId);
        }
        [HttpPost]
        [Route("Teacher/IsOnLeave")]
        public IsOnLeave IsOnLeave([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.IsOnLeave(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asYearwiseStudentId);
        }
        //
        [HttpPost]
        [Route("Teacher/GetAllUserRoles")]
        public List<GetAllUserRoles> GetAllUserRoles([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetAllUserRoles(UserParamFinalResult.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/GetFeeAreaNames")]
        public List<GetFeeAreaNames> GetFeeAreaNames([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetFeeAreaNames(UserParamFinalResult.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/UpdateStudentStreamwiseSubjectDetails")]
        public bool UpdateStudentStreamwiseSubjectDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.UpdateStudentStreamwiseSubjectDetails(UserParamFinalResult.asSchoolId,UserParamFinalResult.asStudentId, UserParamFinalResult.asStreamId, UserParamFinalResult.GroupId, UserParamFinalResult.CompulsorySubject, UserParamFinalResult.chkCompitativeExams, UserParamFinalResult.OptSubjectOne, UserParamFinalResult.OptSubjectTwo);
        }
        [HttpPost]
        [Route("Teacher/DeleteFamilyPhoto")]
        public string DeleteFamilyPhoto([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteFamilyPhoto(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId,  UserParamFinalResult.asUpdatedById);
        }
        [HttpPost]
        [Route("Teacher/DeleteFatherPhoto")]
        public string DeleteFatherPhoto([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteFatherPhoto(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.asUpdatedById);
        }
        [HttpPost]
        [Route("Teacher/DeleteMotherPhoto")]
        public string DeleteMotherPhoto([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteMotherPhoto(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.asUpdatedById);
        }
        [HttpPost]
        [Route("Teacher/DeleteGuardianPhoto")]
        public string DeleteGuardianPhoto([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteGuardianPhoto(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.asUpdatedById);
        }

        //Add Sibling API's
        [HttpPost]
        [Route("Teacher/GetStudentDetailsForSibling")]
        public GetStudentDetails GetStudentDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetStudentDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asYearwiseStudentId);
        }
        [HttpPost]
        [Route("Teacher/GetStudentSiblingList")]
        public List<GetStudentSiblingList> GetStudentSiblingList([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetStudentSiblingList(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asYearwiseStudentId);
        }
        [HttpPost]
        [Route("Teacher/GetStudentsList")]
        public List<GetStudentsList> GetStudentsList([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetStudentsList(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asYearwiseStudentId, UserParamFinalResult.asFilter, UserParamFinalResult.asStartIndex, UserParamFinalResult.asEndIndex, UserParamFinalResult.asSortExpression);
        }
        [HttpPost]
        [Route("Teacher/SaveStudentSiblingDetails")]
        public string SaveStudentSiblingDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.SaveStudentSiblingDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStudentSiblingsXML, UserParamFinalResult.asInsertedById, UserParamFinalResult.asUpdatedById);
        }
        [HttpPost]
        [Route("Teacher/DeleteStudentSiblingDetails")]
        public string DeleteStudentSiblingDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteStudentSiblingDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asYearwiseSiblingStudentId, UserParamFinalResult.asSiblingStudentId);
        }
        [HttpPost]
        [Route("Teacher/OverwriteAllSiblingDetails")]
        public string OverwriteAllSiblingDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.OverwriteAllSiblingDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStudentId, UserParamFinalResult.asMode, UserParamFinalResult.asSiblingId);
        }
        //Progress Report
        [HttpPost]
        [Route("Teacher/GetTeachersForPrePrimaryProgressReport")]
        public List<GetTeachersForPrePrimaryProgressReport> GetTeachersForPrePrimaryProgressReport([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetTeachersForPrePrimaryProgressReport(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asSchoolWise_Standard_Division_Id);
        }
        [HttpPost]
        [Route("Teacher/IsXseedApplicable")]
        public bool IsXseedApplicable([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.IsXseedApplicable(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asStandardId, UserParamFinalResult.asStandardDivisionId);
        }
        //End
        [HttpPost]
        [Route("Teacher/CheckDependenciesForFees")]
        public CheckDependenciesForFeesMaster CheckDependenciesForFees([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.CheckDependenciesForFees(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcadmicYearId, UserParamFinalResult.asReference_Id, UserParamFinalResult.asRecord_Id, UserParamFinalResult.asRecord_Name);
        }
        [HttpPost]
        [Route("Teacher/UpdateEmailAddressOfStudent")]
        public int UpdateEmailAddressOfStudent([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.UpdateEmailAddressOfStudent(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentEmailAddress, UserParamFinalResult.asUpdatedById, UserParamFinalResult.asUserId);
        }
        [HttpPost]
        [Route("Teacher/SaveSubmittedDocuments")]
        public string SaveSubmittedDocuments([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.SaveSubmittedDocuments(UserParamFinalResult.asSchoolId, UserParamFinalResult.asDocXML, UserParamFinalResult.asYearwiseStudentId, UserParamFinalResult.asInsertedById);
        }
        [HttpPost]
        [Route("Teacher/UpdateStudentPhoto")]
        public string UpdateStudentPhoto([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.UpdateStudentPhoto(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.asStudentBinaryPhoto);
        }
        [HttpPost]
        [Route("Teacher/DeleteDayBoardingFees")]
        public string DeleteDayBoardingFees([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteDayBoardingFees(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asSchoolWise_Student_Id, UserParamFinalResult.asUpdatedById);
        }
        [HttpPost]
        [Route("Teacher/DeleteStudentFeeDetails")]
        public string DeleteStudentFeeDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteStudentFeeDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asYearwiseStudentId, UserParamFinalResult.IsNewStudent, UserParamFinalResult.asRule_Id, UserParamFinalResult.asUpdatedById);
        }

        //Send SMS
        [HttpPost]
        [Route("Teacher/GetSchoolUserDetailsSql")]
        public GetSchoolUserDetailsSql GetSchoolUserDetailsSql([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetSchoolUserDetailsSql(UserParamFinalResult.asSchoolId, UserParamFinalResult.asUserId);
        }
        [HttpPost]
        [Route("Teacher/LoadSchoolDetails")]
        public LoadSchoolDetails LoadSchoolDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.LoadSchoolDetails(UserParamFinalResult.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/GetSMSProviderForWebsite")]
        public string GetSMSProviderForWebsite([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetSMSProviderForWebsite(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId);
        }
        [HttpPost]
        [Route("Teacher/SendLoginDetailSMS")]
        public string SendLoginDetailSMS([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.SendLoginDetailSMS(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asUserId, UserParamFinalResult.asYearwiseStudentId, UserParamFinalResult.asMobile_Number, UserParamFinalResult.asMobile_Number2, UserParamFinalResult.SenderUserId, UserParamFinalResult.SenderUserRoleId, UserParamFinalResult.asInsertedById);
        }
        [HttpPost]
        [Route("Teacher/GetUserFeedbackDetails")]
        public List<GetUserFeedbackDetails> GetUserFeedbackDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetUserFeedbackDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asSortDirection, UserParamFinalResult.asSortExpression, UserParamFinalResult.asUserName, UserParamFinalResult.asStartIndex, UserParamFinalResult.asEndIndex);
        }
        [HttpPost]
        [Route("Teacher/SaveSelectedFeedback")]
        public string SaveSelectedFeedback([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.SaveSelectedFeedback(UserParamFinalResult.asSchoolId, UserParamFinalResult.asXML, UserParamFinalResult.aiFlag);
        }
        [HttpPost]
        [Route("Teacher/DeleteFeedbackDetails")]
        public string DeleteFeedbackDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.DeleteFeedbackDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asUserId, UserParamFinalResult.asFeedbackId);
        }
        [HttpPost]
        [Route("Teacher/GetOtherFeedbackDetails")]
        public List<GetOtherFeedbackDetails> GetOtherFeedbackDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetOtherFeedbackDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asFilter);
        }

        [HttpPost]
        [Route("Teacher/SaveOtherFeedback")]
        public string SaveOtherFeedback([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.SaveOtherFeedback(UserParamFinalResult.asSchoolId, UserParamFinalResult.asXML);
        }
        [HttpPost]
        [Route("Teacher/UpdateOtherFeedback")]
        public string UpdateOtherFeedback([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.UpdateOtherFeedback(UserParamFinalResult.asSchoolId, UserParamFinalResult.IsDeleted, UserParamFinalResult.asLinkName, UserParamFinalResult.asFilePath, UserParamFinalResult.asInsertedById, UserParamFinalResult.asLinkId, UserParamFinalResult.asSaveFeature, UserParamFinalResult.asFolderName, UserParamFinalResult.asBase64String);
        }
        [HttpPost]
        [Route("Teacher/InsertOtherFeedbackDetails")]
        public string InsertOtherFeedbackDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.InsertOtherFeedbackDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asLinkName, UserParamFinalResult.asFilePath, UserParamFinalResult.asInsertedById, UserParamFinalResult.asSaveFeature, UserParamFinalResult.asFolderName, UserParamFinalResult.asBase64String);
        }
        [HttpPost]
        [Route("Teacher/GetFeedbackToEdit")]
        public List<GetFeedbackToEdit> GetFeedbackToEdit([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetFeedbackToEdit(UserParamFinalResult.asSchoolId, UserParamFinalResult.asFeedbackId);
        }
        [HttpPost]
        [Route("Teacher/FetchStudentAttendanceForCalender")]
        public FetchStudentAttendanceForCalender FetchStudentAttendanceForCalender([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.FetchStudentAttendanceForCalender(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStandardId, UserParamFinalResult.asDivisionId, UserParamFinalResult.asMonth, UserParamFinalResult.asYear, UserParamFinalResult.asStudentId);
        }
        [HttpPost]
        [Route("Teacher/GetYearwiseStudentId")]
        public GetYearwiseStudentId GetYearwiseStudentId([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetYearwiseStudentId(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStudentId);
        }
        [HttpPost]
        [Route("Teacher/GetPassedAcademicYearss")]
        public List<GetPassedAcademicYearss> GetPassedAcademicYearss([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetPassedAcademicYearss(UserParamFinalResult.asSchoolId, UserParamFinalResult.asStudentId, UserParamFinalResult.abIncludeCurrentYear);
        }
        [HttpPost]
        [Route("Teacher/GetStandardDivisionIdOfYear")]
        public GetStandardDivisionIdOfYear GetStandardDivisionIdOfYear([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetStandardDivisionIdOfYear(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStudentId);
        }
        [HttpPost]
        [Route("Teacher/GetStudentsMonthWiseAttendance")]
        public List<GetStudentsMonthWiseAttendance> GetStudentsMonthWiseAttendance([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetStudentsMonthWiseAttendance(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStandardDivisionId, UserParamFinalResult.asTopRanker, UserParamFinalResult.asStudentId, UserParamFinalResult.asSortExpression, UserParamFinalResult.asStartIndex, UserParamFinalResult.asEndIndex);
        }
        [HttpPost]
        [Route("Teacher/GetStudentsMonthWiseAttendanceDynamic")]
        public List<Dictionary<string, object>> GetStudentsMonthWiseAttendanceDynamic([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.GetStudentsMonthWiseAttendanceDynamic(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asStandardDivisionId, UserParamFinalResult.asTopRanker, UserParamFinalResult.asStudentId, UserParamFinalResult.asSortExpression, UserParamFinalResult.asStartIndex, UserParamFinalResult.asEndIndex);
        }
        [HttpPost]
        [Route("Teacher/AutoSearchUser")]
        public AutoSearchUserMaster AutoSearchUserMaster([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.AutoSearchUserMaster(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asUserRoleId, UserParamFinalResult.asUserId);
        }
        [HttpPost]
        [Route("Teacher/SearchUsers")]
        public AutoSearchUserMaster SearchUsers([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.SearchUsers(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asUserRoleId, UserParamFinalResult.asUserId, UserParamFinalResult.asSearchTerm, UserParamFinalResult.abShowOnlyCoordinator);
        }
        [HttpPost]
        [Route("Teacher/ClearCache")]
        public bool ClearCache([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.ClearCache(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.asUserRoleId, UserParamFinalResult.asUserId);
        }
        [HttpPost]
        [Route("Teacher/GetPreConditionMsg")]
        public List<GetPreConditionMsg> GetPreConditionMsg([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.GetPreConditionMsg(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.aiConfigId);
        }
        [HttpPost]
        [Route("SMS/AbsentStudentSms")]
        public AbsentStudentSmsResponse AbsentStudentSms([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.AbsentStudentSms(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.oAbsentStudentSmsRequest);
        }
        [HttpPost]
        [Route("SMS/HalfDayAbsentStudentSms")]
        public HalfDayAbsentStudentSmsResponse HalfDayAbsentStudentSms([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return this.teacher.HalfDayAbsentStudentSms(UserParamFinalResult.asSchoolId, UserParamFinalResult.asAcademicYearId, UserParamFinalResult.oHalfDayAbsentStudentSmsRequest);
        }
        [HttpPost]
        [Route("Teacher/LoadTeacherPersonalDetails")]
        public TeacherInfoStruct LoadTeacherPersonalDetails([FromBody] UserParamFinalResult UserParamFinalResult)
        {
            return teacher.LoadTeacherPersonalDetails(UserParamFinalResult.asSchoolId, UserParamFinalResult.asTeacherId);
        }
    }
}



   
