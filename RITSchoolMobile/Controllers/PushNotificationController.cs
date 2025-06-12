using SchoolMobileEntities;
using SchoolMobileEntities.PushNotificationsModel;
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
    public class PushNotificationController : ApiController
    {
        private readonly IPushNotification pushNotification;

        public PushNotificationController(IPushNotification pushNotification)
        {
            this.pushNotification = pushNotification;
        }

        [HttpPost]
        [Route("PushNotification/GetTestMessage")]
        public string GetTestMessage()
        {
            return this.pushNotification.GetTestMessage();
        }
        [HttpPost]
        [Route("PushNotification/SendNotification")]
        public void SendNotification([FromBody]NotiFicationParam notificationParam)
        {
            this.pushNotification.SendNotification(notificationParam.notificationHeading, notificationParam.schoolId, notificationParam.targetUsers, notificationParam.notificationParameters);
        }
        [HttpPost]
        [Route("PushNotification/GetUserPushNotifications")]
        public PushNotificationList GetUserPushNotifications([FromBody]SchoolParam schoolParam)
        {
            return this.pushNotification.GetUserPushNotifications(schoolParam.asSchoolId,schoolParam.asUserId);
        }
        [HttpPost]
        [Route("PushNotification/RegisterDevice")]
        public long RegisterDevice([FromBody]SchoolParam schoolParam)
        {
            return this.pushNotification.RegisterDevice(schoolParam.asSchoolId, schoolParam.asUserId, schoolParam.asRegistrationId, schoolParam.asDeviceId, schoolParam.asDeviceType);
        }

    }
}
