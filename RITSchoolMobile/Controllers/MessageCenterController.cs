using SchoolMobileEntities;
using SchoolMobileInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;
using Utility;

namespace RITSchoolMobile.Controllers
{
    public class MessageCenterController : ApiController
    {
        private readonly IMessageCenter messagecenter;

        public MessageCenterController(IMessageCenter messagecenter)
        {
            this.messagecenter = messagecenter;
        }
        [HttpPost]
        [Route("MessageCenter/GetMessages")]
        public MessageList GetMessages([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetMessages(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asUserId, messgApiparam.abIsSMSCenter, messgApiparam.asUserRoleId, messgApiparam.asFilter, messgApiparam.asPageIndex, messgApiparam.asMonthId, messgApiparam.asOperator, messgApiparam.asDate, messgApiparam.asSortExp, messgApiparam.asSortDirection);
        }
        [HttpPost]
        [Route("MessageCenter/GetMessagesCount")]
        public MessageCount GetMessagesCount([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetMessagesCount(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asUserId, messgApiparam.abIsSMSCenter, messgApiparam.asUserRoleId, messgApiparam.asFilter, messgApiparam.asFlag, messgApiparam.asMonthId, messgApiparam.asOperator, messgApiparam.asDate);
        }
        [HttpPost]
        [Route("MessageCenter/GetMessage")]
        public SingleMessage GetMessage([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetMessage(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asMessageDetailsId, messgApiparam.asReceiverId);
        }
        [HttpPost]
        [Route("MessageCenter/SendMessage")]
        public Sendmessage SendMessage([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.SendMessage(messgApiparam.asSchoolId, messgApiparam.aoMessage, messgApiparam.asSelectedUserIds, messgApiparam.asSelectedStDivId, messgApiparam.asIsSoftwareCordinator, messgApiparam.asMessageId, messgApiparam.sIsReply, messgApiparam.asIsForward, messgApiparam.asSchoolName, messgApiparam.attachmentFile, messgApiparam.asFileName, messgApiparam.asTemplateRegistrationId, messgApiparam.asSelectedUserIdsCc, messgApiparam.asSelectedStDivIdCc, messgApiparam.asIsSoftwareCordinatorCc, messgApiparam.asDisplayTextCc);
        }
        [HttpPost]
        [Route("MessageCenter/MoveToTrash")]
        public Movetotrash MoveToTrash([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.MoveToTrash(messgApiparam.asSchoolId, messgApiparam.asIsArchive, messgApiparam.asMessageRecieverDetailsId, messgApiparam.asMessageDetailsId, messgApiparam.asIsCompeteDelete, messgApiparam.asFlag);
        }
        [HttpPost]
        [Route("MessageCenter/GetTrashMessages")]
        public GettrashMessg GetTrashMessages([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetTrashMessages(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asUserId, messgApiparam.asUserRoleId, messgApiparam.asFilter, messgApiparam.asPageIndex, messgApiparam.asMonthId, messgApiparam.asOperator, messgApiparam.asDate, messgApiparam.asSortExp, messgApiparam.asSortDirection);
        }
        [HttpPost]
        [Route("MessageCenter/GetScheduledSMS")]
        public MessageSMSList GetScheduledSMS([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetScheduledSMS(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asUserId, messgApiparam.asUserRoleId);
        }

        [HttpPost]
        [Route("MessageCenter/GetSentMessages")]
        public MessageSMSList GetSentMessages([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetSentMessages(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asUserId, messgApiparam.asUserRoleId, messgApiparam.abIsSMSCenter, messgApiparam.asFilter, messgApiparam.asPageIndex, messgApiparam.asMonthId, messgApiparam.asOperator, messgApiparam.asDate, messgApiparam.asSortExp, messgApiparam.asSortDirection);
        }
        [HttpPost]
        [Route("MessageCenter/GetAllSentSMS")]
        public MessageSMSList GetAllSentSMS([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetAllSentSMS(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asUserId, messgApiparam.asUserRoleId);
        }
        [HttpPost]
        [Route("MessageCenter/GetNewMessageCount")]
        public GetnewMessgcount GetNewMessageCount([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetNewMessageCount(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asUserId);
        }

        [HttpPost]
        [Route("MessageCenter/ShowPTAOption")]
        public PTAOptionStatus ShowPTAOption([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.ShowPTAOption(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asUserId);
        }

        [HttpPost]
        [Route("MessageCenter/DeleteMessagePermanently")]
        public MessageDeletionStatus DeleteMessagePermanently([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.DeleteMessagePermanently(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asUserId, messgApiparam.asMessageIds);
        }

        [HttpPost]
        [Route("MessageCenter/UpdateUserEmailSetting")]
        public UserEmailSettingStatus UpdateUserEmailSetting([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.UpdateUserEmailSetting(messgApiparam.asSchoolId, messgApiparam.asUserId, messgApiparam.asCanReceiveMail, messgApiparam.asEmailAddress);
        }

        [HttpPost]
        [Route("MessageCenter/GetUserEmailSettings")]
        public UserEmailSettingStatusResult GetUserEmailSettings([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetUserEmailSettings(messgApiparam.asSchoolId, messgApiparam.asUserId);
        }

        [HttpPost]
        [Route("MessageCenter/UpdateReadReceiptStatus")]
        public UpdateReadReceiptResult UpdateReadReceiptStatus([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.UpdateReadReceiptStatus(messgApiparam.asSchoolId, messgApiparam.asAcademicYearId, messgApiparam.asRequestReadReceipt, messgApiparam.asReceiverId);
        }

        [HttpPost]
        [Route("MessageCenter/UnDeleteMessages")]
        public UnDeleteMessagesResult UnDeleteMessages([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.UnDeleteMessages(messgApiparam.asMessageRecieverDetailsIds, messgApiparam.asMessageDetailsIds, messgApiparam.asSchoolId);
        }

        [HttpPost]
        [Route("Messagecenter/GetContactGroupUsers")]
        public GetContactGroupResult GetContactGroupUsers([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetContactGroupUsers(messgApiparam.asScholId, messgApiparam.asAcademicYearId, messgApiparam.aiIsForUser, messgApiparam.asGroupId);
        }

        [HttpPost]
        [Route("Messagecenter/GetContactGroups")]
        public ContactGroupDetailsResult GetContactGroups([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetContactGroups(messgApiparam.asScholId, messgApiparam.asAcademicYearId, messgApiparam.asGroupId, messgApiparam.asUserRoleId, messgApiparam.asUserId);
        }

        [HttpPost]
        [Route("MessageCenter/GetReadReceiptStatus")]
        public GetReadReceiptStatusResult GetReadReceiptStatus([FromBody] MessgCenterParam messgApiparam)
        {
            return this.messagecenter.GetReadReceiptStatus(messgApiparam.asSchoolId.ToInt(), messgApiparam.asAcademicYearId.ToInt(), messgApiparam.asMessageDetailsId.ToInt());
        }

        [HttpPost]
        [Route("Messagecenter/GetReadReceiptDetails")]
        public GetReadReceiptDetailsResult GetReadReceiptDetails([FromBody] MessgCenterParam messgCenterParam)
        {
            return this.messagecenter.GetReadReceiptDetails(messgCenterParam.aiSchoolId, messgCenterParam.aiAcademicYearId, messgCenterParam.aiMessageDetailId);
        }

        [HttpPost]
        [Route("MessageCenter/UpdateMessageReadUnreadStatus")]
        public ReadUnreadStatusResult UpdateMessageReadUnreadStatus([FromBody] MessgCenterParam messgCenterParam)
        {
            return this.messagecenter.UpdateMessageReadUnreadStatus(messgCenterParam.aiSchoolId, messgCenterParam.aiAcademicYearId, messgCenterParam.asMessageReceiverIds, messgCenterParam.aiReceiverUserId, messgCenterParam.abMarkAsRead);
        }

        [HttpPost]
        [Route("MessageCenter/GetOperators")]
        public GetOperatorsResult GetOperators([FromBody] MessgCenterParam messgCenterParam)
        {
            return this.messagecenter.GetOperators(messgCenterParam.aiSchoolId, messgCenterParam.aiAcademicYearId);
        }

        [HttpPost]
        [Route("Messagecenter/GetAllDraftMessageDetails")]
        public AllDraftMessagesResult GetAllDraftMessageDetails([FromBody] MessgCenterParam messgCenterParam)
        {
            return this.messagecenter.GetAllDraftMessageDetails(messgCenterParam.asSchoolId.ToInt(), messgCenterParam.asAcademicYearId.ToInt(), messgCenterParam.asUserId.ToInt(), messgCenterParam.asFilter, messgCenterParam.asMonthId.ToInt(), messgCenterParam.asOperator, messgCenterParam.asDate, messgCenterParam.asPageIndex, messgCenterParam.asSortExp, messgCenterParam.asSortDirection);
        }

        [HttpPost]
        [Route("Messagecenter/GetDraftMessageDetails")]
        public DraftMessageResult GetDraftMessageDetails([FromBody] MessgCenterParam messgCenterParam)
        {
            return this.messagecenter.GetDraftMessageDetails(messgCenterParam.aiSchoolId, messgCenterParam.aiAcademicYearId, messgCenterParam.aiDraftId, messgCenterParam.aiUserId);
        }

        [HttpPost]
        [Route("Messagecenter/SaveDraftMessageDetails")]
        public SaveDraftMessageResult SaveDraftMessageDetails([FromBody] MessgCenterParam messgCenterParam)
        {
            return this.messagecenter.SaveDraftMessageDetails(messgCenterParam.aiDraftId, messgCenterParam.aoMessage);
        }

        [HttpPost]
        [Route("Messagecenter/DeleteDraftMessageDetails")]
        public DeleteDraftMessageResult DeleteDraftMessageDetails([FromBody] MessgCenterParam messgCenterParam)
        {
            return this.messagecenter.DeleteDraftMessageDetails(messgCenterParam.aiSchoolId, messgCenterParam.aiAcademicYearId, messgCenterParam.aiDraftId, messgCenterParam.aiUserId);
        }

        //[HttpPost]
        //[Route("MessageCenter/UploadFile")]
        //public void UploadFile([FromBody] MessgCenterParam messgApiparam)
        //{
        //    byte[] byteArray = Encoding.UTF8.GetBytes(messgApiparam.stream);
        //    MemoryStream stream = new MemoryStream(byteArray);
        //    this.messagecenter.UploadFile(messgApiparam.asFileName, messgApiparam.asScholId, messgApiparam.MessageId, stream);
        //}
    }
}
