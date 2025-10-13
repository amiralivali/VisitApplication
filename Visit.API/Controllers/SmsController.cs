using Kavenegar;
using Microsoft.AspNetCore.Mvc;
using Visit.Shared;

namespace Visit.API.Controllers
{
    public class SmsController : BaseController
    {
        [HttpPost()]
        public OprationResult Send(string smsText)
        {
            var senderClient = "2000660110";
            var receptor = "09361842050";//به دلیل کامل نبودن احراز هویت نمیتوان به شماره های دیگر ارسال شود
            var message = smsText;
            var api = new KavenegarApi("6A53643770437645526E514F4352377776424B6743354C526C7A6438646F6435534B33366D6E57794847513D");
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
