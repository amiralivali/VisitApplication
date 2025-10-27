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
            SmsController smsController = new SmsController();
            var result = smsController.Send(smsText);
            return result;
        }
    }
}
