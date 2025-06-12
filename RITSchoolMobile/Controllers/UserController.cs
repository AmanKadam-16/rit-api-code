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
    public class UserController : ApiController
    {
        private readonly IUser user;

        public UserController(IUser user)
        {
            this.user = user;
        }
        [HttpPost]
        [Route("User/AuthenticateUser")]
        public Authenticateuser AuthenticateUser([FromBody] UserParam userAPIparam)
        {
            return this.user.AuthenticateUser(userAPIparam.asUserName, userAPIparam.asPassword, userAPIparam.asSchoolId, userAPIparam.asIsSiblingLogin);
        }
        [HttpPost]
        [Route("User/webAuthenticateUser")]
        public Authenticateuser webAuthenticateUser([FromBody] UserParam userAPIparam)
        {
            return this.user.WebAuthenticateUser(userAPIparam.asUserName);
        }
        [HttpPost]
        [Route("User/GetUsersInGroup")]
        public GetusersIngroup GetUsersInGroup([FromBody] UserParam userAPIparam)
        {
            return this.user.GetUsersInGroup(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asStdDivId, userAPIparam.asUserId, userAPIparam.asSelectedUserGroup, userAPIparam.abIsSMSCenter, userAPIparam.asName, userAPIparam.IsForLeftStudents);
        }
        [HttpPost]
        [Route("User/GetStudentsUser")]
        public Getstudentsuser GetStudentsUser([FromBody] UserParam userAPIparam)
        {
            return this.user.GetStudentsUser(userAPIparam.asSchoolId, userAPIparam.asStdDivId, userAPIparam.asAcadmeicYearId);
        }

        [HttpPost]
        [Route("User/GetAdminAndprincipalUsers")]
        public Getadminandprincipalusers GetAdminAndprincipalUsers([FromBody] UserParam userAPIparam)
        {
            return this.user.GetAdminAndprincipalUsers(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId);
        }
        [HttpPost]
        [Route("User/GetNewAppVersionDetails")]
        public GetNewappVersiondetails GetNewAppVersionDetails([FromBody] UserParam userAPIparam)
        {
            return this.user.GetNewAppVersionDetails(userAPIparam.asDeviceType, userAPIparam.asUserCurrentVersion, userAPIparam.aiSchoolId, userAPIparam.asOldLoginVersion, userAPIparam.aiUserId);
        }
        [HttpPost]
        [Route("User/CheckForUserLoginExpires")]
        public CheckForuserLoginexpires CheckForUserLoginExpires([FromBody] UserParam userAPIparam)
        {
            return this.user.CheckForUserLoginExpires(userAPIparam.asSchoolId, userAPIparam.asUserId, userAPIparam.asAcademicYearId, userAPIparam.asUserRoleId , userAPIparam.asLastPasswordChangeDate);
        }
        [HttpPost]
        [Route("User/GetScreensAccessPermissions")]
        public List<ScreenAccessPermissions> GetScreensAccessPermissions([FromBody] UserParam userAPIparam)
        {
            return this.user.GetScreensAccessPermissions(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.asUserRoleId, userAPIparam.abIsPreprimaryTeacher = false);
        }
        [HttpPost]
        [Route("User/Getmodulespermissions")]
        public Getmodulespermissions Getmodulespermissions([FromBody] UserParam userAPIparam)
        {
            return this.user.Getmodulespermissions(userAPIparam.asSchoolId, userAPIparam.asAcademicYearId, userAPIparam.asUserId, userAPIparam.abIsPreprimary = false, userAPIparam.abXseedApplicable = false);
        }
        [HttpPost]
        [Route("User/GetAlbums")]
        public Getalbums GetAlbums([FromBody] SchoolParam schoolAPIParam)
        {
            return this.user.GetAlbums(schoolAPIParam.asSchoolId, schoolAPIParam.asMonth, schoolAPIParam.asYear);
        }
        [HttpPost]
        [Route("User/GetImages")]
        public Getimages GetImages([FromBody] UserParam userAPIparam)
        {
            return this.user.GetImages(userAPIparam.asSchoolId, userAPIparam.asGalleryName);
        }
        [HttpPost]
        [Route("User/GetVideoURL")]
        public string GetVideoURL([FromBody] UserParam userAPIparam)
        {
            return this.user.GetVideoURL(userAPIparam.asSchoolId, userAPIparam.asGalleryName);
        }
        [HttpPost]
        [Route("User/GetVideoGallery")]
        public GetVideogallery GetVideoGallery([FromBody] SchoolParam schoolAPIParam)
        {
            return this.user.GetVideoGallery(schoolAPIParam.asSchoolId, schoolAPIParam.asMonth, schoolAPIParam.asYear, schoolAPIParam.asUserId);
        }
        [HttpPost]
        [Route("User/GetSubjectsForVideoGallery")]
        public GetsubjectsforVideogallery GetSubjectsForVideoGallery([FromBody] UserParam userAPIparam)
        {
            return this.user.GetSubjectsForVideoGallery(userAPIparam.asSchoolId, userAPIparam.aiVideoId);
        }
        [HttpPost]
        [Route("User/GetVideoGalleryComments")]
        public GetVideogallerycomments GetVideoGalleryComments([FromBody] UserParam userAPIparam)
        {
            return this.user.GetVideoGalleryComments(userAPIparam.asSchoolId, userAPIparam.asSubjectId, userAPIparam.asVideoId);
        }
        [HttpPost]
        [Route("User/GetAllVideoDetails")]
        public List<VideoDetails> GetAllVideoDetails([FromBody] UserParam userAPIparam)
        {
            return this.user.GetAllVideoDetails(userAPIparam.asSchoolId, userAPIparam.asVideoId);
        }
        [HttpPost]
        [Route("User/SaveUserLoginDetails")]
        public LastLoginResult SaveUserLoginDetails([FromBody] UserParam userAPIparam)
        {
           return this.user.SaveUserLoginDetails(userAPIparam.asSchoolId, userAPIparam.asUserId);
        }

        [HttpPost]
        [Route("User/GetUserDetails")]
        public UserDetails GetStudentDetails([FromBody] SchoolParam schoolAPIParam)
        {
            return this.user.GetUserDetails(schoolAPIParam.asUserId, schoolAPIParam.asSchoolId, schoolAPIParam.asRoleId);
        }

        [HttpPost]
        [Route("User/GetNoticeBoardDetails")]
        public NoticeBoardDetailsResult GetNoticeBoardDetails([FromBody] SchoolParam schoolAPIParam)
        {
            return this.user.GetNoticeBoardDetails(schoolAPIParam.aiSchoolId, schoolAPIParam.aiAcademicYearId, schoolAPIParam.aiUserRoleId);
        }

        [HttpPost]
        [Route("User/GetUserLoginDetails")]
        public GetUserLoginDetailsResult GetUserLoginDetails([FromBody] UserParam userAPIparam)
        {
            return this.user.GetUserLoginDetails(userAPIparam.aiSchoolId, userAPIparam.aiUserId.ToInt());
        }
    }
}
