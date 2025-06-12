using SchoolMobileEntities;
using SchoolMobileInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RITSchoolMobile.Controllers
{
    public class LibraryController : ApiController
    {
        private readonly ILibrary library;

        public LibraryController(ILibrary library)
        {
            this.library = library;
        }

        [HttpPost]
        [Route("Library/GetLanguages")]
        public GetLanguage GetLanguages([FromBody] SchoolParam schoolAPIParam)
        {
            return this.library.GetLanguages(schoolAPIParam.aiSchoolId);
        }

        [HttpPost]
        [Route("Library/GetAssociatedStandards")]
        public Get_Standard GetAssociatedStandards([FromBody] SchoolParam schoolAPIParam)
        {
            return this.library.GetAssociatedStandards(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId);
        }

        [HttpPost]
        [Route("Library/GetIssuedBookDetailsofUser")]
        public GetIssuedBookDetailsofUserlist GetIssuedBookDetailsofUser([FromBody] SchoolParam schoolAPIParam)
        {
            return this.library.GetIssuedBookDetailsofUsers(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiUserId);
        }

        [HttpPost]
        [Route("Library/GetPagedBookList")]
        public GetPagedBooksList GetPagedBookList([FromBody] SchoolParam schoolAPIParam)
        {
            return this.library.GetPagedBookList(schoolAPIParam.aiSchoolId, schoolAPIParam.asBookName, schoolAPIParam.asAccessionNumber, schoolAPIParam.asAuthorName, schoolAPIParam.asPublisher, schoolAPIParam.asLanguage, schoolAPIParam.aiStandardId, schoolAPIParam.aiMediaType, schoolAPIParam.aiBookId, schoolAPIParam.aiParentStaffId, schoolAPIParam.aiEndIndex, schoolAPIParam.aiStartRowIndex, schoolAPIParam.asSortExpression);
        }

        [HttpPost]
        [Route("Library/GetReservedBookDetails")]
        public GetReservedBookDetails GetReservedBookDetails([FromBody] SchoolParam schoolAPIParam)
        {
            return this.library.GetReservedBookDetails(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYearId, schoolAPIParam.aiUserId, schoolAPIParam.asBookTitle, schoolAPIParam.asUserName, schoolAPIParam.aiStartRowIndex, schoolAPIParam.aiEndIndex, schoolAPIParam.asSortExpression, schoolAPIParam.aiAllUser);
        }

        [HttpPost]
        [Route("Library/ReserveBook")]
        public string ReserveBook([FromBody] SchoolParam schoolAPIParam)
        {
            return this.library.ReserveBook(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId, schoolAPIParam.aiUserId, schoolAPIParam.aiUserRoleId, schoolAPIParam.aiBookId, schoolAPIParam.ReservedByParent, schoolAPIParam.InsertedById, schoolAPIParam.aiFlag);
        }

        [HttpPost]
        [Route("Library/CancelBookReservation")]
        public string CancelBookReservation([FromBody] SchoolParam schoolAPIParam)
        {
            return this.library.CancelBookReservation(schoolAPIParam.aiUserId, schoolAPIParam.aiBookId, schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYrId);
        }
    }
}
