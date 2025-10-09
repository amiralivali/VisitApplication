using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visit.Shared;

namespace Visit.UI
{
    public static class SmsKavenegar
    {
        public static async Task<OprationResult> Send(int randomCode)
        {
            HttpClientHelper httpClientHelper = new HttpClientHelper();
            string text = Messages.SmsText + Environment.NewLine + randomCode;
            var checkSms = await httpClientHelper.PostAsync<OprationResult, string>(RouteConstants.SendSms, text);
            return checkSms;
        }
    }
}
