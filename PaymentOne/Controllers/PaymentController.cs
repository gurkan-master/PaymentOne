using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentOne.GoodPayment;

namespace PaymentOne.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        [HttpPost(Name = "PayWithAnything")]
        public string PayWithAnything(string paymentType)
        {
            PaymentFactory paymentFactory = new PaymentFactory();

            IPayment payment = paymentFactory.GeneratePayment(paymentType);

            payment.Pay();

            return "Ok";
        }
    }
}
