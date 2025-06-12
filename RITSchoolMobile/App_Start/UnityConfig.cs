using SchoolMobileInterface;
using SchoolMobileInterface.Teacher;
using SchoolMobileRepository;
using SchoolMobileRepository.Common;
using SchoolMobileRepository.Dashboard;
using SchoolMobileRepository.Library;
using SchoolMobileRepository.Payment;
using SchoolMobileRepository.ProgressReport;
using SchoolMobileRepository.PushNotification;
using SchoolMobileRepository.School;
using SchoolMobileRepository.SMSDetail;
using SchoolMobileRepository.Student;
using SchoolMobileRepository.Teacher;
using SchoolMobileRepository.User;
using SchoolMobileRepository.Transport;
using System.Web.Http;
using Unity;
using Unity.WebApi;
using SchoolMobileRepository.Homework;

namespace RITSchoolMobile
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IMessageCenter, MessageCenter>();
            container.RegisterType<IPayment, PaymentRepository>();
            container.RegisterType<IProgressReport, ProgressReportRepository>();
            container.RegisterType<IPushNotification, PushNotificationRepository>();
            container.RegisterType<ISchool, SchoolRepository>();
            container.RegisterType<IStudent, StudentRepository>();
            container.RegisterType<ITeacher, TeacherRepository>();
            container.RegisterType<IHomework, HomeworkRepository>();
            container.RegisterType<IPrePrimaryProgressReport, PrePrimaryProgressReportRepository>();
            container.RegisterType<IRequsition, RequsitionRepository>();
            container.RegisterType<IFinalResult, FinalResultRepository>();
            container.RegisterType<ILeaveDetails, LeaveDetailsRepository>();
            container.RegisterType<IUser, UserRepository>();
            container.RegisterType<IAdminStaff, AdminStaffRepository>();
            container.RegisterType<ISMSDetail,SMSDetail>();
            container.RegisterType<ILibrary, LibraryRepository>();
            container.RegisterType<IDashboard, DashboardRepository>();
            container.RegisterType<ITransport, TransportRepository>();
            container.RegisterType<ISchoolNotices, SchoolNoticesRepository>();
            container.RegisterType<ISMSCenter, SMSCenterRepository>();
            container.RegisterType<IWeeklyTimeTable, WeeklyTimeTableRepository>();
            container.RegisterType<INewdemo, NewdemoRepository>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}