using SchoolMobileEntities;
using SchoolMobileInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Xml.Linq;
using Utility;
using static SchoolMobileEntities.DevsionNameDetiles;

namespace RITSchoolMobile.Controllers
{
    public class SchoolController : ApiController
    {
        private readonly ISchool school;

        public SchoolController(ISchool school)
        {
            this.school = school;
        }

        [HttpPost]
        [Route("School/GetWeekDays")]
        public WeekDaysList GetWeekDays([FromBody] SchoolParam schoolAPIParam)
        {
            return this.school.GetWeekDays(schoolAPIParam.asSchoolId, schoolAPIParam.asAcademicYearId);
        }


        [HttpPost]
        [Route("School/GetAllSchools")]
        public SchoolList GetAllSchools([FromBody] SchoolParam schoolAPIParam)
        {
            return this.school.GetAllSchools(schoolAPIParam.asSchoolId);
        }
        
        [HttpPost]
        [Route("School/GetHolidayList")]
        public HolidayList GetHolidayList([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetHolidayList(schoolParam.asSchoolId, schoolParam.asAcademicYearId,schoolParam.asStandardId,schoolParam.asDivisionId);
        }
        [HttpPost]
        [Route("School/GetSchoolNotices")]
        public SchoolNoticeList GetSchoolNotices([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetSchoolNotices(schoolParam.asSchoolId, schoolParam.asNoticeId, schoolParam.asUserId);
        }
        [HttpPost]
        [Route("School/GetAllStandards")]
        public List<Standards> GetAllStandards([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetAllStandards(schoolParam.asSchoolId, schoolParam.asAcademicYearId);
        }
        [HttpPost]
        [Route("School/GetExamsForStandard")]
        public ExamList GetExamsForStandard([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetExamsForStandard(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardId);
        }
        [HttpPost]
        [Route("School/GetExamScheduleForStandard")]
        public ExamScheduleList GetExamScheduleForStandard(SchoolParam schoolParam)
        {
            return this.school.GetExamScheduleForStandard(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardId, schoolParam.asExamId);
        }
        [HttpPost]
        [Route("School/GetAllAcademicYears")]
        public AcademicYearlist GetAllAcademicYears([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetAllAcademicYears(schoolParam.asSchoolId);
        }
        [HttpPost]
        [Route("School/AcceptTerms")]
        public AcceptTerm AcceptTerms([FromBody]SchoolParam schoolParam)
        {
            return this.school.AcceptTerms(schoolParam.asSchoolId, schoolParam.asUserId);
        }
        [HttpPost]
        [Route("School/GetEventsInMonth")]
        public EventDetailsList GetEventsInMonth([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetEventsInMonth(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asMonth, schoolParam.asYear, schoolParam.asUserId, schoolParam.abIncludeEvents, schoolParam.abIncludeHolidays, schoolParam.abIncludeExams);
        }
        [HttpPost]
        [Route("School/GetEventsDetails")]
        public EventDetail GetEventsDetails([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetEventsDetails(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asEventId);
        }
        [HttpPost]
        [Route("School/ChangePassword")]
        public string ChangePassword([FromBody]SchoolParam schoolParam)
        {
            return this.school.ChangePassword(schoolParam.asUserName, schoolParam.asUserId, schoolParam.asSchoolId, schoolParam.asNewPassword, schoolParam.asOldPassword);
        }
        [HttpPost]
        [Route("School/GetAttendanceStatusOfClasses")]
        public DaywiseAttendanceList GetAttendanceStatusOfClasses([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetAttendanceStatusOfClasses(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asDate);
        }
        [HttpPost]
        [Route("LogErrorAtClientSide")]
        public void LogErrorAtClientSide ([FromBody]SchoolParam schoolParam)
        {
            this.school.LogErrorAtClientSide(schoolParam.asSchoolId, schoolParam.asMessage, (string)schoolParam.asMethodName, schoolParam.asUserId);
        }
        
        [HttpPost]
        [Route("School/GetPassword")]
        public string GetPassword([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetPassword(schoolParam.asSchoolId, schoolParam.asLogin, schoolParam.asDOB, schoolParam.asEmailId);
        }
        [HttpPost]
        [Route("School/IsFacilityEnabled")]
        public bool IsFacilityEnabled([FromBody]SchoolParam schoolParam)
        {
            return this.school.IsFacilityEnabled(schoolParam.asType, schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUserRoleId = "");
        }
        [HttpPost]
        [Route("School/GetSchoolSettings")]
        public SchoolSetting GetSchoolSettings([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetSchoolSettings(schoolParam.asSchoolId);
        }
        [HttpPost]
        [Route("School/GetSchoolSettingValues")]
        public List<SchoolSettingValue> GetSchoolSettingValues([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetSchoolSettingValues(schoolParam.asSchoolId,
                schoolParam.asAcademicYearId, schoolParam.asKey);
        }
        [HttpPost]
        [Route("School/GetSingleSignOnPageEncryptedURL")]
        public EncryptedURL GetSingleSignOnPageEncryptedURL([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetSingleSignOnPageEncryptedURL(schoolParam.asSchoolId, schoolParam.asUserLogin, schoolParam.asQueryString, schoolParam.asSchoolSiteUrl, schoolParam.asRedirectPageUrl);
        }
        [HttpPost]
        [Route("School/GetSettingValue")]
        public SettingValue GetSettingValue([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetSettingValue(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asKey);
        }
        [HttpPost]
        [Route("School/GetAllAcademicYearsForSchool")]
        public AcademicYearsForSchool GetAllAcademicYearsForSchool([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetAllAcademicYearsForSchool(schoolParam.asSchoolId, schoolParam.asUserId, schoolParam.asUserRoleId);
        }

        [HttpPost]
        [Route("School/GetIsPrePrimary")]
        public Boolean GetIsPrePrimary([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetIsPrePrimary(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardId);
        }

        [HttpPost]
        [Route("School/GetUserBirthdayDetails")]
        public BirthdayDetail GetUserBirthdayDetails([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetUserBirthdayDetails(schoolParam.asSchoolId, schoolParam.asUserId);
        }

        [HttpPost]
        [Route("School/GetAllMonths")]
        public MonthList GetAllMonths([FromBody]SchoolParam schoolParam)
        {
            return this.school.GetAllMonths(schoolParam.asSchoolId, schoolParam.asAcademicYearId);
        }








//-----------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        [Route("School/GetStudentUIPreConditionMsg")]
        public StudentsUiList GetStudentUIPreConditionMsg([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetStudentUIPreConditionMsg(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardId);
        }


        [HttpPost]
        [Route("School/IsClassTeacher")]
        public CteacherList IsClassTeacher([FromBody] SchoolParam schoolParam)
        {
            return this.school.IsClassTeacher(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUserId);
        }

        [HttpPost]
        [Route("School/GetBinaryImages")]
        public ImageList GetBinaryImages([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetBinaryImages(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUserId, schoolParam.asPhotoTypeId);
        }


        [HttpPost]
        [Route("School/IsAnyExamPublished")]
        public examList IsAnyExamPublished([FromBody] SchoolParam schoolParam)
        {
            return this.school.IsAnyExamPublished(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardId, schoolParam.asDivisionId, schoolParam.asIsExamPublished);
        }

        [HttpPost]
        [Route("School/GetStudentMandatoryFields")]
        public FileList GetStudentMandatoryFields([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetStudentMandatoryFields(schoolParam.asSchoolId);
        }

        [HttpPost]
        [Route("School/GenerateTransportFeeEntries")]
        public string GenerateTransportFeeEntries([FromBody] UserParam userAPIparam)
        {
            return this.school.GenerateTransportFeeEntries(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUpdatedById, userAPIparam.asStudentId);
        }


        [HttpPost]
        [Route("School/GetFormNumber")]
        public FormList GetFormNumber([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetFormNumber(schoolParam.asSchoolId, schoolParam.asStudentId);
        }


        [HttpPost]
        [Route("School/CheckIfAttendanceMarked")]
        public List<AttenCount> CheckIfAttendanceMarked([FromBody] SchoolParam schoolParam)
        {
            return this.school.CheckIfAttendanceMarked(schoolParam.asSchoolId, schoolParam.dateTime, schoolParam.asDivisionId, schoolParam.asStandardId);
        }

        [HttpPost]
        [Route("School/CheckIsRFormNumberDuplicate")]
        public string CheckIsRFormNumberDuplicate([FromBody] SchoolParam schoolParam)
        {
            return this.school.CheckIsRFormNumberDuplicate(schoolParam.asSchoolId, schoolParam.sFormNo);
        }




















        [HttpPost]
        [Route("School/GetAllNotice")]
        public schoolNotice GetAllNotice([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetAll(schoolParam.aiSchoolId, schoolParam.asDisplayLocation, schoolParam.aiShowAllNotices, schoolParam.abText, schoolParam.asSortExpression, schoolParam.aiEndRowIndex, schoolParam.asStartRowIndex);
        }
        [HttpPost]
        [Route("School/GetSelectedNotice")]
        public void SaveSelectedNotices([FromBody] SchoolParam schoolParam)
        {
            this.school.SaveSelectedNotices(schoolParam.asXML, schoolParam.asSchoolId);
        }

        [HttpPost]
        [Route("School/GetSettingValueByName")]
        public SettingKeyResult GetSettingValueByName([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetSettingValueByName(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asKey);
        }

        [HttpPost]
        [Route("School/GetFinancialYearDetails")]
        public GetFinancialYearsResult GetFinancialYearDetails([FromBody] StudentParam studentParam)
        {
            return this.school.GetFinancialYearsDetails(studentParam.aiSchoolId);
        }

        [HttpPost]
        [Route("School/GetMenuDetails")]
        public GetMenuDetailsResult GetMenuDetails([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetMenuDetails(schoolParam.aiSchoolId.ToInt(), schoolParam.aiUserRoleId.ToInt());
        }

        [HttpPost]
        [Route("School/GetMenuDescription")]
        public GetMenuDetailsResult GetMenuDescription([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetMenuDescription(schoolParam.aiSchoolId.ToInt(), schoolParam.aiMenuId.ToInt());
        }
        [HttpPost]
        [Route("School/GetAllActiveNotices")]
        public SchoolNoticeList GetAllActiveNotices([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetAllActiveNotices(schoolParam.asSchoolId, schoolParam.asUserId, schoolParam.IsNewUI);
        }

        [HttpPost]
        [Route("School/GetExamScheduleFullacc")]
        public GetExamScheduleFullaccMasterR GetExamScheduleFullacc([FromBody] UserParam userAPIparam)
        {
            return this.school.GetExamScheduleFullacc(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }

        [HttpPost]
        [Route("School/GetAnnualPlannerFilePath")]
        public string GetAnnualPlannerFilePath([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetAnnualPlannerFilePath(schoolParam.aiSchoolId, schoolParam.aiAcademicYearId);
        }

        [HttpPost]
        [Route("School/GetStandardsForExamCopy")]
        public CopyExamStandardList GetStandardsForExamCopy([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetStandardsForExamCopy(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asSchoolwiseExamId);
        }
        [HttpPost]
        [Route("School/getSubjectExamScheduleList")]
        public getSubjectExamScheduleMasterR getSubjectExamScheduleList([FromBody] SchoolParam schoolParam)
        {
            return this.school.getSubjectExamScheduleList(schoolParam.asStandardId, schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardwiseExamScheduleId);
        }

        [HttpPost]
        [Route("School/UpdateExamScheduleInstructions")]
        public string UpdateExamScheduleInstructions([FromBody] UserParam UserParams)
        {
            return this.school.UpdateExamScheduleInstructions(UserParams.asSchoolId, UserParams.asSchoolwiseStandardExamScheduleId, UserParams.asInstructions, UserParams.asUpdatedById);
        }

        [HttpPost]
        [Route("School/UpdateStandardWiseExamSchedule")]
        public string UpdateStandardWiseExamSchedule([FromBody] SchoolParam schoolParam)
        {
            return this.school.UpdateStandardWiseExamSchedule(schoolParam.asSchoolId, schoolParam.asStandardwiseExamScheduleId, schoolParam.asUpdatedById);
        }

        [HttpPost]
        [Route("School/SumbitExamSchedule")]
        public string SumbitExamSchedule([FromBody] SchoolParam schoolParam)
        {
            return this.school.SumbitExamSchedule(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUpdatedById, schoolParam.asStandardId, schoolParam.asIsUnSubmit, schoolParam.asSchoolwiseTestId);
        }

        [HttpPost]
        [Route("School/CopyExamschedule")]
        public string CopyExamschedule([FromBody] UserParam userAPIparam)
        {
            return this.school.CopyExamschedule(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardId, userAPIparam.asSourceStandardTestId, userAPIparam.asDestinationStandardsxml);
        }

        [HttpPost]
        [Route("Teacher/InsertExamSchedule")]
        public string InsertExamSchedule([FromBody] UserParam userAPIparam)
        {
            return school.InsertExamSchedule(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardId, userAPIparam.asSchoolwiseTestId, userAPIparam.asStandardTestId, userAPIparam.asInsertedById, userAPIparam.asScreenId, userAPIparam.asSchoolwiseStandardExamScheduleId, userAPIparam.asExamDetailsXML);
        }

        [HttpPost]
        [Route("School/GetIsSchoolConfigured")]
        public string GetIsSchoolConfigured([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetIsSchoolConfigured(schoolParam.asSchoolId, schoolParam.asOriginalConfigId, schoolParam.asAcademicYearId);
        }
        [HttpPost]
        [Route("School/InsertConfigurationSchoolMaster")]
        public string InsertConfigurationSchoolMaster([FromBody] SchoolParam schoolParam)
        {
            return this.school.InsertConfigurationSchoolMaster(schoolParam.asOriginalConfigId, schoolParam.asSchoolId, schoolParam.asIsConfigure, schoolParam.asInsertedById, schoolParam.asUpdateById, schoolParam.asAcademicYearId, schoolParam.aiFinancialYearId);
        }

        [HttpPost]
        [Route("School/InsertExamSchedule")]
        public DataSet InsertExamSchedules([FromBody] SchoolParam schoolParam)
        {
            return school.InsertExamSchedules(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardId, schoolParam.asSchoolwiseTestId, schoolParam.asStandardTestId, schoolParam.asInsertedById, schoolParam.asScreenId, schoolParam.asSchoolwiseStandardExamScheduleId, schoolParam.asExamDetailsXML);
        }


        // Block Progress Report
        [HttpPost]
        [Route("School/BlockUnBlockStudents")]
        public BlockUnBlockStudents BlockUnBlockStudents([FromBody] SchoolParam schoolParam)
        {
            return this.school.BlockUnBlockStudents(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardDivId, schoolParam.asShowblocked, schoolParam.asStudentId, schoolParam.asSearch, schoolParam.asSortExp, schoolParam.asStartIndex, schoolParam.asEndIndex);
        }

        // Block progress report
        [HttpPost]
        [Route("School/AllClassTeachers")]
        public List<AllClassTeachers> AllClassTeachers([FromBody] SchoolParam schoolParam)
        {
            return school.AllClassTeachers(schoolParam.asSchoolId, schoolParam.asAcademicYearId);
        }


        [HttpPost]
        [Route("School/GetgallaryImage")]
        public GalleryImg GetgallaryImage([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetgallaryImage(schoolParam.asSchoolId, schoolParam.asGalleryName, schoolParam.IsDeleted);
        }


        [HttpPost]
        [Route("School/GetStudentListForDropDownList")]
        public StudList GetStudentListForDropDownList([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetStudentListForDropDownList(schoolParam.asSchoolId, schoolParam.asAcademicYrId, schoolParam.asDivisionId);
        }


        [HttpPost]
        [Route("School/GetTeacherDetailsOfYearnew")]
        public List<TeacherDetailsOfYearnew> GetTeacherDetailsOfYearnew([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetTeacherDetailsOfYearnew(schoolParam.asSchoolId, schoolParam.asAcademicYrId, schoolParam.asTeacherId);
        }

        [HttpPost]
        [Route("School/AdminStaffDetailsLiat")]
        public AdminStaff1 GetAdminStaffDetails([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetAdminStaffDetails(schoolParam.asSchoolId);
        }

        [HttpPost]
        [Route("School/GetConsolidatedMarkDetails")]
        public List<ConsolidatedMarkDetailsResult> GetConsolidatedMarkDetails([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetConsolidatedMarkDetails(
                schoolParam.asSchoolId,
                schoolParam.asAcademicYearId,
                schoolParam.asStandardId,
                schoolParam.asDivisionId,
                schoolParam.asTestId,
                schoolParam.asSubjectId
            );
        }

        [HttpPost]
        [Route("School/GetAllTestsForClassSUbject")]
        public List<TestListDetails> GetTestForClassSubject([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetTestForClassSubject(schoolParam.asSchoolId, schoolParam.asAcademicYrId, schoolParam.asStdDivId, schoolParam.asSubjectId);
        }

        [HttpPost]
        [Route("School/DivisionnameList")]
        public List<Divisionname> DivisionnameList([FromBody] SchoolParam schoolParam)
        {
            return this.school.DivisionnameList(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardId);
        }

        [HttpPost]
        [Route("School/Schoolwise_Division_Subject_Master")]
        public List<SubjectList> GetSubjects([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetSubjects(schoolParam.asSchoolId, schoolParam.asAcademicYrId, schoolParam.asStandardDivisionId);
        }

        //CountNoticeBoardDetails - NoticeBoardBasescreen
        [HttpPost]
        [Route("School/GetCountNoticeBoardDetail")]
        public List<CountNoticeBoardDetail> CountNoticeBoardDetails([FromBody] SchoolParam schoolParam)
        {
            return this.school.CountNoticeBoardDetails(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.ascnt);
        }

        //dbo.GetNoticeBoardDetails Original - NoticeBoardBasescreen-------------------------------
        [HttpPost]
        [Route("School/NoticeBoardDetailsList")]
        public List<NoticeBoardDetail> GetNoticeBoardDetails([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetNoticeBoardDetails(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asSortExp, schoolParam.asStartIndex, schoolParam.asPageSize);
        }

        [HttpPost]
        [Route("School/InsertOrUpdateNoticeBoardDetails")]
        public string InsertOrUpdateNoticeBoardDetails([FromBody] SchoolParam schoolParam)
        {
            return this.school.InsertOrUpdateNoticeBoardDetails(schoolParam.asMessageId, schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asNoticeMessage, schoolParam.adtStartDate, schoolParam.adtEndDate, schoolParam.asInsertedOrUpdatedById, schoolParam.adtUpdateDate, schoolParam.asUserRoleIds);
        }


        [HttpPost]
        [Route("School/InsertNoticeBoardRoles")]
        public string InsertNoticeBoardRoles([FromBody] SchoolParam schoolParam)
        {
            return this.school.InsertNoticeBoardRoles(schoolParam.asMessageId, schoolParam.asUserRoleId, schoolParam.asInsertedById, schoolParam.adtInsertDate, schoolParam.asSchoolId);

        }


        [HttpPost]
        [Route("School/GetPAGEDUserList")]
        public List<GetPAGEDUserListN> GetPAGEDUserList([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetPAGEDUserList(schoolParam.asSchoolId, schoolParam.asUserRoleId, schoolParam.asUserTypeId, schoolParam.asAcademicYearId, schoolParam.asSortDir, schoolParam.asSortExp, schoolParam.asCriteria, schoolParam.asStartIndex, schoolParam.asPageSize);
        }

        [HttpPost]
        [Route("School/GetUserRoles")]
        public List<UserRoles> GetUserRoles([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetUserRoles(schoolParam.asSchoolId);
        }

        [HttpPost]
        [Route("School/DeleteNoticeBoardDetails")]
        public string DeleteNoticeBoardDetails([FromBody] SchoolParam schoolParam)
        {
            return this.school.DeleteNoticeBoardDetails(schoolParam.asSchoolId, schoolParam.asMessageId, schoolParam.asAcademicYearId, schoolParam.asDeletedById);
        }

        [HttpPost]
        [Route("School/RetriveUserRolesforNotice")]
        public UserRoleList RetriveUserRolesforNotice([FromBody] SchoolParam schoolParam)
        {
            return this.school.RetriveUserRolesforNotice(schoolParam.asSchoolId);
        }

        [HttpPost]
        [Route("School/GetYearwiseSubjectList")]
        public List<GetYearwiseSubjectList> GetYearwiseSubjectList([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetYearwiseSubjectList(schoolParam.asSchoolId, schoolParam.asAcademicYearId,schoolParam.asStandardId,schoolParam.asStandardDivisionId);
        }

        [HttpPost]
        [Route("School/GetFeedbackTypeAndTemplates")]
        public FeedbackDataList GetFeedbackTypesAndTemplates([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetFeedbackTypesAndTemplates(
                schoolParam.asSchoolId
            );
        }

        [HttpPost]
        [Route("School/GetPagedStudents")] 
        public List<GetPagedStudentsList> GetPagedStudents([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetPagedStudents(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asFilter, schoolParam.asStartIndex, schoolParam.asEndIndex, schoolParam.asSortExp, schoolParam.asUserTypeId);
        }

        [HttpPost]
        [Route("School/GetUserDocumentDetails")]
        public List<GetUserDocumentDetailsList> GetUserDocumentDetails([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetUserDocumentDetails(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUserId, schoolParam.asFinancialYearId);
        }

        [HttpPost]
        [Route("School/GetNoticeBoardRoles")]
        public List<NoticeBoardRole> GetNoticeBoardRoles([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetNoticeBoardRoles(schoolParam.asSchoolId);
        }

        [HttpPost]
        [Route("School/GetSortingFieldsRecords")]
        public SortingFieldList GetSortingFields([FromBody] SchoolParam schoolParam)
        {
            return this.school.GetSortingFields(schoolParam.asSchoolId);
        }

        [HttpPost]
        [Route("School/GenerateStudentRollNo")]
        public string RegenerateStudentRollNo([FromBody] SchoolParam schoolParam)
        {
            return this.school.RegenerateStudentRollNo(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardId, schoolParam.asDivisionId, schoolParam.asFilter);
        }

        [HttpPost]
        [Route("School/UpdateStudentsRollNos")]
        public string UpdateStudentsRollNos([FromBody] SchoolParam schoolParam)
        {
            return this.school.UpdateStudentsRollNos(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardId, schoolParam.asDivisionId, schoolParam.sXmlStudentsRollNos);
        }

        [HttpPost]
        [Route("School/GetRetrivedNoticeBoardRoles")]
        public DataTable RetrieveRolesFromNoticeBoardRoles([FromBody] SchoolParam schoolParam)
        {
            return this.school.RetrieveRolesFromNoticeBoardRoles(schoolParam.asSchoolId, schoolParam.asMessageId);
        }

    }
}

