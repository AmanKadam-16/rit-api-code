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
using static SchoolMobileEntities.DevsionNameDetiles;
using static Utility.Constants;

namespace RITSchoolMobile.Controllers
{
    public class TeacherController : ApiController
    {
        private readonly ITeacher teacher;

        public TeacherController(ITeacher teacher)
        {
            this.teacher = teacher;
        }
        [HttpPost]
        [Route("Teacher/GetStandardDivisions")]
        public List<StandardDivision> GetStandardDivisions([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStandardDivisions(userAPIparam.asSchoolId, userAPIparam.asAcademicyearId, userAPIparam.asTeacherId);
        }
        [HttpPost]
        [Route("Teacher/GetClassAttendance")]
        public List<StudentAttendance> GetClassAttendance([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassAttendance(userAPIparam.asStdDivId, userAPIparam.asDate, userAPIparam.asAcademicYearId, userAPIparam.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/GetStudentDetails")]
        public List<StudentAttendance> GetStudentDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentDetails(userAPIparam.asStdDivId, userAPIparam.asDate, userAPIparam.asAcademicYearId, userAPIparam.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/SaveStudentAttendanceDetails")]
        public List<AbsentRollNo> SaveStudentAttendanceDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveStudentAttendanceDetails(userAPIparam.asStandardDivisionId, userAPIparam.asDate, userAPIparam.asAbsentRollNos, userAPIparam.asAllPresentOrAllAbsent, userAPIparam.asUserId, userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        [HttpPost]
        [Route("Teacher/GetStaffBirthdaysList")]
        public GetStaffBirthdays GetStaffBirthdaysList([FromBody] SchoolParam schoolAPIParam)
        {
            return this.teacher.GetStaffBirthdaysList(schoolAPIParam.asMonth, schoolAPIParam.asAcademicYearId, schoolAPIParam.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/GetAttendanceStatus")]
        public List<AttendanceStatus> GetAttendanceStatus([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAttendanceStatus(userAPIparam.asAttendanceDate, userAPIparam.asStanardDivisionId, userAPIparam.asAcademicYearId, userAPIparam.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/IsHavingFullAccess")]
        public Constants.AccessRights IsHavingFullAccess([FromBody] UserParam userAPIparam)
        {
            return this.teacher.IsHavingFullAccess(userAPIparam.asSchoolId, userAPIparam.aiUserId, userAPIparam.asScreenId);
        }
        [HttpPost]
        [Route("Teacher/GetDetails")]
        public TeacherModel GetDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetDetails(userAPIparam.asSchoolId, userAPIparam.asUserId, userAPIparam.asRoleId);
        }
        [HttpPost]
        [Route("Teacher/GetStaffDetails")]
        public AdminStaff GetStaffDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStaffDetails(userAPIparam.asSchoolId, userAPIparam.asUserId, userAPIparam.asRoleId);
        }
        //Added By Mohsin
        [HttpPost]
        [Route("Teacher/GetMonthwiseAttendance")]
        public StudentAttendanceDetailsMaster GetMonthwiseAttendance([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetMonthwiseAttendance(userAPIparam.asSchoolId, userAPIparam.asAcademicyearId, userAPIparam.asStanardDivisionId);
        }

        //Assign Homework(Base Screen 3-API)
        [HttpPost]
        [Route("Teacher/GetTeacherName")]
        public List<GetTeacherNameForHomework> GetTeacherName([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetTeacherName(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asShowHomeworkToClassTeacher, userAPIparam.aTeacherId);
        }

        [HttpPost]
        [Route("Teacher/GetAssignedClassDropDown")]
        public List<GetAssignedClass> GetAssignedClassDropDown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAssignedClassDropDown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.aTeacherId);
        }

        [HttpPost]
        [Route("Teacher/GetTeacherSubjectAndClassSubject")]
        public List<TeacherSubjectDtl> GetTeacherSubjectAndClassSubject([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetTeacherSubjectAndClassSubject(userAPIparam.asSchoolId, userAPIparam.aTeacherId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId);
        }

        //Annual Planner-->SchoolWise Event PopUp(8-API)
        [HttpPost]
        [Route("Teacher/GetEventList")]
        public List<EventList> GetEventList([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetEventList(userAPIparam.asEventDate, userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardId, userAPIparam.asDivisionId);
        }
        [HttpPost]
        [Route("Teacher/EditEventDetails")]
        public EditEventDetailsMaster EditEventDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.EditEventDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asEventId);
        }
        [HttpPost]
        [Route("Teacher/GetAllClassesAndDivisions")]
        public List<AllClasses> GetAllClassesAndDivisions([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllClassesAndDivisions(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        [HttpPost]
        [Route("Teacher/GetTeachersForLecturewiseAttendance")]
        public List<GetTeachersForLecturewiseAttendance> GetTeachersForLecturewiseAttendance([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetTeachersForLecturewiseAttendance(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asTeacherId);
        }

        [HttpPost]
        [Route("Teacher/SaveUpdateEvent")]
        public string SaveUpdateEvent([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveUpdateEvent(userAPIparam.asEventId, userAPIparam.asEventName, userAPIparam.asEventDescription, userAPIparam.asEventStartDate, userAPIparam.asEventEndDate, userAPIparam.asDisplayOnHomepage, userAPIparam.asEventImageName, userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.asUpdatedById, userAPIparam.asStandardDivisions, userAPIparam.asSaveFeature, userAPIparam.asFolderName, userAPIparam.asBase64String);
        }
        [HttpPost]
        [Route("Teacher/DeleteEvent")]
        public string DeleteEvent([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteEvent(userAPIparam.asSchoolId, userAPIparam.asEventId,userAPIparam.asUserId);
        }
        [HttpPost]
        [Route("Teacher/DeleteLectureWiseAttendanceDetails")]
        public string DeleteLectureWiseAttendanceDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteLectureWiseAttendanceDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asAttendanceDate, userAPIparam.asStandardDivisionId, userAPIparam.asLectureNo, userAPIparam.asSubjectId);
        }
        [HttpPost]
        [Route("Teacher/DeleteEventImage")]
        public string DeleteEventImage([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteEventImage(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asEventId, userAPIparam.asUserId);
        }

        //------------------Added API--------------------------

        [HttpPost]
        [Route("Teacher/GetCalendarForStudent")]
        public List<StudentMonthlyAttendanceCalender> GetCalendarForStudent([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetCalendarForStudent(userAPIparam.asSchoolId, userAPIparam.aStudentId, userAPIparam.aAcademicYearId, userAPIparam.aMonthId, userAPIparam.aYear);
        }



        
        [HttpPost]
        [Route("Teacher/SaveUpdateHomework")]
        public string SaveUpdateHomework([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveUpdateHomework(userAPIparam.AsId, userAPIparam.asTitle, userAPIparam.asSubjectId, userAPIparam.asStandardDivisionId, userAPIparam. asAttachmentPath, userAPIparam.asDetails, userAPIparam.asAssignDate, userAPIparam.asCompleteByDate, userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.additionalAttachmentFile, userAPIparam.asSaveFeature, userAPIparam.asFolderName, userAPIparam.asBase64String, userAPIparam.asDivisionIds);
        }
        ///Added By Akanksha Aadi
       
        //Added By Akanksha
        [HttpPost]
        [Route("Teacher/GetSummaryCountforAttendance")]
        public AttendanceMaster GetSummaryCountforAttendance([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetSummaryCountforAttendance(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId, userAPIparam.asAttendanceDate, userAPIparam.asUserId);
        }

        //Added By Mohsin
        [HttpPost]
        [Route("Teacher/GetSummaryCountforLecturwiseAttendance")]
        public AttendanceMaster GetSummaryCountforLecturwiseAttendance([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetSummaryCountforLecturwiseAttendance(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId, userAPIparam.asAttendanceDate, userAPIparam.asLectureNo, userAPIparam.asSubjectId);
        }

        [HttpPost]
        [Route("Teacher/GetSchoolAttendanceOverView")]
        public ClasswiseAttendanceStatusMaster GetSchoolAttendanceOverView([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetSchoolAttendanceOverView(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asSelectedDate);
        }
        [HttpPost]
        [Route("Teacher/GetStudentNameDropdown")]
        public List<StudentNameDropDown> GetStudentNameDropdown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentNameDropdown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId);
        }
        [HttpPost]
        [Route("Teacher/SaveStudentAttendance")]
        public string SaveStudentAttendance([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveStudentAttendance(userAPIparam.asSchoolId, userAPIparam.asInsertedById, userAPIparam.asStudentsAttendance, userAPIparam.aMonthId, userAPIparam.aYear, userAPIparam.aStudentId);
        }

       

       

        [HttpPost]
        [Route("Teacher/GetOptionalSubjectsForMarksTransfer")]
        public List<OptionalSubjectsForMarksTransfer> GetOptionalSubjectsForMarksTransfer([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetOptionalSubjectsForMarksTransfer(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId);
        }

       

        [HttpPost]
        [Route("Teacher/GetStudentsToTransferMarks")]
        public TransferStudentSubjectsMarkDetailsMaster GetStudentsToTransferMarks([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentsToTransferMarks(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId, userAPIparam.asName, userAPIparam.asEndIndex, userAPIparam.asStartRowIndex);
        }

        [HttpPost]
        [Route("Teacher/GetClassTeachers")]
        public List<GetClassTeachers> GetClassTeachers([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassTeachers(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId,userAPIparam.asTeacherId);
        }
        [HttpPost]
        [Route("Teacher/DeleteIndividualAttendance")]
        public string DeleteIndividualAttendance([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteIndividualAttendance(userAPIparam.asSchoolId, userAPIparam.asAttendanceDate, userAPIparam.asAcademicyearId, userAPIparam.asStdDivId);
        }
        [HttpPost]
        [Route("Teacher/SaveYearwiseAnnualPlannerDetails")]
        public string SaveYearwiseAnnualPlannerDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveYearwiseAnnualPlannerDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asFileName, userAPIparam.asUpdatedById, userAPIparam.asSaveFeature, userAPIparam.asFolderName, userAPIparam.asBase64String);
        }
        [HttpPost]
        [Route("Teacher/GetFileDetails")]
        public List<SaveYearwiseAnnualPlannerDetails> GetFileDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetFileDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        [HttpPost]
        [Route("Teacher/DeleteFileDetails")]
        public string DeleteFileDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteFileDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId,userAPIparam.asUserId);
        }
        //Exam Result-Termwise Height-Weight
        [HttpPost]
        [Route("Teacher/UpdateStudentDetailsForHeightWeight")]
        public string UpdateStudentDetailsForHeightWeight([FromBody] UserParam userAPIparam)
        {
            return this.teacher.UpdateStudentDetailsForHeightWeight(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asTermId, userAPIparam.asStandardDivisionId, userAPIparam.aiUserId, userAPIparam.StudentHeightWeightDetailsXML);
        }
        //Get All Class Teachers Name
        [HttpPost]
        [Route("Teacher/GetAllPrimaryClassTeachers")]
        public List<AlPrimaryTeacherNames> GetAllPrimaryClassTeachers([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllPrimaryClassTeachers(userAPIparam.asSchoolId, userAPIparam.asAcademicYearID);
        }
        [HttpPost]
        [Route("Teacher/GetTestwiseTerm")]
        public List<GetTestwiseTerm> GetTestwiseTerm([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetTestwiseTerm(userAPIparam.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/GetStudentListToCaptureHeighthWeight")]
        public List<GetStudentListToCaptureHeighthWeight> GetStudentListToCaptureHeighthWeight([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentListToCaptureHeighthWeight(userAPIparam.asStdDivId, userAPIparam.asAcademic_Year_Id, userAPIparam.asSchoolId, userAPIparam.asTerm_Id);
        }
        [HttpPost]
        [Route("Teacher/DeleteHomeworkDailyLog")]
        public string DeleteHomeworkDailyLog([FromBody] UserParam userAPIparam)
        {
            return teacher.DeleteHomeworkDailyLog(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asId, userAPIparam.asUpdatedById);
        }

        //Added By Mohsin
        [HttpPost]
        [Route("Teacher/GetAllMonthsDropDown")]
        public List<GetAllMonths> GetAllMonthsDropDown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllMonthsDropDown(userAPIparam.asSchoolId);
        }

        [HttpPost]
        [Route("Teacher/GetYearsForAnnualPalannerDropDown")]
        public List<GetYearsForAnnualPalanner> GetYearsForAnnualPalannerDropDown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetYearsForAnnualPalannerDropDown(userAPIparam.asSchoolId);
        }

        [HttpPost]
        [Route("Teacher/GetAssociatedStdLstForTeacherDropDown")]
        public List<GetAssociatedStdLstForTeacher> GetAssociatedStdLstForTeacherDropDown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAssociatedStdLstForTeacherDropDown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId);
        }

        [HttpPost]
        [Route("Teacher/GetAllDivisionsForStandardDropDown")]
        public List<GetAllDivisionsForStandard> GetAllDivisionsForStandardDropDown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllDivisionsForStandardDropDown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardId);
        }

        [HttpPost]
        [Route("Teacher/GetEventsDataList")]
        public List<GetEventsData> GetEventsDataList([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetEventsDataList(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asMonthId, userAPIparam.asYear, userAPIparam.asStandardId, userAPIparam.asDivisionId);
        }
        [HttpPost]
        [Route("Teacher/PublishUnpublishHomeworkDailylog")]
        public string PublishUnpublishHomeworkDailylog([FromBody] UserParam userAPIparam)
        {
            return teacher.PublishUnpublishHomeworkDailylog(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asLogId, userAPIparam.asUpdatedById, userAPIparam.asIsPublished);
        }
        //save daily log
        [HttpPost]
        [Route("Teacher/SaveDailyLog")]
        public string SaveDailyLog([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveDailyLog(userAPIparam.aHomeWorkLogId,userAPIparam.asStdDivId, userAPIparam.asDate, userAPIparam.asAttachmentName, userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.asSaveFeature, userAPIparam.asFolderName, userAPIparam.asBase64String);
        }

        //editdaily log
        [HttpPost]
        [Route("Teacher/GetHomeworkDailyLog")]
        public List<HomeworkDailyLog> GetHomeworkDailyLog([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetHomeworkDailyLog(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.aId);
        }

        //add daily log list
        [HttpPost]
        [Route("Teacher/GetAllHomeworkDailyLogs")]
        public List<AllHomeworkDailyLogs> GetAllHomeworkDailyLogs([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllHomeworkDailyLogs(userAPIparam.asSchoolId, userAPIparam.asFilter, userAPIparam.asStdDivId, userAPIparam.asSortExpression, userAPIparam.asStartIndex, userAPIparam.asEndIndex, userAPIparam.asUserId);
        }



        //Assign Homework Base Screen (Teacher)

                  

        [HttpPost]
        [Route("Teacher/TransferOptionalSubjectMarks")]
        public string TransferOPtionalSubjectMarks([FromBody] UserParam userAPIparam)
        {
            return this.teacher.TransferOPtionalSubjectMarks(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asStudentTransferMarksXml);
        }

        //Monthwise daily log list
        [HttpPost]
        [Route("Teacher/GetAttachmentsByMonth")]
        public List<AttachmentsByMonth> GetAttachmentsByMonth([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAttachmentsByMonth(userAPIparam.asSchoolId, userAPIparam.asTargetMonth);
        }

        [HttpPost]
        [Route("Teacher/GetClasswiseExamDropDown")]
        public List<GetClasswiseExams> GetClasswiseExamDropDown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClasswiseExamDropDown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId);
        }

        [HttpPost]
        [Route("Teacher/GetHomeworkDetail")]
        public List<GetHomeworkDetail> GetHomeworkDetail([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetHomeworkDetail(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asHomeworkId);
        }
        [HttpPost]
        [Route("Teacher/DeleteHomework")]
        public string DeleteHomework([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteHomework(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asHomeworkId, userAPIparam.asUpdatedById);
        }
        //Exam Result 
        [HttpPost]
        [Route("Teacher/GetAllTestsForClass")]
        public List<ClasswiseTest> GetAllTestsForClass([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllTestsForClass(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId);
        }
        [HttpPost]
        [Route("Teacher/GetClassPassFailDetailsForTest")]
        public ClassPassFailDetailsForTest GetClassPassFailDetailsForTest([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassPassFailDetailsForTest(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId, userAPIparam.aiTestId);
        }
        [HttpPost]
        [Route("Teacher/GetSubjectListForTeacher")]
        public List<GetSubjectList> GetSubjectListForTeacher([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetSubjectListForTeacher(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId, userAPIparam.asHomeWorkStatus, userAPIparam.asHomeworkTitle, userAPIparam.asAssignedDate);
        }
        [HttpPost]
        [Route("Teacher/GetSubjectsExamMarksStatusForClass")]
        public SubjectsExamMarksStatus GetSubjectsExamMarksStatusForClass([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetSubjectsExamMarksStatusForClass(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.aTeacherId, userAPIparam.asExamId, userAPIparam.asAllowPartialSubmit, userAPIparam.asStandardDivisionId, userAPIparam.IsClassTeacher);
        }
        [HttpPost]
        [Route("Teacher/PublishUnPublishHomework")]
        public string PublishUnPublishHomework([FromBody] UserParam userAPIparam)
        {
            return this.teacher.PublishUnPublishHomework(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asHomeworkId, userAPIparam.asReason, userAPIparam.asUpdatedById, userAPIparam.asIsPublish, userAPIparam.asIsSMSSent);
        }
       

        //Annual Planner Full Access(Standard dropdown)Added by Prajakta 

        [HttpPost]
        [Route("Teacher/GetAssociatedStandards")]
        public List<Standard> GetAssociatedStandards([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAssociatedStandards(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }

        //Attendance Delete Button Added by Prajakta 

        [HttpPost]
        [Route("Teacher/DeleteAttendance")]
        public string DeleteAttendance([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteAttendance(userAPIparam.asSchoolId, userAPIparam.asAttendanceDate, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId,userAPIparam.asUserId);
        }
     
        //
        [HttpPost]
        [Route("Teacher/GetAllStudentsForMarksAssignment")]
        public List<GetAllStudentsForMarksAssignment> GetAllStudentsForMarksAssignment([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllStudentsForMarksAssignment(userAPIparam.asAcademicYearId, userAPIparam.asSchoolId, userAPIparam.asSubjectId, userAPIparam.asStandard_Division_Id, userAPIparam.asTestDate);
        }
        [HttpPost]
        [Route("Teacher/UpdateAllStudentsRemarkDetails")]
        public string UpdateAllStudentsRemarkDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.UpdateAllStudentsRemarkDetails(userAPIparam.StudentwiseRemarkXML, userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asInsertedById, userAPIparam.asStandardDivId, userAPIparam.asTermId);
        }
        [HttpPost]
        [Route("Teacher/GetAllStudentswiseRemarkDetails")]
        public GetAllStudentswiseRemarkDetailsMaster GetAllStudentswiseRemarkDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllStudentswiseRemarkDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asStudentId, userAPIparam.asTermId);
        }
        [HttpPost]
        [Route("Teacher/GetStudentswiseRemarkDetailsToExport")]
        public GetStudentswiseRemarkDetailsToExportMaster GetStudentswiseRemarkDetailsToExport([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentswiseRemarkDetailsToExport(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asStudentId, userAPIparam.asTermId);
        }


        //Lesson Plans --BaseScreen
        [HttpPost]
        [Route("Teacher/GetLessonPlanList")]
        public List<GetLessonPlanConfigDetails> GetLessonPlanList([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetLessonPlanList(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asReportingUserId, userAPIparam.asStartIndex, userAPIparam.asEndIndex, userAPIparam.asIsRecordCount, userAPIparam.asStartDate, userAPIparam.asEndDate, userAPIparam.asRecordCount);
        }

        //Lesson Plans--Add LessonPlan
        [HttpPost]
        [Route("Teacher/SaveLessonPlan")]
        public string SaveLessonPlan([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveLessonPlan(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asReportingUserId, userAPIparam.aasStartDate, userAPIparam.aasEndDate, userAPIparam.asLessonPlanXml, userAPIparam.asUpdatedById, userAPIparam.asOldStartDate, userAPIparam.asOldEndDate);
        }
        [HttpPost]
        [Route("Teacher/SubmitLessonPlan")]
        public string SubmitLessonPlan([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SubmitLessonPlan(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asReportingUserId, userAPIparam.aasStartDate, userAPIparam.aasEndDate, userAPIparam.asUpdatedById);
        }
        [HttpPost]
        [Route("Teacher/SaveApproverComment")]
        public string SaveApproverComment([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveApproverComment(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asReportingUserId, userAPIparam.aasStartDate, userAPIparam.aasEndDate, userAPIparam.asApproverComment, userAPIparam.asUpdatedById, userAPIparam.asOldStartDate, userAPIparam.asOldEndDate);
        }
        [HttpPost]
        [Route("Teacher/UpdateLessonPlanDate")]
        public string UpdateLessonPlanDate([FromBody] UserParam userAPIparam)
        {
            return this.teacher.UpdateLessonPlanDate(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUpdatedById, userAPIparam.asUserId, userAPIparam.asReportingUserId, userAPIparam.aasStartDate, userAPIparam.aasEndDate, userAPIparam.asOldStartDate, userAPIparam.asOldEndDate);
        }
       
        [HttpPost]
        [Route("Teacher/AddOrEditLessonPlanDetails")]
        public GetAllLessonPlanDetailsMaster AddOrEditLessonPlanDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.AddOrEditLessonPlanDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asUserId, userAPIparam.asReportingUserId, userAPIparam.asStartDate, userAPIparam.asEndDate, userAPIparam.IsNewMode);
        }

        [HttpPost]
        [Route("Teacher/ExportLessonPlan")]
        public LessonPlanExportDetails ExportLessonPlan([FromBody] UserParam userAPIparam)
        {
            return teacher.ExportLessonPlan(userAPIparam.aiSchoolId, userAPIparam.aiAcademicYearId, userAPIparam.aiUserId.ToInt(), userAPIparam.asStartDate, userAPIparam.asEndDate);
        }
        //
        [HttpPost]
        [Route("Teacher/GetClassTeacherss")]
        public List<GetClassTeacherss> GetClassTeacherss([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassTeacherss(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        [HttpPost]
        [Route("Teacher/GetTeacherXseedSubjects")]
        public List<GetTeacherXseedSubjects> GetTeacherXseedSubjects([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetTeacherXseedSubjects(userAPIparam.asSchoolId, userAPIparam.asAcademicYear_ID, userAPIparam.asTeacherId, userAPIparam.asAssessmentId);
        }
        //
        [HttpPost]
        [Route("Teacher/SubmitUnsubmitExamMarksStatus")]
        public string SubmitUnsubmitExamMarksStatus([FromBody] UserParam userAPIparam)
        {
            return teacher.SubmitUnsubmitExamMarksStatus(userAPIparam.asStandard_Division_Id, userAPIparam.asAssessmentId, userAPIparam.asSubjectId, userAPIparam.IsSubmitted, userAPIparam.asAcademicYearId, userAPIparam.asSchoolId, userAPIparam.asInserted_By_id);
        }
        [HttpPost]
        [Route("Teacher/GetAssessmentDropdown")]
        public List<GetAssessmentDropdown> GetAssessmentDropdown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAssessmentDropdown(userAPIparam.asAcademicYearId, userAPIparam.asSchoolId);
        }
        //teacher
        [HttpPost]
        [Route("Teacher/GetTeacherDropdown")]
        public List<GetTeacherDropdown> GetTeacherDropdown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetTeacherDropdown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        //teacher list
        [HttpPost]
        [Route("Teacher/GetAllPrimaryClassTeachers1")]
        public List<GetAllPrimaryClassTeachers1> GetAllPrimaryClassTeachers1([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllPrimaryClassTeachers1(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId);
        }
        //student list
        [HttpPost]
        [Route("Teacher/GetStudentListToAssignRemark")]
        public List<GetStudentListToAssignRemark> GetStudentListToAssignRemark([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentListToAssignRemark(userAPIparam.asStandard_Division_Id, userAPIparam.asAcademicYearId, userAPIparam.asSchoolId, userAPIparam.asTerm_Id);
        }
        [HttpPost]
        [Route("Teacher/GetStudentListToProgressRemark")]
        public List<GetStudentListToAssignRemark> GetStudentListToProgressRemark([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentListToProgressRemark(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandard_Division_Id, userAPIparam.asStudentId, userAPIparam.asTerm_Id, userAPIparam.asStartIndex, userAPIparam.asEndIndex, userAPIparam.asSortExp);
        }
        //unpublish
        [HttpPost]
        [Route("Teacher/UnPublishTest")]
        public string UnPublishTest([FromBody] UserParam userAPIparam)
        {
            return teacher.UnPublishTest(userAPIparam.asSchoolId, userAPIparam.asStandardDivId, userAPIparam.asAcademicYearId, userAPIparam.asSchoolWise_Test_Id, userAPIparam.asUnPublishReason);
        }
        //
        [HttpPost]
        [Route("Teacher/GetStudentsForStdDev")]
        public GetStudentsForStdDevMaster GetStudentsForStdDev([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentsForStdDev(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asAssessmentId, userAPIparam.asSubjectId);
        }
        //
        [HttpPost]
        [Route("Teacher/GetLearningOutcomesForSubjectSection")]
        public GetLearningOutcomesForSubjectSectionMaster GetLearningOutcomesForSubjectSection([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetLearningOutcomesForSubjectSection(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asAssessmentId, userAPIparam.asSubjectSectionConfigurationId, userAPIparam.asYearwiseStudentId, userAPIparam.asSubjectId);
        }
        //
        [HttpPost]
        [Route("Teacher/InsertStudentGrades")]
        public string InsertStudentGrades([FromBody] UserParam userAPIparam)
        {
            return teacher.InsertStudentGrades(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asYearwiseStudentId, userAPIparam.asLearningOutcomeXML, userAPIparam.asInsertedById, userAPIparam.asSubjectSectionConfigurationId, userAPIparam.asObservation, userAPIparam.asAssessmentId, userAPIparam.asLearningOutcomesObservationId, userAPIparam.asSubjectRemark, userAPIparam.asSubjectId);
        }
        //
        [HttpPost]
        [Route("Teacher/DeleteComment")]
        public string DeleteComment([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteComment(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asSchoolwiseStudentId, userAPIparam.asCommentId, userAPIparam.asUpdatedById, userAPIparam.asIsDeleteAction, userAPIparam.asAllowSubmit);
        }
        // Laxman
        [HttpPost]
        [Route("Teacher/SaveComment")]
        public string SaveComment([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveComment(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asSchoolwiseStudentId, userAPIparam.asCommentId, userAPIparam.asDate, userAPIparam.asComment, userAPIparam.asLectureName, userAPIparam.asUpdatedById, userAPIparam.asIsDeleteAction, userAPIparam.asAllowSubmit, userAPIparam.asStdDivId);
        }
        // Pranav
        [HttpPost]
        [Route("Teacher/SaveAndSubmitComment")]
        public string SaveAndSubmitComment([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveAndSubmitComment(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asSchoolwiseStudentId, userAPIparam.asCommentId, userAPIparam.asDate, userAPIparam.asComment, userAPIparam.asLectureName, userAPIparam.asUpdatedById, userAPIparam.asIsDeleteAction, userAPIparam.asAllowSubmit, userAPIparam.asStdDivId);
        }
        //
        //submit
        [HttpPost]
        [Route("Teacher/SubmitStudentRecordComment")]
        public string SubmitStudentRecordComment([FromBody] UserParam userAPIparam)
        {
            return teacher.SubmitStudentRecordComment(userAPIparam.asSchoolId, userAPIparam.asUpdatedById, userAPIparam.asSchoolwiseStudentId, userAPIparam.asCommentId, userAPIparam.asSubmitAllComments, userAPIparam.asAcademicYearId);
        }
        //GRT RECORD
        [HttpPost]
        [Route("Teacher/GetStudentRecordData")]
        public GetStudentRecordDataMaster GetStudentRecordData([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentRecordData(userAPIparam.asSchoolId, userAPIparam.asSchoolwiseStudentId, userAPIparam.asAcademicYearId, userAPIparam.asIsReadMode, userAPIparam.asUserId);
        }
        //Mark As Read
        [HttpPost]
        [Route("Teacher/MarkRecordAsRead")]
        public string MarkRecordAsRead([FromBody] UserParam userAPIparam)
        {
            return teacher.MarkRecordAsRead(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asSchoolwiseStudentId);
        }
        // SAVE
        [HttpPost]
        [Route("Teacher/SaveStudentRecord")]
        public string SaveStudentRecord([FromBody] UserParam userAPIparam)
        {
            return teacher.SaveStudentRecord(userAPIparam.asSchoolId, userAPIparam.asUpdatedById, userAPIparam.asStudentId, userAPIparam.asDataXML, userAPIparam.Date);
        }
        [HttpPost]
        [Route("Teacher/SaveStudentAttendence")]
        public string SaveStudentAttendence([FromBody] UserParam userAPIparam)
        {
            return teacher.SaveStudentAttendence(userAPIparam.asSchoolId, userAPIparam.asInsertedById, userAPIparam.asStudentsAttendanceXML, userAPIparam.asAttendanceDate, userAPIparam.asStandardDivisionId, userAPIparam.asSendMessage);
        }
        [HttpPost]
        [Route("Teacher/SaveStudentLecturwiseAttendence")]
        public string SaveStudentLecturwiseAttendence([FromBody] UserParam userAPIparam)
        {
            return teacher.SaveStudentLecturwiseAttendence(userAPIparam.asSchoolId, userAPIparam.asInsertedById, userAPIparam.asLectureWiseAttendanceXML, userAPIparam.asAttendanceDate, userAPIparam.asStandardDivisionId, userAPIparam.asLectureNo, userAPIparam.asSubjectId);
        }
        [HttpPost]
        [Route("Teacher/MarkClassMothwiseAttendance")]
        public string MarkClassMothwiseAttendance([FromBody] UserParam userAPIparam)
        {
            return teacher.MarkClassMothwiseAttendance(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId, userAPIparam.adAttendanceDate, userAPIparam.asUpdatedById, userAPIparam.abOverriteAttendance);
        }
        [HttpPost]
        [Route("Teacher/RejectLessonPlan")]
        public string RejectLessonPlan([FromBody] UserParam userAPIparam)
        {
            return teacher.RejectLessonPlan(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asReportingUserId, userAPIparam.asConfigId, userAPIparam.asReason);
        }
        [HttpPost]
        [Route("Teacher/ApproveLessonPlan")]
        public string ApproveLessonPlan([FromBody] UserParam userAPIparam)
        {
            return teacher.ApproveLessonPlan(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asReportingUserId, userAPIparam.asConfigId);
        }
        
        [HttpPost]
        [Route("Teacher/GetStudentsForSubjectMarkSheet")]
        public List<List<StudentForSubjectmarkList>> GetStudentsForSubjectMarkSheet([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentsForSubjectMarkSheet(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asNoOfRecord , userAPIparam.asTestId, userAPIparam.asSubjectId);
        }
        [HttpPost]
        [Route("Teacher/GetClassesForLessonPlan")]
        public List<GetClassesForLessonPlan> GetClassesForLessonPlan([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassesForLessonPlan(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId);
        }
        [HttpPost]
        [Route("Teacher/GetAllStudentsForProgressRemark")]
        public GetAllStudentsForProgressRemarkMaster GetAllStudentsForProgressRemark([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllStudentsForProgressRemark(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.aTeacherId, userAPIparam.asStudentId, userAPIparam.asTermId, userAPIparam.asStartIndex, userAPIparam.asEndIndex, userAPIparam.asSortExp);
        }
        [HttpPost]
        [Route("Teacher/GetAcademicDatesForStandardDivision")]
        public GetAcademicDatesForStandardDivision GetAcademicDatesForStandardDivision([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAcademicDatesForStandardDivision(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId);
        }
        [HttpPost]
        [Route("Teacher/GetConfiguredMaxRemarkLength")]
        public GetConfiguredMaxRemarkLength GetConfiguredMaxRemarkLength([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetConfiguredMaxRemarkLength(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardId, userAPIparam.asTermId);
        }
       
      
       
       
      
        [HttpPost]
        [Route("Teacher/GetLatestExamId")]
        public int GetLatestExamId([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetLatestExamId(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asStandardId);
        }
        [HttpPost]
        [Route("Teacher/GetHolidayNameAndStartDateEnddateValidationForSave")]
        public HolidaySaveValidationMaster GetHolidayNameAndStartDateEnddateValidationForSave([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetHolidayNameAndStartDateEnddateValidationForSave(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivIds, userAPIparam.asHolidayId, userAPIparam.asHolidayName, userAPIparam.asHolidayStartDate, userAPIparam.asHolidayEndDate);
        }
        [HttpPost]
        [Route("Teacher/GetAssociatedStandardsAndDivisionsDropdownForToppers")]
        public List<GetAssociatedStandardsAndDivisionsForToppers> GetAssociatedStandardsAndDivisionsDropdownForToppers([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAssociatedStandardsAndDivisionsDropdownForToppers(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.IsStandardList);
        }
        [HttpPost]
        [Route("Teacher/GetClassAndStandardExamDropDownForToppers")]
        public List<GetExam> GetClassAndStandardExamDropDownForToppers([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassAndStandardExamDropDownForToppers(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asStandardId);
        }

        [HttpPost]
        [Route("Teacher/GetStandardAndDivisionToppersSubjectsDropDown")]
        public List<GetClassSubjectsforTopper> GetStandardAndDivisionToppersSubjectsDropDown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStandardAndDivisionToppersSubjectsDropDown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asStandardId, userAPIparam.asTestId);
        }
        [HttpPost]
        [Route("Teacher/GetClassAndStandardToppersList")]
        public GetTopperListMaster GetClassAndStandardToppersList([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassAndStandardToppersList(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asStandardId, userAPIparam.asTestId, userAPIparam.asSubjectId);
        }

        [HttpPost]
        [Route("Teacher/GenerateTestTotalMarks")]
        public string GenerateTestTotalMarks([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GenerateTestTotalMarks(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId,userAPIparam.asTestId, userAPIparam.asInsertedById);
        }
        [HttpPost]
        [Route("Teacher/CanCreateGenralRequisition")]
        public string CanCreateGenralRequisition([FromBody] UserParam userAPIparam)
        {
            return this.teacher.CanCreateGenralRequisition(userAPIparam.asSchoolId, userAPIparam.asUserId);
        }
        [HttpPost]
        [Route("Teacher/CanSendRequisition")]
        public bool CanSendRequisition([FromBody] UserParam userAPIparam)
        {
            return this.teacher.CanSendRequisition(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId);
        }
        [HttpPost]
        [Route("Teacher/GetExamScheduleForAllStandard")]
        public GetExamScheduleDetailsMaster GetExamScheduleDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetExamScheduleDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId,userAPIparam.asStandardId);
        }
        [HttpPost]
        [Route("Teacher/UpdateStudentTestMarks")]
        public string UpdateStudentTestMarks([FromBody] UserParam userAPIparam)
        {
            return this.teacher.UpdateStudentTestMarks(userAPIparam.asSchoolId, userAPIparam.asStudentMarkDetails, userAPIparam.asUpdatedById, userAPIparam.asUseAvarageFinalResult);
        }
        [HttpPost]
        [Route("Teacher/GetPagedStudentsForMarkAssignment")]
        public GetPagedStudentsForMarkAssignmentMaster GetPagedStudentsForMarkAssignment([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetPagedStudentsForMarkAssignment(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asAssessmentId, userAPIparam.asStartIndex, userAPIparam.asEndIndex, userAPIparam.asSortExp);
        }
        [HttpPost]
        [Route("Teacher/DeleteStudentTestMarks")]
        public string DeleteStudentTestMarks([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteStudentTestMarks(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asAssessmentId, userAPIparam.asStudentId, userAPIparam.asUpdatedById);
        }
        [HttpPost]
        [Route("Teacher/DeleteAllStudentTestMarks")]
        public string DeleteAllStudentTestMarks([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteAllStudentTestMarks(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asAssessmentId, userAPIparam.asUpdatedById);
        }
        [HttpPost]
        [Route("Teacher/GetPublishStatus")]
        public PublishStatus GetPublishStatus([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetPublishStatus(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asAssessmentId);
        }
        [HttpPost]
        [Route("Teacher/SaveInvestmentDocument")]
        public string SaveInvestmentDocuments([FromBody] UserParam userAPIparam)
        {
            return this.teacher.SaveInvestmentDocuments(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asFinancialYearId, userAPIparam.asDocumentId, userAPIparam.asFileName, userAPIparam.asUserId, userAPIparam.asInsertedById, userAPIparam.asDocumnetTypeId, userAPIparam.asReportingUserId, userAPIparam.asSaveFeature, userAPIparam.asFolderName, userAPIparam.asBase64String);
        }
        [HttpPost]
        [Route("Teacher/GetSchoolwiseAcademicYearDetails")]
        public List<GetSchoolwiseAcademicYear> GetSchoolwiseAcademicYearDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetSchoolwiseAcademicYearDetails(userAPIparam.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/GetAllReportingUsers")]
        public List<AllReportingUsers> GetAllReportingUsers([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllReportingUsers(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        [HttpPost]
        [Route("Teacher/IsValidateLeaveDateOverlapping")]
        public bool IsValidateLeaveDateOverlapping([FromBody] UserParam userAPIparam)
        {
            return this.teacher.IsValidateLeaveDateOverlapping(userAPIparam.asSchoolId, userAPIparam.aasStartDate, userAPIparam.aasEndDate, userAPIparam.asUserId, userAPIparam.asLeaveConfigId);
        }

        [HttpPost]
        [Route("Teacher/IsGradingStandard")]
        public bool IsGradingStandard([FromBody] UserParam userAPIparam)
        {
            return this.teacher.IsGradingStandard(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardId);
        }
        [HttpPost]
        [Route("Teacher/IsTestPublishedForStudent")]
        public bool IsTestPublishedForStudent([FromBody] UserParam userAPIparam)
        {
            return this.teacher.IsTestPublishedForStudent(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asStudentId);
        }
        [HttpPost]
        [Route("Teacher/GetInvestmentDocumentFile")]
        public GetInvestmentDocumentFile GetInvestmentDocumentFile([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetInvestmentDocumentFile(userAPIparam.asSchoolId, userAPIparam.asId);
        }



        [HttpPost]
        [Route("Teacher/GetGradeListForFailCriteria")]
        public List<GetGradesName> GetGradeListForFailCriteria([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetGradeListForFailCriteria(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId);
        }




        [HttpPost]
        [Route("Teacher/GetUpcomingEventsNew")]
        public UpcomingEventData GetUpcomingEventsNew([FromBody] SchoolParam schoolAPIParam)
        {
            return this.teacher.GetUpcomingEventsNew(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiUserId, schoolAPIParam.aiUserRoleId, schoolAPIParam.isScreenFullAccess, schoolAPIParam.abIsServiceCall = false);
        }
        [HttpPost]
        [Route("Teacher/GetClassTeachersForOptionalSubjectClasses")]
        public List<GetClassTeachers> GetClassTeachersForOptionalSubjectClasses([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassTeachersForOptionalSubjectClasses(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asTeacherId);
        }
        [HttpPost]
        [Route("Teacher/GetWeeklyAttendance")]
        public WeeklyAttendanceMaster GetWeeklyAttendance([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetWeeklyAttendance(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId);
        }
        [HttpPost]
        [Route("Teacher/GetLeaveRequisitionAppraisalDetails")]
        public LeaveRequisitionAppraisalDetailsMaster GetLeaveRequisitionAppraisalDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetLeaveRequisitionAppraisalDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId);
        }
        [HttpPost]
        [Route("Teacher/GetTeacherDetails")]
        public TeacherDetailsMaster GetTeacherDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetTeacherDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asTeacherID, userAPIparam.asUserId);
        }
        [HttpPost]
        [Route("Teacher/GetDivisionsForHomeWork")]
        public List<GetDivisionsForHomeWork> GetDivisionsForHomeWork([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetDivisionsForHomeWork(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId, userAPIparam.asUserId, userAPIparam.asSubjectId);
        }
        [HttpPost]
        [Route("Studentfee/GetDashboardStat")]
        public List<GetDashboardStat> GetDashboardStat([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetDashboardStat(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
    }

}
