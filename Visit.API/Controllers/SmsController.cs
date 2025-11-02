using Microsoft.AspNetCore.Mvc;
using Visit.BLL;
using Visit.Shared;

namespace Visit.API.Controllers
{
    public class SmsController : BaseClassController
    {
        [HttpPost]
        public OprationResult Send([FromBody]string smsText)
        {
            SmsService smsService = new SmsService();
            var result = smsService.Send(smsText);
            return result;
        }
    }
}
