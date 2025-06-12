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
   
        public class NewdemoController : ApiController
        {
            private readonly INewdemo newdemo;

            public NewdemoController(INewdemo newdemo)
            {
                this.newdemo = newdemo;
            }

        [HttpPost]
        [Route("Teacher/GetAllClassTeachers")]
        public List<GetAllClassTeachers> GetAllClassTeachers([FromBody] UserParamNewdemo userAPIparam)
        {
            return this.newdemo.GetAllClassTeachers(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }


        [HttpPost]
        [Route("Teacher/GetStudentsListForStdDiv")]
        public List<GetStudentsListForStdDiv> GetStudentsListForStdDiv([FromBody] UserParamNewdemo UserParamNewdemo)
        {
            return this.newdemo.GetStudentsListForStdDiv(UserParamNewdemo.asSchoolId, UserParamNewdemo.asAcademicYearId, UserParamNewdemo.asStandardDivision_Id);
        }

        //----DeleteLeave
        [HttpPost]
        [Route("Teacher/DeleteLeave")]
        public string DeleteLeave([FromBody] UserParam userAPIparam)
        {
            return this.newdemo.DeleteLeave(userAPIparam.asSchoolId, userAPIparam.asId, userAPIparam.asUpdatedById);
        }
    }
    }