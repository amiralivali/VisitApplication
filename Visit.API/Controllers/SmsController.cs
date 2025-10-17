using Kavenegar;
using Microsoft.AspNetCore.Mvc;
using Visit.Shared;

namespace Visit.API.Controllers
{
    public class SmsController : BaseController
    {
        [HttpPost]
        public OprationResult Send([FromBody]string smsText)
        {
            var senderClient = Constance.senderClient;
            var receptor = "09361842050";//به دلیل کامل نبودن احراز هویت نمیتوان به شماره های دیگر ارسال شود
            var message = smsText;
            var api = new KavenegarApi(Constance.API);
            var result = api.Send(senderClient, receptor, message);
            if (result.Status == 5)
            {
                return OprationResult.Success(Messages.Send);
            }
            else
            {
                return OprationResult.RunTimeError();
            }
        }
    }
}
