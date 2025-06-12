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
    public class PaymentController : ApiController
    {
        private readonly IPayment payment;

        public PaymentController(IPayment payment)
        {
            this.payment = payment;
        }
        [HttpPost]
        [Route("Payment/GetAvailablePaymentGateways")]
        public GatewayList GetAvailablePaymentGateways([FromBody]SchoolParam schoolParam)
        {
            return this.payment.GetAvailablePaymentGateways(schoolParam.asSchoolId);
        }
    }
}
