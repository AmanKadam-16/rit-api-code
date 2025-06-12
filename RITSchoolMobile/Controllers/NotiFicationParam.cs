using SchoolMobileEntities.PushNotificationsModel;
using System.Collections.Generic;

namespace RITSchoolMobile.Controllers
{
    public class NotiFicationParam
    {
        public NotificationMessageHeadings notificationHeading { get;  set; }
        public string schoolId { get;  set; }
        public int[] targetUsers { get;  set; }
        public Dictionary<string, string> notificationParameters { get; set; }
    }
}