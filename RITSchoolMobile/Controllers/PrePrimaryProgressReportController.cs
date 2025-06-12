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
    public class PrePrimaryProgressReportController : ApiController
    {
        private readonly IPrePrimaryProgressReport teacher;

        public PrePrimaryProgressReportController(IPrePrimaryProgressReport teacher)
        {
            this.teacher = teacher;
        }


        //Start Your Controller Code from Here
        //publish status
        [HttpPost]
        [Route("Teacher/GetFinalPublishedExamStatus")]
        public GetFinalPublishedExamStatus GetFinalPublishedExamStatus([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetFinalPublishedExamStatus(userAPIparam.asStandardDivId, userAPIparam.asTerm_Id, userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        //Mark As Read
        [HttpPost]
        [Route("Teacher/StudentRecordMarkRecordAsRead")]
        public string MarkRecordAsRead([FromBody] UserParam userAPIparam)
        {
            return teacher.MarkRecordAsRead(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asSchoolwiseStudentId);
        }
        //
        [HttpPost]
        [Route("Teacher/GetPrimaryClassTeachersDropdown")]
        public List<GetPrimaryClassTeachersDropdown> GetPrimaryClassTeachersDropdown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetPrimaryClassTeachersDropdown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        //
        //
        [HttpPost]
        [Route("Teacher/GetStudentDetailsDropdown")]
        public GetStudentDetailssMaster GetStudentDetailsDropdown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetStudentDetailsDropdown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asStudentId);
        }
        //PROGRESS REPORT DETAILS
        [HttpPost]
        [Route("Teacher/GetXseedProgressReportDetails")]
        public GetXseedProgressReportDetailsMaster GetXseedProgressReportDetails([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetXseedProgressReportDetails(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivId, userAPIparam.asYearwiseStudentId, userAPIparam.asAssessmentId);
        }
        // Pre-Primary Progress Report Results ---Publish Button
        [HttpPost]
        [Route("Teacher/PublishUnpublishXseedResult")]
        public string PublishButton([FromBody] UserParam userAPIparam)
        {
            return teacher.PublishButton(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStandardDivisionId, userAPIparam.asAssessmentId, userAPIparam.asMode, userAPIparam.asInsertedById);
        }
        //Final Result-Generate All-Pranav
        [HttpPost]
        [Route("Teacher/GenerateAllStudentsResult")]
        public string GenerateAllStudentsResult([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GenerateAllStudentsResult(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId, userAPIparam.asUserId, userAPIparam.asUseAvarageFinalResult);
        }
        //Students-Std dropdown 
        [HttpPost]
        [Route("Teacher/GetClassTeacherInfo")]
        public List<GetClassTeacherInfo> GetClassTeacherInfo([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassTeacherInfo(userAPIparam.asSchoolId, userAPIparam.asTeacherID, userAPIparam.asAcademicYearId);
        }
        //FinalResul-Classteacher dropdown
        [HttpPost]
        [Route("Teacher/GetClassTeachersDropdown")]
        public List<GetClassTeachersDropdown> GetClassTeachersDropdown([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetClassTeachersDropdown(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        //Lesson Plan AllTeacher-Arun
        [HttpPost]
        [Route("Teacher/GetAllTeachersOfLessonPlan")]
        public List<GetAllTeachersOfLessonPlan> GetAllTeachersOfLessonPlan([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetAllTeachersOfLessonPlan(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asReportingUserId, userAPIparam.asIsFullAccess);
        }


        //Pre-Primary Progress Report Results ---UnPublishReslt
        [HttpPost]
        [Route("Teacher/UnPublishReslt")]
        public string UnPublishReslt([FromBody] UserParam userAPIparam)
        {
            return teacher.UnPublishReslt(userAPIparam.asXseedResultPublishStatusId, userAPIparam.asSchoolId, userAPIparam.asAcademic_Year_Id, userAPIparam.asAssessmentId, userAPIparam.asStandardDivisionId, userAPIparam.asUnPublishReason, userAPIparam.asIsPublished, userAPIparam.asUpdatedById, userAPIparam.asUpdateDate);

        }


        //Pre-Primary Progress Report Results ---PublishReslt
        [HttpPost]
        [Route("Teacher/PublishReslt")]
        public string PublishReslt([FromBody] UserParam userAPIparam)
        {
            return teacher.PublishReslt(userAPIparam.asStandardDivisionId, userAPIparam.asAssessmentId, userAPIparam.asIsPublished, userAPIparam.asAcademic_Year_Id, userAPIparam.asSchoolId, userAPIparam.asInsertedById, userAPIparam.asInsertDate);

        }
        //student details form
        [HttpPost]
        [Route("Teacher/GetSingleStudentDetails")]
        public List<GetSingleStudentDetails> GetSingleStudentDetails([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetSingleStudentDetails(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asStudentId);
        }
        //students details save API
        [HttpPost]
        [Route("Teacher/InsertStudentSubmittedDocumentDetails")]
        public string InsertStudentSubmittedDocumentDetails([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.InsertStudentSubmittedDocumentDetails(UserAPIParamPre_PrimaryProgressReport.asSubmittedDocumentXML, UserAPIParamPre_PrimaryProgressReport.asStudentId, UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asInserted_By_id);
        }
        //Save student add note
        [HttpPost]
        [Route("Teacher/SaveStudentAchievementDetails")]
        public string SaveStudentAchievementDetails([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.SaveStudentAchievementDetails(UserAPIParamPre_PrimaryProgressReport.asAchievementId, UserAPIParamPre_PrimaryProgressReport.asStudentId, UserAPIParamPre_PrimaryProgressReport.asAchievementDate, UserAPIParamPre_PrimaryProgressReport.asDescription, UserAPIParamPre_PrimaryProgressReport.asAttachment, UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asUpdatedById, UserAPIParamPre_PrimaryProgressReport.asSaveFeature, UserAPIParamPre_PrimaryProgressReport.asFolderName, UserAPIParamPre_PrimaryProgressReport.asBase64String);
        }
        //get student details
        [HttpPost]
        [Route("Teacher/GetStudentAchievementDetails")]
        public List<GetStudentAchievementDetails> GetStudentAchievementDetails([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetStudentAchievementDetails(UserAPIParamPre_PrimaryProgressReport.asAchievementId, UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asStudentId);
        }

        // delete student achivement details
        [HttpPost]
        [Route("Teacher/DeleteStudentAchievementDetails")]
        public string DeleteStudentAchievementDetails([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.DeleteStudentAchievementDetails(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asStudentId, UserAPIParamPre_PrimaryProgressReport.asAchievementId, UserAPIParamPre_PrimaryProgressReport.asUpdatedById);
        }
        //get student details for achivement
        [HttpPost]
        [Route("Teacher/GetStudentNameForAchievementControl")]
        public List<GetStudentNameForAchievementControl> GetStudentNameForAchievementControl([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetStudentNameForAchievementControl(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asStudentId);
        }
        //get student all achievment list
        [HttpPost]
        [Route("Teacher/GetStudentsAllAchievementDetails")]
        public List<GetStudentsAllAchievementDetails> GetStudentsAllAchievementDetails([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetStudentsAllAchievementDetails(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asStudentId);
        }
        //ANNUAL Planner get all academic year
        [HttpPost]
        [Route("Teacher/GetAllAcademicYearsForSchool")]
        public List<GetAllAcademicYearsForSchool> GetAllAcademicYearsForSchool([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetAllAcademicYearsForSchool(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asUserId, UserAPIParamPre_PrimaryProgressReport.asUserRoleId);
        }
        // Event overview list
        [HttpPost]
        [Route("Teacher/GetAllEvents")]
        public List<GetAllEvents> GetAllEvents([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetAllEvents(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asMonthId, UserAPIParamPre_PrimaryProgressReport.asStandardId);
        }
        //Dashboard Get Teacherdetails
        [HttpPost]
        [Route("Teacher/GetTeacherDetailsForControlPanel")]
        public GetTeacherDetailsForControlPanelMaster GetTeacherDetailsForControlPanel([FromBody] UserParam userAPIparam)
        {
            return this.teacher.GetTeacherDetailsForControlPanel(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asTeacherID);
        }
        //Dashboard GetAllowedPagesForUser
        [HttpPost]
        [Route("Teacher/GetAllowedPagesForUser")]
        public List<GetAllowedPagesForUser> GetAllowedPagesForUser([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetAllowedPagesForUser(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asUserId, UserAPIParamPre_PrimaryProgressReport.asScreenLevel, UserAPIParamPre_PrimaryProgressReport.asConfigId);
        }
        //weekly time table save API
        [HttpPost]
        [Route("Teacher/ManageClassTimeTable")]
        public string ManageClassTimeTable([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.ManageClassTimeTable(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asInserted_By_id, UserAPIParamPre_PrimaryProgressReport.asStandardDivId, UserAPIParamPre_PrimaryProgressReport.asDayTimeTableMasterXml, UserAPIParamPre_PrimaryProgressReport.asDayTimeTableDetailsXml, UserAPIParamPre_PrimaryProgressReport.asAdditionalLectDetailsXml, UserAPIParamPre_PrimaryProgressReport.asIsAdditionalClass, UserAPIParamPre_PrimaryProgressReport.asIsCountInceased);
        }

        [HttpPost]
        [Route("Teacher/GetAllDocumentsList")]
        public List<GetAllDocumentsList> GetAllDocumentsList([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetAllDocumentsList(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asFinancialYearId, UserAPIParamPre_PrimaryProgressReport.asUserId, UserAPIParamPre_PrimaryProgressReport.asDocumentId, UserAPIParamPre_PrimaryProgressReport.asDocumentTypeId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asReportingUserId, UserAPIParamPre_PrimaryProgressReport.asLoginUserId);
        }

        [HttpPost]
        [Route("Teacher/GetUserInvestmentMethodDetails")]
        public GetUserInvestmentMethodDetails GetUserInvestmentMethodDetails([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetUserInvestmentMethodDetails(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asFinancialYearId, UserAPIParamPre_PrimaryProgressReport.asUserId,  UserAPIParamPre_PrimaryProgressReport.asDocumentId, UserAPIParamPre_PrimaryProgressReport.asDocumentTypeId);
        }

        [HttpPost]
        [Route("Teacher/CheckPublishUnpublishDocument")]
        public bool CheckPublishUnPublishDocument([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.CheckPublishUnPublishDocument(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asFinancialYearId, UserAPIParamPre_PrimaryProgressReport.asUserId);
        }

        // Add SMS Center --  SentItems -- Get SMS
        [HttpPost]
        [Route("Teacher/GetSentItems")]
        public List<GetSentItems> GetSentItems([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetSentItems(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asUser_Id, UserAPIParamPre_PrimaryProgressReport.asReceiver_User_Role_Id, UserAPIParamPre_PrimaryProgressReport.asAcademic_Year_Id, UserAPIParamPre_PrimaryProgressReport.asSortExp, UserAPIParamPre_PrimaryProgressReport.asprm_StartIndex, UserAPIParamPre_PrimaryProgressReport.asPageSize, UserAPIParamPre_PrimaryProgressReport.asName, UserAPIParamPre_PrimaryProgressReport.asContent, UserAPIParamPre_PrimaryProgressReport.asViewAllSMS);
        }

        
        // Add SMS Center --  SentItems -- Export SMS
        [HttpPost]
        [Route("Teacher/ExportSentItems")]
        public List<ExportSentItems> ExportSentItems([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.ExportSentItems(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asUser_Id, UserAPIParamPre_PrimaryProgressReport.asReceiver_User_Role_Id, UserAPIParamPre_PrimaryProgressReport.asAcademic_Year_Id, UserAPIParamPre_PrimaryProgressReport.asSortExp, UserAPIParamPre_PrimaryProgressReport.asprm_StartIndex, UserAPIParamPre_PrimaryProgressReport.asPageSize, UserAPIParamPre_PrimaryProgressReport.asName, UserAPIParamPre_PrimaryProgressReport.asContent, UserAPIParamPre_PrimaryProgressReport.asViewAllSMS);
        }

        // Add SMS center -- Sent Items-- delete SMS
        [HttpPost]
        [Route("Teacher/DeleteSMS")]
        public string DeleteSMS([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.DeleteSMS(UserAPIParamPre_PrimaryProgressReport.asSMS_Id, UserAPIParamPre_PrimaryProgressReport.asSchoolId);
        }

        // Add SMS Center --  SentItems -- Resend SMS
        [HttpPost]
        [Route("Teacher/ResendSMS")]
        public List<ResendSMS> ResendSMS([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.ResendSMS(UserAPIParamPre_PrimaryProgressReport.asSmsId, UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId);
        }

        // Add SMS Center --  ScheduleSMS -- Get SMS
        [HttpPost]
        [Route("Teacher/GetScheduleSMS")]
        public List<GetScheduleSMS> GetScheduleSMS([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetScheduleSMS(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asUserId, UserAPIParamPre_PrimaryProgressReport.asReceiverUserRoleId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asSortExp, UserAPIParamPre_PrimaryProgressReport.asStartIndex, UserAPIParamPre_PrimaryProgressReport.asPageSize);
        }

        // Add SMS Center -- Schedule SMS -- Delete SMS
        [HttpPost]
        [Route("Teacher/DeleteScheduleSMS")]
        public string DeleteScheduleSMS([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.DeleteScheduleSMS(UserAPIParamPre_PrimaryProgressReport.asSMSIds, UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId);
        }

        // Add SMS Center --  ReceivedSMS -- Get SMS
        [HttpPost]
        [Route("Teacher/GetReceivedSMS")]
        public List<GetReceivedSMS> GetReceivedSMS([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetReceivedSMS(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asUserId, UserAPIParamPre_PrimaryProgressReport.asReceiverUserRoleId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asSortExp, UserAPIParamPre_PrimaryProgressReport.asStartIndex, UserAPIParamPre_PrimaryProgressReport.asPageSize);
        }

        // Add SMS Center --  TeacherPopup
        [HttpPost]
        [Route("Teacher/GetTeacherlist")]
        public List<GetTeacherlist> GetTeacherlist([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetTeacherlist(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asUserId, UserAPIParamPre_PrimaryProgressReport.asTeacherId, UserAPIParamPre_PrimaryProgressReport.asUserRoleId, UserAPIParamPre_PrimaryProgressReport.asTypeId, UserAPIParamPre_PrimaryProgressReport.asIsForMobile);
        }

        // Add SMS Center --  Students Popup
        [HttpPost]
        [Route("Teacher/GetStudentClasslist")]
        public List<GetStudentClasslist> GetStudentClasslist([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetStudentClasslist(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asTypeId, UserAPIParamPre_PrimaryProgressReport.asLoginUserId);
        }

        // Add SMS Center --  AdminStaff Popup
        [HttpPost]
        [Route("Teacher/GetAdminStafflist")]
        public List<GetAdminStafflist> GetAdminStafflist([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetAdminStafflist(UserAPIParamPre_PrimaryProgressReport.asSchoolId);
        }

        // Add SMS Center --  Parent Teacher Association popup
        [HttpPost]
        [Route("Teacher/GetParentTeacherAssolist")]
        public List<GetParentTeacherAssolist> GetParentTeacherAssolist([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetParentTeacherAssolist(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asSchoolCommitteeId, UserAPIParamPre_PrimaryProgressReport.asLoginUserId);
        }

        // Add SMS Center --  Use Template
        [HttpPost]
        [Route("Teacher/GetUseTemplate")]
        public List<GetUseTemplate> GetUseTemplate([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetUseTemplate(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asShowSystemDefined, UserAPIParamPre_PrimaryProgressReport.asSortDirection);
        }

        // Add SMS Center --  Contact group
        [HttpPost]
        [Route("Teacher/GetUserName")]
        public GetUserNameMaster GetUserName([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetUserName(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asGroupId, UserAPIParamPre_PrimaryProgressReport.asRoleId, UserAPIParamPre_PrimaryProgressReport.asStartIndex, UserAPIParamPre_PrimaryProgressReport.asEndIndex, UserAPIParamPre_PrimaryProgressReport.asSortDirection, UserAPIParamPre_PrimaryProgressReport.asStandardDivisionId, UserAPIParamPre_PrimaryProgressReport.asFilter);
        }

        // Add SMS Center --  Contact group
        [HttpPost]
        [Route("Teacher/GetMailingGroups")]
        public List<GetMailingGroups> GetMailingGroups([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetMailingGroups(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asGroupId, UserAPIParamPre_PrimaryProgressReport.asRoleId, UserAPIParamPre_PrimaryProgressReport.asUserId);
        }

        // Add SMS Center --  Contact group
        [HttpPost]
        [Route("Teacher/GetUserRole")]
        public List<GetUserRole> GetUserRole([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetUserRole(UserAPIParamPre_PrimaryProgressReport.asSchoolId);
        }

        [HttpPost]
        [Route("Teacher/GetUserRoles")]
        public List<GetUserRole> GetUserRoles([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetUserRoles(UserAPIParamPre_PrimaryProgressReport.asSchoolId);
        }
        // Add SMS Center --  Contact group
        [HttpPost]
        [Route("Teacher/GetStandardClass")]
        public List<GetStandardClass> GetStandardClass([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return this.teacher.GetStandardClass(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId);
        }

        // Add SMS Center --  Contact group
        [HttpPost]
        [Route("Teacher/DeleteMailGroup")]
        public string DeleteMailGroup([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.DeleteMailGroup(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asGroupId, UserAPIParamPre_PrimaryProgressReport.asInsertedById);
        }

        // Add SMS Center --  Contact group
        [HttpPost]
        [Route("Teacher/AddUpdateGroup")]
        public string AddUpdateGroup([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.AddUpdateGroup(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asMailingGroupXML);
        }

        // Add SMS Center --  Contact group
        [HttpPost]
        [Route("Teacher/DeleteMailingGroupUser")]
        public string DeleteMailingGroupUser([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.DeleteMailingGroupUser(UserAPIParamPre_PrimaryProgressReport.asSchoolId, UserAPIParamPre_PrimaryProgressReport.asAcademicYearId, UserAPIParamPre_PrimaryProgressReport.asGroupId, UserAPIParamPre_PrimaryProgressReport.asUserId, UserAPIParamPre_PrimaryProgressReport.asInsertedById);
        }
        // Personal Address Phonebook | GetAddressBookList
        [HttpPost]
        [Route("Teacher/GetAddressBookList")]
        public List<GetAddressBookList> GetAddressBookList([FromBody] UserParamPre_PrimaryProgressReport UserAPIParamPre_PrimaryProgressReport)
        {
            return teacher.GetAddressBookList(UserAPIParamPre_PrimaryProgressReport.asUserId, UserAPIParamPre_PrimaryProgressReport.asSchoolId);
        }
        // Personal Address Phonebook | GetAddressBookList
        [HttpPost]
        [Route("Teacher/CheckIfPersonalAddressExists")]
        public string CheckIfPersonalAddressExists([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.CheckIfPersonalAddressExists(UserParams.asSchoolId, UserParams.asUserId, UserParams.personalAddressBookId, UserParams.userName, UserParams.userMobileNo);
        }
        // Personal Address Phonebook | InsertPersonalAddressBook
        [HttpPost]
        [Route("Teacher/InsertPersonalAddressBook")]
        public string InsertPersonalAddressBook([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.InsertPersonalAddressBook(UserParams.asSchoolId, UserParams.userId, UserParams.name, UserParams.mobileNo, UserParams.isDeleted, UserParams.insertDate, UserParams.insertedById);
        }
        // Personal Address Phonebook | UpdatePersonalAddressBook
        [HttpPost]
        [Route("Teacher/UpdatePersonalAddressBook")]
        public string UpdatePersonalAddressBook([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.UpdatePersonalAddressBook(UserParams.personalAddressBookId, UserParams.name, UserParams.mobileNo, UserParams.updateDate, UserParams.updatedById, UserParams.asSchoolId);
        }
        // Personal Address Phonebook | DeletePersonalAddressBook
        [HttpPost]
        [Route("Teacher/DeletePersonalAddressBook")]
        public string DeletePersonalAddressBook([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.DeletePersonalAddressBook(UserParams.personalAddressBookId, UserParams.isDeleted, UserParams.updateDate, UserParams.updatedById, UserParams.asSchoolId);
        }
        // Personal Address Phonebook | DeletePersonalAddressBook
        [HttpPost]
        [Route("Teacher/GetAddressBookGroupList")]
        public List<GetAddressBookGroupList> GetAddressBookGroupList([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.GetAddressBookGroupList(UserParams.asSchoolId, UserParams.userId, UserParams.asGroupMob);
        }
        // Personal Address Phonebook | DeletePersonalAddressBook
        [HttpPost]
        [Route("Teacher/GetAddressBookGroupDetails")]
        public List<GetAddressBookGroupDetails> GetAddressBookGroupDetails([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.GetAddressBookGroupDetails(UserParams.asSchoolId, UserParams.asUserId, UserParams.asGroupId);
        }
        // Personal Address Phonebook | CheckIfPersonalAddressGroupAlreadyExists
        [HttpPost]
        [Route("Teacher/CheckIfPersonalAddressGroupAlreadyExists")]
        public string CheckIfGroupAlreadyExists([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.CheckIfGroupAlreadyExists(UserParams.asSchoolId, UserParams.asPersonalBookGroupId, UserParams.asGroupName, UserParams.asUserId);
        }
        // Personal Address Phonebook | InsertPersonalAddressBookGroup
        [HttpPost]
        [Route("Teacher/InsertPersonalAddressBookGroup")]
        public string InsertPersonalAddressBookGroup([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.InsertPersonalAddressBookGroup(UserParams.asSchoolId, UserParams.asGroupName, UserParams.asGroupDetailXML, UserParams.asUserId);
        }
        // Personal Address Phonebook | UpdatePersonalAddressBookGroup
        [HttpPost]
        [Route("Teacher/UpdatePersonalAddressBookGroup")]
        public string UpdatePersonalAddressBookGroup([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.UpdatePersonalAddressBookGroup(UserParams.asSchoolId, UserParams.asGroupId, UserParams.asGroupName, UserParams.asGroupDetailXML, UserParams.asUserId);
        }
        // Personal Address Phonebook | DeletePersonalAddressBookGroup
        [HttpPost]
        [Route("Teacher/DeletePersonalAddressBookGroup")]
        public string DeletePersonalAddressBookGroup([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.DeletePersonalAddressBookGroup(UserParams.asSchoolId, UserParams.asPersonalAddressBookGroupId, UserParams.asUserId);
        }
        // Personal Address Phonebook | GetDetailsOfGroups
        [HttpPost]
        [Route("Teacher/GetDetailsOfGroups")]
        public List<GetDetailsOfGroups> GetDetailsOfGroups([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.GetDetailsOfGroups(UserParams.asSchoolId, UserParams.asGroupId);
        }

        // Block Progress Report
        [HttpPost]
        [Route("Teacher/BlockUnBlockUpdateBtn")]
        public string BlockUnBlockUpdateBtn([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.BlockUnBlockUpdateBtn(UserParams.asStudentStatus, UserParams.asSchoolId, UserParams.asAcademicYearId, UserParams.asInsertedById, UserParams.asIsBlocked, UserParams.btn);
        }

        // View Video gallery
        [HttpPost]
        [Route("Teacher/GetVideoGallery")]
        public List<GetVideoGallery> GetVideoGallery([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.GetVideoGallery(UserParams.asSchoolId, UserParams.asVideoId, UserParams.asSubjectId);
        }

        // View Video Gallery
        [HttpPost]
        [Route("Teacher/SaveUpdateVideo")]
        public string SaveUpdateVideo([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.SaveUpdateVideo(UserParams.asVideoId, UserParams.asVideoDetailId, UserParams.asVideoName, UserParams.asDescription, UserParams.asVideoURL, UserParams.asSchoolId, UserParams.asInsertedById, UserParams.asSubjectId);
        }

        // View video gallery
        [HttpPost]
        [Route("Teacher/DeleteVideo")]
        public string DeleteVideo([FromBody] UserParamPre_PrimaryProgressReport UserParams)
        {
            return teacher.DeleteVideo(UserParams.asSchoolId, UserParams.asIsDeleted, UserParams.asUpdateDate, UserParams.asUpdatedById, UserParams.asVideoId, UserParams.asId);
        }
    }
}