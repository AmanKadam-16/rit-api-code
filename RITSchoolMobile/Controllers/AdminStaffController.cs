using SchoolMobileEntities;
using SchoolMobileInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RITSchoolMobile.Controllers
{
    public class AdminStaffController : ApiController
    {
        private readonly IAdminStaff adminStaff;

        public AdminStaffController(IAdminStaff adminStaff) 
        {
            this.adminStaff = adminStaff;
        }

        [HttpPost]
        [Route("AdminStaff/GetAdminStaff")]
        public StaffList GetAdminStaff([FromBody]SchoolParam schoolParam)
        {
            return this.adminStaff.GetAdminStaff(schoolParam.asSchoolId, schoolParam.asUserId, schoolParam.asRoleId);
        }
        [HttpPost]
        [Route("AdminStaff/GetScreenAccess")]
        public ScreenAcess GetScreenAccess([FromBody] SchoolParam schoolParam)

        {
            return this.adminStaff.GetScreenAccess(schoolParam.asUserId,schoolParam.asScreenLevel , schoolParam.asSchoolId);

        }
        [HttpPost]
        [Route("AdminStaff/GetTemplate")]
        public AdminSMSTemplate GetTemplate([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetTemplate(schoolParam.asSchoolId, schoolParam.sortDirection, schoolParam.asShowSystemDefined);
        }
        [HttpPost]
        [Route("AdminStaff/GetTeacherandExamForMarksConfiguration")]
        public GetTestMarksConfiguration GetTeacherandExamForMarksConfiguration([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetTeacherandExamForMarksConfiguration(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asUserId, schoolParam.asStandardDivisionId);
        }

        [HttpPost]
        [Route("AdminStaff/GetTecherWiseDetails")]
        public GetTecherWiseDetails GetTecherWiseDetails([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetTecherWiseDetails(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asTeacherId, schoolParam.asTestId, schoolParam.asStandardDivisionId, schoolParam.asAllowPartialSubmit);
        }

        [HttpPost]
        [Route("AdminStaff/GetClassSelectedIndexChanged")]
        public Class_SelectedIndexChanged GetClass_SelectedIndexChanged([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetClass_SelectedIndexChanged(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asTeacherId, schoolParam.asTestId, schoolParam.asStandardDivisionId, schoolParam.asAllowPartialSubmit);
        }

        [HttpPost]
        [Route("GetExamSelectedIndexChanged")]
        public Exams_SelectedIndexChanged GetExam_SelectedIndexChanged([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetExam_SelectedIndexChanged(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asTeacherId, schoolParam.asTestId, schoolParam.asStandardDivisionId, schoolParam.asAllowPartialSubmit);
        }
        [HttpPost]
        [Route("AdminStaff/GetAllClassTeacher")]
        public GetClassTeacher GetAllClassTeacher([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetAllClassTeacher(schoolParam.asSchoolId, schoolParam.asAcademicYearId);

        }
        [HttpPost]
        [Route("AdminStaff/GetTeachers_SelectedIndexChanged")]
        public Teachers_SelectedIndexChanged GetTeachers_SelectedIndexChanged([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetTeachers_SelectedIndexChanged(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStdDivId, schoolParam.asTermId);
        }
        [HttpPost]
        [Route("AdminStaff/GetStudentProgressResult")]
        public StudentProgressReport GetStudentProgressResult([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetStudentProgressResult(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStudentId, schoolParam.asUserId);

        }
        [HttpPost]
        [Route("AdminStaff/Getclassteacher")]
        public getclassTeacher classTeacher([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.classTeacher(schoolParam.asSchoolId, schoolParam.asAcademicYearId);
        }
        [HttpPost]
        [Route("AdminStaff/gettest")]
        public gettestlist testlist([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.testlist(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardDivisionId);

        }

        [HttpPost]
        [Route("AdminStaff/getExamStatus")]
        public getExamStatus getExamStatus([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.getExamDetails(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asStandardDivisionId, schoolParam.TestID, schoolParam.mbIsPublished = "Y", schoolParam.mbToppersGenerated = "Y");
        }
        [HttpPost]
        [Route("AdminStaff/getSchoolStaffBirthday")]
        public GetSchoolStaffBirthday getSchoolStaffBirthday([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.getSchoolStaffBirthday(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.pagesize, schoolParam.startindex);
        }

        [HttpPost]
        [Route("AdminStaff/HouseList")]
        public HouseList HouseConfig([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.HouseConfig(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asSortExpression);
        }
        [HttpPost]
        [Route("AdminStaff/GetAllStudentForHouseAssignment")]
        public StudentHouse GetAllStudentForHouseAssignment([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetAllStudentForHouseAssignment(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.aiStandardId, schoolParam.asDivisionId, schoolParam.aiConfigured);
        }
        [HttpPost]
        [Route("AdminStaff/GetAllClassForStandard")]
        public GetStandardlst GetAllForStandard([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetAllDivisionsForStandard(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.Is_Deleted, schoolParam.AllowHouseConfiguration=1);
        }
        [HttpPost]
        [Route("AdminStaff/GetDivisionsForStandard")]
        public GetAllDivisions GetDivisionsForStandard([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetDivisionsForStandard(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.standard_id);

        }
        [HttpPost]
        [Route("AdminStaff/GetallStandardDivisionNotice")]
        public NoticeStdDiv GetallStandardDivisionNotice([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetallStandardDivisionNotice(schoolParam.asSchoolId, schoolParam.asAcademicYearId);

        }
        [HttpPost]
        [Route("AdminStaff/Configurationmenu")]
        public MenuConfigration Configurationmenu([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.Configurationmenu(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.asFinancialYearId, schoolParam.asUserId, schoolParam.asUserRoleId, schoolParam.aiParentStaffId);

        }
        [HttpPost]
        [Route("AdminStaff/GetStudentwiseRemarkConfigDetails")]
        public RemarksConfigration GetStudentwiseRemarkConfigDetails([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetStudentwiseRemarkConfigDetails(schoolParam.asSchoolId, schoolParam.asAcademicYearId, schoolParam.aiStandardId, schoolParam.aiStudentId, schoolParam.aiTermId);
        }
        [HttpPost]
        [Route("AdminStaff/GetTestwiseTerm")]
        public Testterm GetTestwiseTerm([FromBody] SchoolParam schoolParam)
        {
            return this.adminStaff.GetTestwiseTerm(schoolParam.asSchoolId, schoolParam.asAcademicYearId="0");
        }





    }
}
