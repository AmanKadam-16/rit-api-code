using SchoolMobileEntities;
using SchoolMobileEntities.Common;
using SchoolMobileInterface;
using SchoolMobileRepository;
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
    public class RequsitionController : ApiController
    {
        private readonly IRequsition teacher;

        public RequsitionController(IRequsition teacher)
        {
            this.teacher = teacher;
        }



        //Start Your Controller Code from Here
        [HttpPost]
        [Route("Teacher/DeleteLessonPlan")]
        public string DeleteLessonPlan([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteLessonPlan(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUpdatedById, userAPIparam.asUserId, userAPIparam.asStartDate, userAPIparam.asEndDate);
        }

        [HttpPost]
        [Route("Teacher/DeletePhotoGallery")]
        public string DeletePhotoGallery([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeletePhotoGallery(userAPIparam.asGalleryName, userAPIparam.asSchoolId);
        }

        [HttpPost]
        [Route("Teacher/StandardDivisionsPhotoGallery")]
        public List<StandardDivisionsPhotoGallery> StandardDivisionsPhotoGallery([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.StandardDivisionsPhotoGallery(UserParamRequisition.asSchoolId, UserParamRequisition.asGalleryName);
        }

        [HttpPost]
        [Route("Teacher/CountPhotoGalleriesS")]
        public List<CountPhotoGalleries> CountPhotoGalleries([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.CountPhotoGalleries(UserParamRequisition.asSchoolId);
        }
        [HttpPost]
        [Route("Teacher/GetAllPhotoGalleriesDetails")]
        public List<PhotoGallery> PhotoGallery([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.PhotoGallery(UserParamRequisition.asSchoolId, UserParamRequisition.asSortExp, UserParamRequisition.asStartIndex, UserParamRequisition.asPageSize, UserParamRequisition.asAcademicYearId, UserParamRequisition.asGalleryNameFilter);
        }

        [HttpPost]
        [Route("Teacher/GetVideoGalleryDetails")]
        public List<GetVideoGalleryDetails> GetVideoGalleryDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetVideoGalleryDetails(UserParamRequisition.asSchoolId, UserParamRequisition.asSortExp, UserParamRequisition.asStartIndex, UserParamRequisition.asPageSize, UserParamRequisition.asIsFromExternalWebsite, UserParamRequisition. asVideoNameFilter);
        }


        [HttpPost]
        [Route("Teacher/DeleteVideoGallery")]
        public string DeleteVideoGallery([FromBody] UserParam userAPIparam)
        {
            return this.teacher.DeleteVideoGallery(userAPIparam.asSchoolId,userAPIparam.asVideoId, userAPIparam.asSubjectId, userAPIparam.asUpdatedById);
        }

        [HttpPost]
        [Route("Teacher/CountFromVideoList")]
        public List<CountFromVideoList> CountFromVideoList([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.CountFromVideoList(UserParamRequisition.asSchoolId , UserParamRequisition.asCnt);
        }
        //Final Result
        //Final Result ---unpublish
        [HttpPost]
        [Route("Teacher/UnPublishFinalResult")]
        public string UnPublishFinalResult([FromBody] UserParam userAPIparam)
        {
            return teacher.UnPublishFinalResult(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asUnPublishReason);
        }


        //Requisition
        //Requisition --CancelRequisition
        [HttpPost]
        [Route("Teacher/CancelRequisition")]
        public string CancelRequisition([FromBody] UserParam userAPIparam)
        {
            return teacher.CancelRequisition(userAPIparam.asRequisitionId, userAPIparam.asReasonText, userAPIparam.asSchoolId, userAPIparam.asUpdatedById);
        }

        //Requisition --GetRequsitionStatus
        [HttpPost]
        [Route("Teacher/GetRequsitionStatus")]
        public List<GetRequsitionStatus> GetRequsitionStatus([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetRequsitionStatus(userAPIparam.asSchoolId);
        }

        //Requisition --BaseScreen
        [HttpPost]
        [Route("Teacher/GetPagedRequisition")]
        public GetPagedRequisitionMaster GetPagedRequisition([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetPagedRequisition(userAPIparam.asSchoolId, userAPIparam.asStartIndex, userAPIparam.asEndIndex, userAPIparam.asSortExp, userAPIparam.asStatusID, userAPIparam.asUserId, userAPIparam.asFilter);
        }

        //Requisition --DeleteRequisition
        [HttpPost]
        [Route("Teacher/DeleteRequisitionn")]
        public string DeleteRequisitionn([FromBody] UserParam userAPIparam)
        {
            return teacher.DeleteRequisitionn(userAPIparam.asRequisitionId, userAPIparam.asSchoolId);
        }

        //Requisition Details
        [HttpPost]
        [Route("Teacher/GetItemCategory")]
        public List<GetItemCategory> GetItemCategory([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetItemCategory(userAPIparam.asSchoolId);
        }

        //Lession Plan ---Export,ExportAll
        [HttpPost]
        [Route("Teacher/GetLessonPlanDetailsForReport")]
        public List<GetLessonPlanDetailsForReport> GetLessonPlanDetailsForReport([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetLessonPlanDetailsForReport(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStartDate, userAPIparam.asEndDate, userAPIparam.asUserId, userAPIparam.asStandardDivisionId, userAPIparam.asSubjectId);
        }


        //Investment Declaration ---  list
        [HttpPost]
        [Route("Teacher/GetInvestmentDetails")]
        public GetInvestmentDetailsMaster GetInvestmentDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetInvestmentDetails(UserParamRequisition.asSchoolId, UserParamRequisition.asFinancialYearId, UserParamRequisition.asUserId);
        }


        // Investment Declaration --- RegimeDetails
        [HttpPost]
        [Route("Teacher/GetRegimeDetails")]
        public List<GetRegimeDetails> GetRegimeDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetRegimeDetails(UserParamRequisition.asSchoolId);
        }

        //

        //Requisition --SaveRequisition
        [HttpPost]
        [Route("Teacher/SaveRequisition")]
        public SaveRequisitionMaster SaveRequisition([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.SaveRequisition(UserParamRequisition.asSchoolId, UserParamRequisition.asRequisitionId, UserParamRequisition.asUserId, UserParamRequisition.asRequisitionName, UserParamRequisition.asRequisitionDesc, UserParamRequisition.asAction, UserParamRequisition.asRequisitionItemDetailsXml, UserParamRequisition.asIsGeneral, UserParamRequisition.IsSendNotification, UserParamRequisition.asSessionUser, UserParamRequisition.asAcademicYearId);
        }



        //RequisitionBaseScreen Edit,View
        [HttpPost]
        [Route("Teacher/GetRequisitionDetails")]
        public GetRequisitionDetailsMaster GetRequisitionDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetRequisitionDetails(UserParamRequisition.asSchoolId, UserParamRequisition.asRequisitionId, UserParamRequisition.asMode);
        }

        //SubjectMarkList  --Div,SubjectName
        [HttpPost]

        [Route("Teacher/GetClassExamSubjectNameDetailes")]
        public SubjectMarkListmaster GetSubjectMarkList([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetSubjectMarkList(UserParamRequisition.asStandardDivision_Id, UserParamRequisition.asSubject_Id, UserParamRequisition.asTestId, UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId);
        }

        //Requistion Send Requistion
        [HttpPost]
        [Route("Teacher/SendRequisition")]
        public string SendRequisition([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.SendRequisition(UserParamRequisition.asSchoolId, UserParamRequisition.asAccYearId, UserParamRequisition.asUserId);
        }

        //SubjectMarkList   ---TestMark
        [HttpPost]
        [Route("Teacher/GetTestMark")]
        public GetTestMarkMaster GetTestMark([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetTestMark(UserParamRequisition.asSchoolId, UserParamRequisition.asStandardDivision_Id, UserParamRequisition.asSubject_Id, UserParamRequisition.asTestId, UserParamRequisition.asAcademicYearID, UserParamRequisition.asShowTotalAsPerOutOfMarks);
        }

        //SubjectMarkList   ---FirstThreeToopers
        [HttpPost]
        [Route("Teacher/GetFirstThreeToopers")]
        public GetFirstThreeToopersMaster GetFirstThreeToopers([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetFirstThreeToopers(UserParamRequisition.asAcademicYearID, UserParamRequisition.asSchoolId, UserParamRequisition.asStandardDivision_Id, UserParamRequisition.asSubject_Id, UserParamRequisition.asTestId);
        }

        //Add_Requistion   ---AddItemList
        [HttpPost]
        [Route("Teacher/GetAddItemList")]
        public GetAddItemListMaster GetAddItemList([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetAddItemList(UserParamRequisition.asSchoolId, UserParamRequisition.asName, UserParamRequisition.asItemCategoryId, UserParamRequisition.asStartIndex, UserParamRequisition.asEndIndex, UserParamRequisition.asSortExp);
        }
        [HttpPost]
        [Route("Teacher/GetItemImage")]
        public List<GetItemImage> GetItemImage([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetItemImage(UserParamRequisition.asSchoolId, UserParamRequisition.asItemId);
        }

        //Add_Requistion   ---ValidateItemQuantity
        [HttpPost]
        [Route("Teacher/GetNewRequisitionValidateItemQuantity")]
        public GetNewRequisitionValidateItemQuantity ValidateItemQuantity([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.ValidateItemQuantity(UserParamRequisition.asSchoolId, UserParamRequisition.asQuantityDetailsXML);
        }

        //Time_Table   ----GetTimeTableDisplayForTeacher
        [HttpPost]
        [Route("Teacher/GetTimeTableDisplayForTeacher")]
        public GetTimeTableMaster GetTimeTableDisplayForTeacher([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetTimeTableDisplayForTeacher(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearID, UserParamRequisition.asTeacher_Id);
        }

        //Time_Table   ----GetLectureCountsForTeachers
        [HttpPost]
        [Route("Teacher/GetLectureCountsForTeachers")]
        public List<GetLectureCountsForTeachers> GetLectureCountsForTeachers([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetLectureCountsForTeachers(UserParamRequisition.asSchoolId, UserParamRequisition.asTeacher_Id, UserParamRequisition.asConsiderAssembly, UserParamRequisition.asConsiderMPT, UserParamRequisition.asConsiderStayback, UserParamRequisition.asConsiderWeeklyTest);
        }


        //Time_Table    ---GetDataForAdditionalClasses
        [HttpPost]
        [Route("Teacher/GetDataForAdditionalClasses")]
        public DataForAdditionalClassesMaster GetDataForAdditionalClasses([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetDataForAdditionalClasses(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearID, UserParamRequisition.asTeacher_Id, UserParamRequisition.asStandardDivision_Id);
        }

        //Holiday   ---DeleteHolidayDetails
        [HttpPost]
        [Route("Teacher/DeleteHolidayDetails")]
        public string DeleteHolidayDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.DeleteHolidayDetails(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearID, UserParamRequisition.asHoliday_Id);
        }


        //Holiday   ---DeleteHolidayDetails
        [HttpPost]
        [Route("Teacher/SaveHolidayDetails")]
        public string SaveHolidayDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.SaveHolidayDetails(UserParamRequisition.asHolidayName, UserParamRequisition.asRemarks, UserParamRequisition.asStartDate, UserParamRequisition.asEndDate, UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearID, UserParamRequisition.asInsertedById, UserParamRequisition.asAssociatedStandard, UserParamRequisition.asHoliday_Id);
        }

        //Holiday   ---GetHolidayDetails
        [HttpPost]
        [Route("Teacher/GetHolidayDetails")]
        public List<GetHolidayDetails> GetHolidayDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetHolidayDetails(UserParamRequisition.asHoliday_Id, UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearID);
        }


        //Assign Exam Mark  ---GetAllStudentsForMarksAssignments
        [HttpPost]
        [Route("Teacher/GetAllStudentsForMarksAssignments")]
        public GetAllStudentsForMarksAssignmentslist GetAllStudentsForMarksAssignments([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetAllStudentsForMarksAssignments(UserParamRequisition.asAcademicYearID, UserParamRequisition.asSchoolId, UserParamRequisition.asSubject_Id, UserParamRequisition.asStandardDivision_Id, UserParamRequisition.asTestDate, UserParamRequisition.asStartIndex, UserParamRequisition.asEndIndex);
        }

        [HttpPost]
        [Route("Teacher/GetNoticeDetailss")]
        public GeNoticedetailslist GetNoticeDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return teacher.GetNoticeDetails(UserParamRequisition.asSchoolId, UserParamRequisition.asNoticeId, UserParamRequisition.asUserId, UserParamRequisition.asStartIndex, UserParamRequisition.asEndIndex);
        }

        //Assign Exam Mark  ---ManageStudentsTestMark
        [HttpPost]
        [Route("Teacher/ManageStudentsTestMark")]
        public string ManageStudentsTestMark([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.ManageStudentsTestMark(UserParamRequisition.asTestWise_Subject_Marks_Id, UserParamRequisition.asInserted_By_id, UserParamRequisition.asStudent_Test_Type_MarksXml, UserParamRequisition.asStudent_Test_Type_Marks_DetailsXml, UserParamRequisition.asRemoveProgress, UserParamRequisition.asRemarkXml, UserParamRequisition.asHasRemark, UserParamRequisition.asTestId, UserParamRequisition.asSubjectId, UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearID);
        }
        //Subject mark list
        [HttpPost]
        [Route("Teacher/GetSubjectExamMarkslists")]
        public GetSubjectExamMarkslistMaster GetSubjectExamMarkslists([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetSubjectExamMarkslists(UserParamRequisition.asSchoolId, UserParamRequisition.asStandardDivision_Id, UserParamRequisition.asSubjectId, UserParamRequisition.asTestId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asShowTotalAsPerOutOfMarks);
        }
        // Subject Exam mark list--Grades
        [HttpPost]
        [Route("Teacher/GetAllGradesForSubjectMarkList")]
        public List<AllGradesForStandard> AllGradesForStandard([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.AllGradesForStandard(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asStandardId, UserParamRequisition.asSubjectId, UserParamRequisition.asTestId);
        }
        //subject Exam mark --student name
        [HttpPost]
        [Route("Teacher/SaveSupportDetails")]
        public string SaveSupportDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.SaveSupportDetails(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asEmailAddress, UserParamRequisition.asMobileNo, UserParamRequisition.asSubject, UserParamRequisition.asDescription, UserParamRequisition.asFileName, UserParamRequisition.asUserId, UserParamRequisition.asSaveFeature, UserParamRequisition.asFolderName, UserParamRequisition.asBase64String);
        }
        [HttpPost]
        [Route("Teacher/GetAllLessonPlanReportingConfigs")]
        public List<GetAllLessonPlanReportingConfigs> GetAllLessonPlanReportingConfigs([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetAllLessonPlanReportingConfigs(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asUserId);

        }
        //get holiday
        [HttpPost]
        [Route("Teacher/GetHolidayDetailss")]
        public List<GetHolidayDetailss> GetHolidayDetailss([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetHolidayDetailss(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asSortExp, UserParamRequisition.asStartIndex, UserParamRequisition.asPageSize, UserParamRequisition.asStandardId, UserParamRequisition.asDivisionId);

        }
        // Exam shedule
        [HttpPost]
        [Route("Teacher/GetExamSchedule")]
        public List<GetExamSchedule> GetExamSchedule([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetExamSchedule(UserParamRequisition.asSchoolId, UserParamRequisition.asStandardId, UserParamRequisition.asTestId, UserParamRequisition.asSubjectId);

        }
        // Exam resutl -view progress report
        [HttpPost]
        [Route("Teacher/GetAllStudentsTestProgressSheet")]
        public GetAllStudentsTestProgressSheet GetAllStudentsTestProgressSheet([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetAllStudentsTestProgressSheet(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asStdDivId, UserParamRequisition.asStartIndex, UserParamRequisition.PageCount, UserParamRequisition.asTestId);
        }
        //

        [HttpPost]
        [Route("Teacher/SubjectTeachersForAssignExamMarks")]
        public List<SubjectTechers> SubjectTeachersForAssignExamMarks([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.SubjectTeachersForAssignExamMarks(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId);

        }
        //
        [HttpPost]
        [Route("Teacher/AllConffguredTestPublished")]
        public AllConffguredTestPublished AllConffguredTestPublished([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.AllConffguredTestPublished(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asStdDivId);

        }
        //
        [HttpPost]
        [Route("Teacher/AllUnpublishedTestForStdDiv")]
        public List<AllUnpublishedTestForStdDiv> AllUnpublishedTestForStdDiv([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.AllUnpublishedTestForStdDiv(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asStdDivId);

        }
        //progress report
        [HttpPost]
        [Route("Teacher/GetPassedAcademicYears")]
        public List<GetPassedAcademicYears> GetPassedAcademicYears([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetPassedAcademicYears(UserParamRequisition.asSchoolId, UserParamRequisition.asStudent_Id, UserParamRequisition.asIncludeCurrentYear);

        }
        //
        [HttpPost]
        [Route("Teacher/GetAllMarksGradeConfiguration")]
        public GetAllMarksGradeConfiguration GetAllMarksGradeConfiguration([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetAllMarksGradeConfiguration(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asStandardId, UserParamRequisition.asIsCoCurricular);

        }
        //Final Result publish
        [HttpPost]
        [Route("Teacher/AnnualResultPublish")]
        public string AnnualResultPublish([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.AnnualResultPublish(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asStandardDivision_Id, UserParamRequisition.asInsertedById);
        }
        //Exam Shedule
        [HttpPost]
        [Route("Teacher/GetStandardDetails")]
        public List<GetStandardDetails> GetStandardDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetStandardDetails(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId);

        }
        //Exam Shedule
        [HttpPost]
        [Route("Teacher/GetExamDropDownForExamScheduleDetails")]
        public List<GetExamDropDownForExamScheduleDetails> GetExamDropDownForExamScheduleDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetExamDropDownForExamScheduleDetails(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYrId, UserParamRequisition.asStandardId);

        }

        // student record -- class dropdown
        [HttpPost]
        [Route("Teacher/GetAllTeachers")]
        public GetAllTeachersMaster GetAllTeachers([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllTeachers(userAPIparam.AsSchoolId, userAPIparam.AsAcademicYearId, userAPIparam.AsUserId, userAPIparam.AsHasFullAccess);
        }

        // add leave details -- balance note
        [HttpPost]
        [Route("Teacher/GetLeaveBalance")]
        public List<GetLeaveBalance> GetLeaveBalance([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetLeaveBalance(UserParamRequisition.asSchoolId, UserParamRequisition.asUserId);

        }

        // Add Leave Details -- Approve btn
        [HttpPost]
        [Route("Teacher/ApproveOrRejectLeave")]
        public string LeaveApproveBtn([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.LeaveApproveBtn(UserParamRequisition.asId, UserParamRequisition.asUserLeaveDetailsId, UserParamRequisition.asReportingUserId, UserParamRequisition.asRemark, UserParamRequisition.asstatusId, UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearId, UserParamRequisition.asInsertedById);
        }

        // Add Leave Details -- Submit btn
        [HttpPost]
        [Route("Teacher/SubmitLeaveBtn")]
        public string SubmitLeaveBtn([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.SubmitLeaveBtn(UserParamRequisition.asId, UserParamRequisition.asUserId, UserParamRequisition.asLeaveId, UserParamRequisition.asStartDate, UserParamRequisition.asEndDate, UserParamRequisition.asTotalDays, UserParamRequisition.asChargeHandoverTo, UserParamRequisition.asDescription, UserParamRequisition.asSchoolId, UserParamRequisition.asInsertedById, UserParamRequisition.asAcademicYearId);
        }

        [HttpPost]
        [Route("Teacher/GetConfiguredLeavesType")]
        public List<GetConfiguredLeaves> GetConfiguredLeavesType([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetConfiguredLeavesType(UserParamRequisition.asSchoolId);
        }

        // Student(Edit) -- dropdown
        [HttpPost]
        [Route("Teacher/GetStudentsForm")]
        public GetAllStudentsDetails GetStudentsForm([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentsForm(userAPIparam.asiSchoolId, userAPIparam.asiAcademicYear, userAPIparam.asiStandardId, userAPIparam.asiDivisionId);
        }

        // Students(Edit) -- remove photo
        [HttpPost]
        [Route("Teacher/RemoveStudentPhoto")]
        public string RemoveStudentPhoto([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.RemoveStudentPhoto(UserParamRequisition.asSchoolId, UserParamRequisition.asStudentId);
        }

        // Students(Edit) -- Studentwise document
        [HttpPost]
        [Route("Teacher/StandrdwiseStudentsDocument")]
        public List<StandrdwiseStudentsDocument> StudentsDocument([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.StudentsDocument(UserParamRequisition.asSchoolId, UserParamRequisition.asStandardId, UserParamRequisition.asStudentId, UserParamRequisition.asAcademicYearId);
        }

        // Students(Edit) -- save student document
        [HttpPost]
        [Route("Teacher/SaveStudentDocument")]
        public string SaveStudentDocument([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.SaveStudentDocument(UserParamRequisition.asSubmittedDocumentXML, UserParamRequisition.asStudentId, UserParamRequisition.asSchoolId, UserParamRequisition.asInsertedById);
        }

        // Students(Edit) -- StaffName Teachers
        [HttpPost]
        [Route("Teacher/StaffName")]
        public List<StaffNameTeachers> StaffNameTeachers([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.StaffNameTeachers(UserParamRequisition.asSchoolId, UserParamRequisition.asUserRoleId, UserParamRequisition.asAcademicYearId);
        }

        // Pre Primary Result) -- Publish Unpublish
        [HttpPost]
        [Route("Teacher/PublishUnpublishPrePrimaryResult")]
        public string PublishUnpublishPrePrimaryResult([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.PublishUnpublishPrePrimaryResult(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademic_Year_Id, UserParamRequisition.asStandardDivisionId, UserParamRequisition.asAssessmentId, UserParamRequisition.asUnPublishReason, UserParamRequisition.asInsertedById, UserParamRequisition.asUpdatedById, UserParamRequisition.IsPublish);
        }

        // Absent student details
        [HttpPost]
        [Route("Teacher/AbsentStudentDetailsId")]
        public AbsentStudentsId GetAbsentStudentsId([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAbsentStudentsId(userAPIparam.asSchoolId, userAPIparam.asAcademicYearid, userAPIparam.asStandardDivisionId, userAPIparam.asSelectDate, userAPIparam.asMaxDaysLimit);
        }

        // Absent student details
        [HttpPost]
        [Route("Teacher/AbsentStudentDetails")]
        public AbsentStudents GetAbsentStudents([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAbsentStudents(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asSelectedDate, userAPIparam.asMaxDaysLimit);
        }

        // Dashboard
        [HttpPost]
        [Route("Teacher/GetDashboardBirthdayRecords")]
        public DashboardBirthdayRecords GetDashboardBirthdayRecords([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetDashboardBirthdayRecords(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asTeacherId);
        }

        // Absent student details Popup
        [HttpPost]
        [Route("Teacher/GetAbsentStudentDetailsPopup")]
        public GetAbsentStudentDetailsForPopup GetAbsentStudentDetailsForPopup([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAbsentStudentDetailsForPopup(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId);
        }


        //SNS School Library API--- GetAllLanguageForDropDown

        [HttpPost]
        [Route("Teacher/GetAllLanguageForDropDown")]
        public List<GetAllLanguageForDropDown> GetAllLanguageForDropDown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllLanguageForDropDown(userAPIparam.asSchoolId);
        }

        //SNS School Library API---  GetAllStandardDropDown

        [HttpPost]
        [Route("Teacher/GetAllStandardDropDown")]
        public List<GetAllStandardDropDown> GetAllStandardDropDown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllStandardDropDown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }

        //SNS School Library API---   GetAllBooksDetails

        [HttpPost]
        [Route("Teacher/GetAllBooksDetails")]
        public GetAllBooksDetailsMaster GetAllBooksDetails([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.GetAllBooksDetails(userAPIparam.asprm_iSchoolId, userAPIparam.Book_Title, userAPIparam.Author_Name, userAPIparam.Published_By, userAPIparam.AccessionNumber, userAPIparam.Language,userAPIparam.Is_Printable, userAPIparam.asprm_iStandardId, userAPIparam.asSortExp, userAPIparam.asStartIndex, userAPIparam.asEndIndex, userAPIparam.asprm_iParentStaffId);
        }

        //SNS School Library API---   GetLibraryBookIssueDetails

        [HttpPost]
        [Route("Teacher/GetLibraryBookIssueDetails")]
        public List<GetLibraryBookIssueDetails> GetLibraryBookIssueDetails([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.GetLibraryBookIssueDetails(userAPIparam.asSchool_Id, userAPIparam.asBook_Issued_To, userAPIparam.asAcademic_Year_Id);
        }

        //SNS School Library API---  Book claimed 

        [HttpPost]
        [Route("Teacher/Bookclaimed")]
        public string Bookclaimed([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.Bookclaimed(UserParamRequisition. asBookId, UserParamRequisition. asUserId, UserParamRequisition. asReservedByParent, UserParamRequisition. asSchoolId, UserParamRequisition. asAcademicYearId, UserParamRequisition. asInsertedById);
        }

        //SNS  School Library API----  Total Book count 
        //[HttpPost]
        //[Route("Teacher/GetTotalBooksCounts")]
        //public GetTotalBooksCountsMaster GetTotalBooksCounts([FromBody] UserParamRequisition UserParamRequisition)
        //{
        //    return this.teacher.GetTotalBooksCounts(UserParamRequisition.asprm_iSchoolId, UserParamRequisition.asprm_Filter, UserParamRequisition.asprm_BookNo, UserParamRequisition.asprm_iStandardId, UserParamRequisition.asprm_iParentStaffId);
        //}

        //SNS School Library API ----  GetReserveBookDetails

        [HttpPost]
        [Route("Teacher/GetReserveBookDetails")]
        public GetReserveBookDetailsMaster GetReserveBookDetails([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetReserveBookDetails(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearId, UserParamRequisition.asUserID, UserParamRequisition.asStartIndex, UserParamRequisition.asEndIndex, UserParamRequisition.asBookTitle, UserParamRequisition.asUserName, UserParamRequisition.asSortExpression, UserParamRequisition.asAllUserFlag);
        }

        //SNS School Library API ----  GetReserveBooksCountperperson
        [HttpPost]
        [Route("Teacher/GetReserveBooksCountperperson")]
        public List<GetReserveBooksCountperperson> GetReserveBooksCountperperson([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.GetReserveBooksCountperperson(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asBookId, userAPIparam.asUserId,userAPIparam.asFlag);
        }

        //SNS School Library API ----  CancelBookReservation

        [HttpPost]
        [Route("Teacher/CancelBookReservation")]
        public string CancelBookReservation([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.CancelBookReservation(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearId, UserParamRequisition.asUserId, UserParamRequisition.asBookid);
        }

        //Message Center -----Contact group ---- Edit Group
        [HttpPost]
        [Route("Teacher/GetMailingGroupsEdit")]
        public GetMailingGroupsEditMaster GetMailingGroupsEdit([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetMailingGroupsEdit(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearId, UserParamRequisition.asGroupId, UserParamRequisition.asRoleId, UserParamRequisition.asUserId);
        }

        //

        //[HttpPost]
        //[Route("Teacher/CountUsersAndStoreCounts")]
        //public CountUsersAndStoreCountsMaster CountUsersAndStoreCounts([FromBody] UserParamRequisition UserParamRequisition)
        //{
        //    return this.teacher.CountUsersAndStoreCounts(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearId, UserParamRequisition.asGroupId, UserParamRequisition.asRoleId, UserParamRequisition.asStandardDivisionId, UserParamRequisition.asCount, UserParamRequisition.asFilter);
        //}
        [HttpPost]
        [Route("Teacher/CountUsersAndStoreCounts")]
        public List<CountUsersAndStoreCounts> CountUsersAndStoreCounts([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.CountUsersAndStoreCounts(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearId, UserParamRequisition.asGroupId, UserParamRequisition.asRoleId, UserParamRequisition.asStandardDivisionId,  UserParamRequisition.asFilter);
        }


        [HttpPost]
        [Route("Teacher/GetUsers")]
        public List<GetUsers> GetUsers([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.GetUsers(userAPIparam.asSchool_Id, userAPIparam.asAcademicYearId, userAPIparam.asGroupId);
        }

        //Photo/vedio Gallery   ----  ManagePhotoGallery
        [HttpPost]
        [Route("Teacher/ManagePhotoGallery")]
        public string ManagePhotoGallery([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.ManagePhotoGallery(UserParamRequisition.asSchool_Id, UserParamRequisition.asOrg_Gallery_Name, UserParamRequisition.asGallery_Name, UserParamRequisition.asGallery_DetailsXML, UserParamRequisition.asInserted_By_id, UserParamRequisition.asAssociatedSection, UserParamRequisition.asClassesIds, UserParamRequisition.Gallery_ID, UserParamRequisition.additionalAttachmentFile, UserParamRequisition.asSaveFeature, UserParamRequisition.asFolderName, UserParamRequisition.asBase64String, UserParamRequisition.asFileName);
        }
        //Photo/vedio Gallery   ----  StandardDivisionName
        [HttpPost]
        [Route("Teacher/GetStandardDivisionName")]
        public List<GetStandardDivisionName> GetStandardDivisionName([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.GetStandardDivisionName(userAPIparam.asSchool_Id, userAPIparam.asAcademicYearId);
        }
        //edit video gallery
        [HttpPost]
        [Route("Teacher/GetVideoDetailsForEdit")]
        public List<GetVideoDetailsForEdit> GetVideoDetailsForEdit([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.GetVideoDetailsForEdit(userAPIparam.asSchool_Id, userAPIparam.asVideoId, userAPIparam.asSubjectId, userAPIparam.asUrlSourceId);
        }

        //Photo/vedio Gallery   ----  UpdateGalleryName
        [HttpPost]
        [Route("Teacher/UpdateGalleryName")]
        public string UpdateGalleryName([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.UpdateGalleryName(userAPIparam.asSchool_Id, userAPIparam.asOldGalleryName, userAPIparam.asNewGalleryName, userAPIparam.asUpdated_By_id, userAPIparam.asAssociatedSection, userAPIparam.asClassesIds, userAPIparam.Gallery_ID);
        }

        //Photo/vedio Gallery   ----  Add Vedio Gallery
        [HttpPost]
        [Route("Teacher/InsertVideoGallary")]
        public string InsertVideoGallary([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.InsertVideoGallary(userAPIparam.asSchoolId, userAPIparam.asVideoId, userAPIparam.asVideoName, userAPIparam.asVideoDetails, userAPIparam.asStartDate, userAPIparam.asEndDate, userAPIparam.asUserRoleIds, userAPIparam.asStandardDivIds, userAPIparam.asSubjectId, userAPIparam.asShowOnExternalWebsite, userAPIparam.asInsertedById, userAPIparam.asAddMoreSubjects, userAPIparam.asOldSubjectId, userAPIparam.asId, userAPIparam.asUrlSourceId);
        }
        //Photo/vedio Gallery   ----  View Photo Gallery
        [HttpPost]
        [Route("Teacher/GetAllImages")]
        public List<GetAllImages> GetAllImages([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.GetAllImages(userAPIparam.asSchool_Id, userAPIparam.asGallery_Name, userAPIparam.asstartIndex, userAPIparam.asendIndex, userAPIparam.asFolderName);
        }

        [HttpPost]
        [Route("Teacher/GetPhotoCount")]
        public List<GetPhotoCount> GetPhotoCount([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.GetPhotoCount(userAPIparam.asSchool_Id, userAPIparam.asGallery_Name);
        }

        [HttpPost]
        [Route("Teacher/UpdateComment")]
        public string UpdateComment([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.UpdateComment(userAPIparam.asSchool_Id, userAPIparam.ascomment, userAPIparam.asGallery_Id);
        }
        [HttpPost]
        [Route("Teacher/DeletePhoto")]
        public string DeletePhoto([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.DeletePhoto(userAPIparam.asSchool_Id, userAPIparam.asGallery_Id);
        }

        //Feedback Details   ----  Add New Feedback
        //[HttpPost]
        //[Route("Teacher/InsertFeedbackDetails")]
        //public string InsertFeedbackDetails([FromBody] UserParamRequisition userAPIparam)
        //{
        //    return this.teacher.InsertFeedbackDetails(userAPIparam.asSchool_Id, userAPIparam.asUser_Id, userAPIparam.asFeedbackDescription, userAPIparam.asFeedback_Type_Id, userAPIparam.asInsertedById, userAPIparam.asFeedbackFor, userAPIparam.asEmail, userAPIparam.asUserName);
        //}

        // Edit photo gallery
        [HttpPost]
        [Route("Teacher/EditSections")]
        public List<GetSections> GetSections([FromBody] UserParamRequisition userAPIparam)
        {
            return teacher.GetSections(userAPIparam.asGalleryName, userAPIparam.asSchoolId);
        }

        // Edit photo gallery
        [HttpPost]
        [Route("Teacher/EditStandardDivisions")]
        public List<GetStandardDivisions> GetStandardDivisions([FromBody] UserParamRequisition userAPIparam)
        {
            return teacher.GetStandardDivisions(userAPIparam.asGalleryName, userAPIparam.asSchoolId);
        }

        [HttpPost]
        [Route("Teacher/GetStudentDetailss")]
        public List<GetStudentDetailss> GetStudentDetailss([FromBody] UserParamRequisition userAPIparam)
        {
            return teacher.GetStudentDetailss(userAPIparam.asSchool_Id, userAPIparam.asAcademicYearId,userAPIparam.asStudentId);
        }

        [HttpPost]
        [Route("Teacher/GetPagedStudents")]
        public GetPagedStudentsMaster GetPagedStudents([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetPagedStudents(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearId, UserParamRequisition.asFilter, UserParamRequisition.asStartIndex, UserParamRequisition.asEndIndex,UserParamRequisition.asSortExp);
        }
        [HttpPost]
        [Route("Teacher/IsDuplicatePhotoGalleryName")]
        public bool IsDuplicatePhotoGalleryName([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.IsDuplicatePhotoGalleryName(UserParamRequisition.asSchoolId, UserParamRequisition.asGallery_Name, UserParamRequisition.asOrg_Gallery_Name, UserParamRequisition.asOperation);
        }
        [HttpPost]
        [Route("Teacher/GetImages")]
        public List<GetImages> GetImages([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.GetImages(UserParamRequisition.asSchoolId, UserParamRequisition.asGallery_Name);
        }
        [HttpPost]
        [Route("Teacher/SavePhotoGallery")]
        public string SavePhotoGallery([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.SavePhotoGallery(UserParamRequisition.asSchool_Id, UserParamRequisition.asOperation, UserParamRequisition.asOrg_Gallery_Name, UserParamRequisition.asGallery_Name, UserParamRequisition.asGallery_DetailsXML, UserParamRequisition.asInserted_By_id, UserParamRequisition.asAssociatedSection, UserParamRequisition.asClassesIds, UserParamRequisition.Gallery_ID, UserParamRequisition.additionalAttachmentFile, UserParamRequisition.asSaveFeature, UserParamRequisition.asFolderName, UserParamRequisition.asBase64String, UserParamRequisition.asFileName);
        }

        //----------
        [HttpPost]
        [Route("Teacher/ReserveBooks_Per_Person")]
        public List<ReserveBooks_Per_Person> ReserveBooks_Per_Person([FromBody] UserParamRequisition UserParamRequisition)
        {
            return this.teacher.ReserveBooks_Per_Person(UserParamRequisition.asSchoolId, UserParamRequisition.asAcademicYearId, UserParamRequisition.asUserRoleID);
        }


        [HttpPost]
        [Route("Teacher/InsertFeedbackDetails")]
        public string InsertFeedbackDetails([FromBody] UserParamRequisition userAPIparam)
        {
            return this.teacher.InsertFeedbackDetails(
                userAPIparam.asFeedbackId,
                userAPIparam.asSchool_Id,
                userAPIparam.asUser_Id,
                userAPIparam.asFeedbackDescription,
                userAPIparam.asFeedback_Type_Id,
                userAPIparam.asInsertedById,
                userAPIparam.asFeedbackFor,
                userAPIparam.asEmail,
                userAPIparam.asUserName
            );
        }
    }
}