using System;
using System.Threading.Tasks;
using System.Web.Routing;
using Visit.Shared;

namespace Visit.UI
{
    public  class UserCheckSmsHandler
    {
        HttpClientHelper httpClientHelper;
        public UserCheckSmsHandler()
        {
            httpClientHelper=HttpClientHelper.GetInstance();
        }
        public async Task<OprationResult> SendSmsIfDoctorExistsAsync(string randomCode,string nezam, string mobile)
        {
            string route = string.Format(RouteConstants.ExistDoctor, nezam, mobile);
            bool check = await httpClientHelper.GetAsync<bool>(route);
            if (check)
            {
                var result = await SendSmsAsync(randomCode);
                return result;
            }
            else
            {
                return OprationResult.UnSuccess(Messages.NotExist);
            }
        }
        public async Task<OprationResult> SendSmsIfBimarExistsAsync(string randomCode, string nationalCode, string mobile)
        {
            string route = string.Format(RouteConstants.ExistBimar, nationalCode, mobile);
            bool check = await httpClientHelper.GetAsync<bool>(route);
            if (check)
            {
                var result = await SendSmsAsync(randomCode);
                return result;
            }
            else
            {
                return OprationResult.UnSuccess(Messages.NotExist);
            }
        }
        public async Task<OprationResult> SendSmsAsync(string randomCode)
        {
            string text = Messages.SmsText + Environment.NewLine + randomCode;
            var checkSms = await httpClientHelper.PostAsync<OprationResult, string>(RouteConstants.SendSms, text);
            return checkSms;
        }
    }
}
